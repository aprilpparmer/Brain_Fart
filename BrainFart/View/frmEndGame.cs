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
        public frmEndGame()
        {
    
            InitializeComponent();
        }

        private void frmEndGame_Load(object sender, EventArgs e)
        {
            lblTotalPoints.Text = this.totalPoint;
        }
    }
}
