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
                //MessageBox.Show(ex.GetType());
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
                this.getQuestion();
                questionDescripLabel.Text = this.question.QuestionDescrip;
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
            correctLabel.Text = "Correct!";
            correctLabel.Visible = true;
            submitButton.Enabled = false;
            nextButton.Visible = true;
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
