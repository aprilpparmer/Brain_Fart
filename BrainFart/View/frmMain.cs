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

        public mainForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            newGame = new frmNewGame();
            newGame.ShowDialog();
            this.Hide();
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
                    MessageBox.Show(AccessMessage, "BrainFart", MessageBoxButtons.OK, MessageBoxIcon.None);
                    newGame = new frmNewGame();
                    this.newGame.ShowDialog();
                    ToggleLoginObjectsSelection(false);
                    ToggleLogOutObjectsSelection(true);
                    
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

    }
}
