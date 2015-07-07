using BrainFart.Controller;
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
    public partial class frmEndGame : Form
    {
        public String totalPoint;
        private frmNewGame newGame;
        private mainForm main;

        public frmEndGame()
        {
    
            InitializeComponent();
        }

        private void frmEndGame_Load(object sender, EventArgs e)
        {
            lblTotalPoints.Text = this.totalPoint;
            UserAccessController uac = UserAccessController.Instance;
            if (uac.CurrentLoggedUser != null)
            {
                this.loggedInLabel.Text = uac.CurrentLoggedUser.UserName;
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            newGame = new frmNewGame();
            newGame.ShowDialog();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Are you sure you want to Quit?", "BrainFart", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgResult == DialogResult.No) return;
            else
            {
                Application.Exit();
            }
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Are you sure you want to return to main menu?", "BrainFart", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgResult == DialogResult.No) return;
            else
            {
                this.Close();
            }
        }
    }
}
