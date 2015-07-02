﻿using System;
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
        public String userLabel;
        private frmNewGame newGame;

        public frmEndGame()
        {
    
            InitializeComponent();
        }

        private void frmEndGame_Load(object sender, EventArgs e)
        {
            lblTotalPoints.Text = this.totalPoint;
            this.lblUserTabUser.Text = userLabel;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            
            this.Close();
            newGame = new frmNewGame();
            newGame.userLabel = this.userLabel;
            newGame.Show();
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
    }
}
