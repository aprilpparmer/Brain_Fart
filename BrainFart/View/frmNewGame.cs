using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrainFart.View
{
    public partial class frmNewGame : Form
    {
        private frmQuestions questions;


        public frmNewGame()
        {
            InitializeComponent();
        }

        private void btnGameStart_Click(object sender, EventArgs e)
        {
            questions = new frmQuestions();
            this.questions.Show();
            this.Close();
        }
    }
}
