﻿using BrainFart.Controller;
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
        private frmAddModifyQuestion addQuestion;

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

            int missed = 0;
            missed = BrainFartController.userQuestionsMissed(userAccess.CurrentLoggedUser.UserID);
            this.txtTotalMissed.Text = missed.ToString();

            int correct = 0;
            correct = BrainFartController.userQuestionsCorrect(userAccess.CurrentLoggedUser.UserID);
            this.txtTotalCorrect.Text = correct.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            addQuestion = new frmAddModifyQuestion();
            addQuestion.addQuestion = true;
            this.addQuestion.ShowDialog();
        }

        private void btnResetStats_Click(object sender, EventArgs e)
        {
             DialogResult dlgResult = MessageBox.Show("Are you sure you want to reset your stats?", "BrainFart", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if (dlgResult == DialogResult.No) return;
             else
             {
                 if (BrainFartController.DeleteStats(userAccess.CurrentLoggedUser.UserID))
                 {
                     MessageBox.Show("Successfully Reset Stats: ");
                     this.loadStats();
                 }
                 else
                 {
                     MessageBox.Show("You have no stats to reset at this time");
                 }
             }
        }
    }
}
