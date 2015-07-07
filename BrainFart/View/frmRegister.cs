using BrainFart.DAL;
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

namespace BrainFart.View
{
    public partial class frmRegister : Form
    {

        private Users user;

        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getUserData(Users user)
        {
            
            user.UserName = txtUserName.Text;
            user.UserPassword = txtPassword.Text;
            user.PasswordConfirm = txtConfirm.Text;
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (IsValidData()) 
            {
                user = new Users();
                this.getUserData(user);
                this.confirmPassword();
                
            }

        }

        private void confirmPassword()
        {

            if (user.UserPassword.ToString().Equals(user.PasswordConfirm.ToString()))
            {
                DialogResult result2 = MessageBox.Show("Confirm Password?", "Important Query", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                UsersDAL.AddUser(user);
                Close();
            }
            else
            {
                MessageBox.Show("Password does not match", "BrainFart ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
      
            }
        }

        private bool IsValidData()
        {
            if (Validator.IsPresent(txtUserName) &&
                Validator.IsPresent(txtPassword) &&
                Validator.IsPresent(txtConfirm))

            {
                return true;
            }
            return false;
        }



    }
}
