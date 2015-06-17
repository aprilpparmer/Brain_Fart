﻿using BrainFart.Controller;
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
        private Answers answer;
        
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
                lblCorrectAnswer.Text = " ";
                this.answerChoice1.Checked = false;
                this.answerChoice2.Checked = false;
                this.answerChoice3.Checked = false;
                this.answerChoice4.Checked = false;

                //Loads a new question
                this.getQuestion();
                //Loads the answer choices for the question
                this.answerList = BrainFartController.GetAllAnswerChoices(this.question.QuestionID);
                questionDescripLabel.Text = this.question.QuestionDescrip;
                answerChoice1.Text = this.answerList[0].AnswerDescrip;
                answerChoice2.Text = this.answerList[1].AnswerDescrip;
                answerChoice3.Text = this.answerList[2].AnswerDescrip;
                answerChoice4.Text = this.answerList[3].AnswerDescrip;
                //Loads the question's category
                int categoryID = this.question.CatergoryID;
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

                correctLabel.Text = "Incorrect!";
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
                this.Close();
            }
        }

    }
}
