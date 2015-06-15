using System;
using BrainFart.Controller;
using BrainFart.Model;
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
    public partial class frmAddModifyQuestion : Form
    {
        public frmAddModifyQuestion()
        {
            InitializeComponent();
        }

        private void addQuestionCnclbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
