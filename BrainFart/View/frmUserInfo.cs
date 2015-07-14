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
            this.loadStats();
            
        }

        private void loadStats()
        {
            int gamesPlayed = 0;
            gamesPlayed = BrainFartController.userGamesPlayed(userAccess.CurrentLoggedUser.UserID);
            this.txtGamesPlayed.Text = gamesPlayed.ToString();

            int avgScore = 0;
            avgScore = BrainFartController.userGamesAvg(userAccess.CurrentLoggedUser.UserID);
            this.txtAvgScore.Text = avgScore.ToString();

            int HighScore = 0;
            HighScore = BrainFartController.userHighScore(userAccess.CurrentLoggedUser.UserID);
            this.txtHighScore.Text = HighScore.ToString();

           // int missed = 0;
           // missed = BrainFartController.userQuestionsMissed(userAccess.CurrentLoggedUser.UserID);
           // this.txtTotalMissed.Text = missed.ToString();

           // int correct = 0;
           // correct = BrainFartController.userQuestionsCorrect(userAccess.CurrentLoggedUser.UserID);
           // this.txtTotalCorrect.Text = correct.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
