using BrainFart.Controller;
using BrainFart.Model;
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
        private Questions question;
        private List<Questions> questionList;
        private List<Answers> answerList;
        
        
        public frmQuestions()
        {

            try
            {
                InitializeComponent();
                this.questionList = BrainFartController.GetAllQuestions();
                this.loadQuestion();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        public void loadQuestion()
        {

            if (this.questionList.Count == 0)
            {
                MessageBox.Show("You have answered all of the questions! Game Over!");
                this.Close();
            }
            else
            {
                this.answerChoice1.Checked = false;
                this.answerChoice2.Checked = false;
                this.answerChoice3.Checked = false;
                this.answerChoice4.Checked = false;
                this.getQuestion();
                this.answerList = BrainFartController.GetAllAnswerChoices(this.question.QuestionID);
                questionDescripLabel.Text = this.question.QuestionDescrip;
                answerChoice1.Text = this.answerList[0].AnswerDescrip;
                answerChoice2.Text = this.answerList[1].AnswerDescrip;
                answerChoice3.Text = this.answerList[2].AnswerDescrip;
                answerChoice4.Text = this.answerList[3].AnswerDescrip;
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
        }

        private void checkAnswer()
        {
            if (this.answerChoice1.Checked && answerList[0].Correct.Equals(1))
            {
                correctLabel.Text = "Correct!";
            }
            else if (this.answerChoice2.Checked && answerList[1].Correct.Equals(1))
            {
                correctLabel.Text = "Correct!";
            }
            else if (this.answerChoice3.Checked && answerList[2].Correct.Equals(1))
            {
                correctLabel.Text = "Correct!";
            }
            else if (this.answerChoice4.Checked && answerList[3].Correct.Equals(1))
            {
                correctLabel.Text = "Correct!";
            }
            else
            {
                correctLabel.Text = "Incorrect!";
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
    }
}
