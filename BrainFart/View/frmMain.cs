using System;
using BrainFart.View;
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
    public partial class mainForm : Form
    {

        private frmRegister register;
        private frmNewGame newGame;
        private frmQuestions questions;
        private frmAddModifyQuestion addQuestions;

        public mainForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            questions = new frmQuestions();
            this.questions.ShowDialog();
            //Code for when options are in place
            //newGame = new frmNewGame();
            //this.newGame.ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.register = new frmRegister();
            this.register.ShowDialog();

            //Code for Adding Questions form
            //addQuestions = new frmAddModifyQuestion();
            //addQuestions.addQuestion = true;
            //this.addQuestions.ShowDialog();
        }
    }
}
