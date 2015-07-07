using System;
using BrainFart.View;
using BrainFart.Model;
using BrainFart.Controller;
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
        private UserAccessController userAccess = UserAccessController.Instance;
        private frmRegister register;
        private frmNewGame newGame;
        private frmAddModifyQuestion addQuestion;
        private frmUserInfo stats;

        public mainForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            newGame = new frmNewGame();
            newGame.ShowDialog();
      
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            register = new frmRegister();
            this.register.ShowDialog();

            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtUserName) == false) return;
            if (Validator.IsPresent(txtPassword) == false) return;

            String AccessMessage;
            try
            {
                if (userAccess.LoginUser(txtUserName.Text, txtPassword.Text))
                {
                    AccessMessage = String.Concat("WELCOME to BrainFart! \n You are logged in as ", userAccess.CurrentLoggedUser.UserName);
                    MessageBox.Show(AccessMessage, "BrainFart", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ToggleLoginObjectsSelection(false);
                    ToggleLogOutObjectsSelection(true);
                    btnAddQuestion.Enabled = true;
                    btnStats.Enabled = true;
                    btnStats.Visible = true;
                    
                }
                else
                {
                    AccessMessage = String.Concat("Unable to login as User ", txtUserName.Text, ", Please check your user name and password and try again!");
                    MessageBox.Show(AccessMessage, "BrainFart", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    ToggleLoginObjectsSelection(true);
                    ToggleLogOutObjectsSelection(false);
                }
            }
            catch (Exception ex)
            {
                AccessMessage = String.Concat("Unable to login as User ", txtUserName.Text, ", probably due to a system error. Please contact support!");
                AccessMessage = string.Concat(AccessMessage, "\n", ex.Message);
                MessageBox.Show(AccessMessage, "BrainFart", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            userAccess.LogOutUser();
            ToggleLoginObjectsSelection(true);
            ToggleLogOutObjectsSelection(false);
            btnAddQuestion.Enabled = false;
            btnStats.Enabled = false;
            btnStats.Visible = false;
           
        }
        private void ToggleLoginObjectsSelection(bool value)
        {
            if (txtUserName.Enabled != value) txtUserName.Enabled = value;
            if (txtPassword.Enabled != value) txtPassword.Enabled = value;
            if (btnLogin.Enabled != value) btnLogin.Enabled = value;
        }

        private void ToggleLogOutObjectsSelection(bool value)
        {
            if (btnLogout.Enabled != value) btnLogout.Enabled = value;
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            addQuestion = new frmAddModifyQuestion();
            addQuestion.addQuestion = true;
            this.addQuestion.ShowDialog();
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

        private void btnStats_Click(object sender, EventArgs e)
        {
            stats = new frmUserInfo();
            this.stats.ShowDialog();
        }

    }
}
