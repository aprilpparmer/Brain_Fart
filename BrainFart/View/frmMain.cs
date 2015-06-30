﻿using System;
using BrainFart.View;
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

        private frmRegister register;
        private frmNewGame newGame;

        public mainForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            newGame = new frmNewGame();
            this.newGame.ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            register = new frmRegister();
            this.register.ShowDialog();

            
        }
    }
}
