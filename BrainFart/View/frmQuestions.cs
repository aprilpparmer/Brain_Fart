using BrainFart.Controller;
using BrainFart.Model;
using BrainFart.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrainFart
{
    public partial class frmQuestions : Form
    {
        private UserAccessController userAccess = UserAccessController.Instance;
        private Questions question;
        private List<Questions> questionList;
        private List<Answers> answerList;
        private Answers answer;
        private frmEndGame endGame;
        private int numberOfQuestions;
        private int categoryID;
        private string gameOverMode;
        private mainForm main;
        private int strike;
        private string correct;
        private int difficultyID;
        
        public frmQuestions(int categoryID, int numberOfQuestions, string gameOverMode, int difficultyID)
        {

            try
            {
                InitializeComponent();
                UserAccessController uac = UserAccessController.Instance;
                if (uac.CurrentLoggedUser != null)
                {
                    this.loggedInLabel.Text = uac.CurrentLoggedUser.UserName;
                }
                this.getListOfQuestions(categoryID, numberOfQuestions, difficultyID);
                this.gameOverMode = gameOverMode;
                this.loadQuestion();
                this.scoreLabel.Text = Convert.ToString(0);
                this.strike = 0;
                this.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }


        private List<Questions> getListOfQuestions(int categoryID, int numberOfQuestions, int difficultyID)
        {
            List<Questions> copyList = new List<Questions>();
            this.questionList = new List<Questions>();
            if (categoryID == -1 && difficultyID == -1)
            {
                copyList = BrainFartController.GetAllQuestions();
            }
            else
            {
                copyList = BrainFartController.GetQuestionsFromCategory(categoryID, difficultyID);
            }


            Random rnd = new Random();
            for (int i = 0; i < numberOfQuestions; i++) 
            {
                int r = rnd.Next(copyList.Count);
                Questions q = copyList[r];
                this.questionList.Add(q);
                copyList.Remove(q);
            }

            return this.questionList;
        }

        private void gameMode()
        {
            if(this.gameOverMode.Equals("Three Strikes"))
            {
                if (this.correct.Equals("Incorrect"))
                {
                    this.strike++;
                    MessageBox.Show("Strike " + this.strike,
                    "BrainFart ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);

                    if(this.strike == 3)
                    {
                        this.Hide();
                        endGame = new frmEndGame();
                        endGame.totalPoint = this.scoreLabel.Text;
                        this.endGame.ShowDialog();
                    }

                }
            }

        
        }

        public void loadQuestion()
        {
            if (this.questionList.Count == 0)
            {
                this.Hide();
                endGame = new frmEndGame();
                endGame.totalPoint = this.scoreLabel.Text;
                this.endGame.ShowDialog();
               
            }
            else
            {
                lblCorrectAnswer.Text = " ";
                this.answerChoice1.Checked = false;
                this.answerChoice2.Checked = false;
                this.answerChoice3.Checked = false;
                this.answerChoice4.Checked = false;

                //Loads a new question
                this.getQuestion();
                //Loads the answer choices for the question
                int id = this.question.QuestionID;
                this.answerList = new List<Answers>();
                this.answerList = BrainFartController.GetAllAnswerChoices(id);
                questionDescripLabel.Text = this.question.QuestionDescrip;
                answerChoice1.Text = this.answerList[0].AnswerDescrip;
                answerChoice2.Text = this.answerList[1].AnswerDescrip;
                answerChoice3.Text = this.answerList[2].AnswerDescrip;
                answerChoice4.Text = this.answerList[3].AnswerDescrip;
                //Loads the question's category
                int categoryID = this.question.CategoryID;
                this.categoriesTableAdapter.Fill(this.categoriesDataSet.categories, categoryID);
                //Loads the question's difficulty and point value
                int difficultyID = this.question.DifficultyID;
                this.difficultiesTableAdapter.Fill(this.difficultiesDataSet.difficulties, difficultyID);
            }

        }

        private void getQuestion()
        {
            //Get a random question from the list of questions
            Random rnd = new Random();
            int r = rnd.Next(this.questionList.Count);
            this.question = questionList[r];
        }

        private void submitButton_Click(object sender, EventArgs e)
        {

            this.checkAnswer();
            correctLabel.Visible = true;
            submitButton.Enabled = false;
            nextButton.Visible = true;
            this.gameMode();
        }

        private void checkAnswer()
        {
            correctLabel.ForeColor = System.Drawing.Color.Green;
            if ((this.answerChoice1.Checked && answerList[0].Correct.Equals(1)) ||
                (this.answerChoice2.Checked && answerList[1].Correct.Equals(1)) ||
                (this.answerChoice3.Checked && answerList[2].Correct.Equals(1)) ||
                (this.answerChoice4.Checked && answerList[3].Correct.Equals(1)))
            {
                correctLabel.Text = "Correct!";
                this.correct = "Correct";
                this.scoreLabel.Text = Convert.ToString(Int32.Parse(this.scoreLabel.Text) + Int32.Parse(this.pointValueLabel.Text));
            }
            else
            {
                if (answerList[0].Correct.Equals(1))
                {
                    this.answer = answerList[0];
                }
                else if (answerList[1].Correct.Equals(1))
                {
                    this.answer = answerList[1];
                }
                else if (answerList[2].Correct.Equals(1))
                {
                    this.answer = answerList[2];
                }
                else
                {
                    this.answer = answerList[3];
                }
                correctLabel.ForeColor = System.Drawing.Color.Red;
                correctLabel.Text = "Incorrect!";
                this.correct = "Incorrect";
                lblCorrectAnswer.Text = "The Correct Answer is: " + answer.AnswerDescrip;
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            nextButton.Visible = false;
            submitButton.Enabled = true;
            correctLabel.Visible = false;
            this.questionList.Remove(this.question);
            this.loadQuestion();

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Are you sure you want to Quit?", "BrainFart", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgResult == DialogResult.No) return;
            else
            {
                Application.Exit();
            }
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Are you sure you want to return to main menu?", "BrainFart", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgResult == DialogResult.No) return;
            else
            {
                this.Close();
            }
        }

    }
}
