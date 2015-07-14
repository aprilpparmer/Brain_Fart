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
using BrainFart.Model;

namespace BrainFart.View
{
    public partial class frmEndGame : Form
    {
        private UserAccessController userAccess = UserAccessController.Instance;
        public String totalPoint;
        private frmNewGame newGame;
        private mainForm main;
        public int incorrect;
        public int correct;
        public Games game;

        public frmEndGame()
        {
    
            InitializeComponent();
        }

        private void frmEndGame_Load(object sender, EventArgs e)
        {
            lblTotalPoints.Text = this.totalPoint;
            lblIncorrect.Text = Convert.ToString(this.incorrect);
            lblCorrect.Text = Convert.ToString(this.correct);
            UserAccessController uac = UserAccessController.Instance;
            if (uac.CurrentLoggedUser != null)
            {
                this.loggedInLabel.Text = uac.CurrentLoggedUser.UserName;
                //game = new Games();
                //this.saveStats(game);
               // try
                //{
                   // this.game.GamesID = BrainFartController.AddUserStats(game);
               // }
                //catch (InvalidOperationException ioe)
                //{
                   // throw ioe;
               // }
            }

        }

        private void saveStats(Games game)
        {
            int talley = Convert.ToInt32(this.lblTotalPoints.Text);
            game.GamesID = this.game.GamesID;
            game.UserID = userAccess.CurrentLoggedUser.UserID;
            game.Score = talley;
            game.QuestionsMissed = this.incorrect;
            game.QuestionsCorrect = this.correct;
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
