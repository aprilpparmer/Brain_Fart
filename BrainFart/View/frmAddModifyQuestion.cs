using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrainFart.Model;
using BrainFart.Controller;

namespace BrainFart.View
{
    public partial class frmAddModifyQuestion : Form
    {
        public Questions question;
        public Answers answer;
        public Questions newQuestion;
        public bool updated;


        public frmAddModifyQuestion()
        {
            InitializeComponent();
        }

        public bool addQuestion;

        private void frmAddModifyQuestion_Load_1(object sender, EventArgs e)
        {
            this.LoadQuestionComboBoxes();
            if (addQuestion)
            {
                this.Text = "Add Question";
                cbCategory.Enabled = true;
                cbCategory.SelectedIndex = -1;
                cbDifficulty.Enabled = true;
                cbDifficulty.SelectedIndex = -1;
            }
            else
            {
                this.Text = "Modify Question";
                //Code to be completed Second Iteration
            }
        }

        private void LoadQuestionComboBoxes()
        {
            try
            {
                List<Categories> categorylist;
                categorylist = BrainFartController.getAllCategories();
                cbCategory.DataSource = categorylist;
                cbCategory.DisplayMember = "categoryDescrip";
                cbCategory.ValueMember = "categoryID";

                List<Difficulties> difficultylist;
                difficultylist = BrainFartController.getAllDifficulties();
                cbDifficulty.DataSource = difficultylist;
                cbDifficulty.DisplayMember = "difficultyDescrip";
                cbDifficulty.ValueMember = "difficultyID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //NEED TO ADD QUESTION.  Then add Answer due to FK
            try
            {

                if (Validator.IsPresent(txtQuestion) && Validator.IsPresent(txtAnswerA)
                    && Validator.IsPresent(txtAnswerB) && Validator.IsPresent(txtAnswerC)
                    && Validator.IsPresent(txtAnswerD) && Validator.IsPresent(cbCategory)
                    && Validator.IsPresent(cbDifficulty) &&
                    (Validator.IsRadioButtonChecked(radioButton1, radioButton2, radioButton3, radioButton4)))
                {
                    if (addQuestion)
                    {
                        question = new Questions();
                        answer = new Answers();
                        this.putQuestionData(question);
                        this.putAnswerData1(answer);
                        this.putAnswerData2(answer);

                        try
                        {
                            this.question.QuestionID = BrainFartController.AddQuestion(question);
                            this.answer.AnswerID = BrainFartController.AddAnswer(answer);

                            MessageBox.Show("You have successfully Added a Question");

                            this.BeginInvoke(new MethodInvoker(Close));

                        }
                        catch (InvalidOperationException ioe)
                        {
                            throw ioe;
                        }

                    }
                    else
                    {
                        newQuestion = new Questions();
                        this.putQuestionData(newQuestion);
                        try
                        {
                            if (BrainFartController.UpdateQuestion(question, newQuestion))
                            {
                                MessageBox.Show("Question Successfully updated to the system!", "BrainFart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                updated = true;
                                this.BeginInvoke(new MethodInvoker(Close));
                            }
                        }
                        catch (InvalidOperationException ioe)
                        {
                            throw ioe;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /// <summary>
        /// Insert question information
        /// </summary>
        /// <param name="question"></param>
        private void putQuestionData(Questions question)
        {
            question.QuestionID = this.question.QuestionID;
            question.QuestionDescrip = txtQuestion.Text;
            question.CategoryID = (int)cbCategory.SelectedValue;
            question.DifficultyID = (int)cbDifficulty.SelectedValue;
        }
        /// <summary>
        /// Insert answer information
        /// </summary>
        /// <param name="answer"></param>
        private void putAnswerData1(Answers answer)
        {
            int correctAnswer;
            answer.QuestionID = this.question.QuestionID;
            answer.AnswerDescrip = txtAnswerA.Text;
            if (radioButton1.Checked)
            {
                correctAnswer = 1;
            }
            else 
            {
                correctAnswer = 0;
            }             
            answer.Correct = correctAnswer;            
        }
        private void putAnswerData2(Answers answer)
        {
            int correctAnswer;
            answer.QuestionID = this.question.QuestionID;
            answer.AnswerDescrip = txtAnswerB.Text;
            if (radioButton2.Checked)
            {
                correctAnswer = 1;
            }
            else
            {
                correctAnswer = 0;
            }
            answer.Correct = correctAnswer;
        }
    }
}

             