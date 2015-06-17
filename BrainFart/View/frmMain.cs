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

        private frmQuestions questions;
        private frmRegister register;

        public mainForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            questions = new frmQuestions();
            this.questions.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            register = new frmRegister();
            this.register.Show();
        }
    }
}
