using BrainFart.Controller;
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
    public partial class frmUserInfo : Form
    {
        private UserAccessController userAccess = UserAccessController.Instance;

        public frmUserInfo()
        {
            InitializeComponent();
            UserAccessController uac = UserAccessController.Instance;
            if (uac.CurrentLoggedUser != null)
            {
                this.txtUser.Text = uac.CurrentLoggedUser.UserName;
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
