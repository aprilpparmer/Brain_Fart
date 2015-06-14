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
        public frmQuestions()
        {
            InitializeComponent();
            this.loadQuestion();
        }

        public void loadQuestion()
        {
            this.getQuestion();
            questionDescripLabel.Text = this.question.QuestionDescrip;
        }

        private void getQuestion()
        {
            List<Questions> questionList = BrainFartController.GetAllQuestions();
            
            //Get a random question from the list of questions
            Random rnd = new Random();
            int r = rnd.Next(questionList.Count);
            this.question = questionList[r];
        }
    }
}
