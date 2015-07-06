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
        public Answers answer1;
        public Answers answer2;
        public Answers answer3;
        public Answers answer4;
        public Questions newQuestion;
        public Answers newAnswer;
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
                //Code to be completed Another Iteration
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
                        answer1 = new Answers();
                        answer2 = new Answers();
                        answer3 = new Answers();
                        answer4 = new Answers();
                        this.putQuestionData(question);
                        this.putAnswerData1(answer1);
                        this.putAnswerData2(answer2);
                        this.putAnswerData3(answer3);
                        this.putAnswerData4(answer4);
                        try
                        {
                            this.question.QuestionID = BrainFartController.AddQuestion(question);
                            answer1.QuestionID = this.question.QuestionID;
                            this.answer1.AnswerID = BrainFartController.AddAnswer(answer1);
                            answer2.QuestionID = this.question.QuestionID;
                            this.answer2.AnswerID = BrainFartController.AddAnswer(answer2);
                            answer3.QuestionID = this.question.QuestionID;
                            this.answer3.AnswerID = BrainFartController.AddAnswer(answer3);
                            answer4.QuestionID = this.question.QuestionID;
                            this.answer4.AnswerID = BrainFartController.AddAnswer(answer4);
                            MessageBox.Show("Question submission successful");
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
        /// Insert Answer information
        /// </summary>
        /// <param name="answer"></param>
        private void putAnswerData1(Answers answer1)
        {
            int correctAnswer;
            answer1.AnswerID = this.answer1.AnswerID;
            answer1.AnswerDescrip = txtAnswerA.Text;
            if (radioButton1.Checked)
            {
                correctAnswer = 1;
            }
            else
            {
                correctAnswer = 0;
            }
            answer1.Correct = correctAnswer;
        }

        private void putAnswerData2(Answers answer2)
        {
            int correctAnswer;
            answer2.AnswerID = this.answer2.AnswerID;
            answer2.AnswerDescrip = txtAnswerB.Text;
            if (radioButton2.Checked)
            {
                correctAnswer = 1;
            }
            else
            {
                correctAnswer = 0;
            }
            answer2.Correct = correctAnswer;
        }

        private void putAnswerData3(Answers answer3)
        {
            int correctAnswer;
            answer3.AnswerID = this.answer3.AnswerID;
            answer3.AnswerDescrip = txtAnswerC.Text;
            if (radioButton3.Checked)
            {
                correctAnswer = 1;
            }
            else
            {
                correctAnswer = 0;
            }
            answer3.Correct = correctAnswer;
        }
        private void putAnswerData4(Answers answer4)
        {
            int correctAnswer;
            answer4.AnswerID = this.answer4.AnswerID;
            answer4.AnswerDescrip = txtAnswerD.Text;
            if (radioButton4.Checked)
            {
                correctAnswer = 1;
            }
            else
            {
                correctAnswer = 0;
            }
            answer4.Correct = correctAnswer;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }   
    }
}

             