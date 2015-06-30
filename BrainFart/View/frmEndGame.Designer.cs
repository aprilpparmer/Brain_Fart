namespace BrainFart.View
{
    partial class frmEndGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEndGame));
            this.logo = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblPatientTabUser = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureEinstein = new System.Windows.Forms.PictureBox();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblTotalPoints = new System.Windows.Forms.Label();
            this.lblCongrads = new System.Windows.Forms.Label();
            this.txtMissed = new System.Windows.Forms.TextBox();
            this.lblMissed = new System.Windows.Forms.Label();
            this.txtCorrect = new System.Windows.Forms.TextBox();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEinstein)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("logo.InitialImage")));
            this.logo.Location = new System.Drawing.Point(71, 4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(294, 60);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 39;
            this.logo.TabStop = false;
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(9, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(50, 25);
            this.btnMenu.TabIndex = 38;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // lblPatientTabUser
            // 
            this.lblPatientTabUser.AutoSize = true;
            this.lblPatientTabUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientTabUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblPatientTabUser.Location = new System.Drawing.Point(286, 67);
            this.lblPatientTabUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPatientTabUser.Name = "lblPatientTabUser";
            this.lblPatientTabUser.Size = new System.Drawing.Size(127, 16);
            this.lblPatientTabUser.TabIndex = 40;
            this.lblPatientTabUser.Text = "Logged in as: Guest";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureEinstein);
            this.groupBox1.Controls.Add(this.lblPoints);
            this.groupBox1.Controls.Add(this.lblTotalPoints);
            this.groupBox1.Controls.Add(this.lblCongrads);
            this.groupBox1.Controls.Add(this.txtMissed);
            this.groupBox1.Controls.Add(this.lblMissed);
            this.groupBox1.Controls.Add(this.txtCorrect);
            this.groupBox1.Controls.Add(this.lblCorrect);
            this.groupBox1.Location = new System.Drawing.Point(12, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 161);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            // 
            // pictureEinstein
            // 
            this.pictureEinstein.Image = ((System.Drawing.Image)(resources.GetObject("pictureEinstein.Image")));
            this.pictureEinstein.Location = new System.Drawing.Point(299, 41);
            this.pictureEinstein.Name = "pictureEinstein";
            this.pictureEinstein.Size = new System.Drawing.Size(100, 85);
            this.pictureEinstein.TabIndex = 22;
            this.pictureEinstein.TabStop = false;
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(240, 74);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(53, 20);
            this.lblPoints.TabIndex = 21;
            this.lblPoints.Text = "Points";
            // 
            // lblTotalPoints
            // 
            this.lblTotalPoints.AutoSize = true;
            this.lblTotalPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalPoints.Location = new System.Drawing.Point(161, 55);
            this.lblTotalPoints.Name = "lblTotalPoints";
            this.lblTotalPoints.Size = new System.Drawing.Size(83, 44);
            this.lblTotalPoints.TabIndex = 20;
            this.lblTotalPoints.Text = "100";
            // 
            // lblCongrads
            // 
            this.lblCongrads.AutoSize = true;
            this.lblCongrads.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCongrads.Location = new System.Drawing.Point(6, 16);
            this.lblCongrads.Name = "lblCongrads";
            this.lblCongrads.Size = new System.Drawing.Size(209, 20);
            this.lblCongrads.TabIndex = 19;
            this.lblCongrads.Text = "Congratulations You Scored";
            // 
            // txtMissed
            // 
            this.txtMissed.Location = new System.Drawing.Point(105, 136);
            this.txtMissed.Name = "txtMissed";
            this.txtMissed.Size = new System.Drawing.Size(26, 20);
            this.txtMissed.TabIndex = 17;
            // 
            // lblMissed
            // 
            this.lblMissed.AutoSize = true;
            this.lblMissed.Location = new System.Drawing.Point(6, 139);
            this.lblMissed.Name = "lblMissed";
            this.lblMissed.Size = new System.Drawing.Size(92, 13);
            this.lblMissed.TabIndex = 18;
            this.lblMissed.Text = "Questions missed:";
            // 
            // txtCorrect
            // 
            this.txtCorrect.Location = new System.Drawing.Point(105, 106);
            this.txtCorrect.Name = "txtCorrect";
            this.txtCorrect.Size = new System.Drawing.Size(26, 20);
            this.txtCorrect.TabIndex = 15;
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Location = new System.Drawing.Point(6, 113);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(93, 13);
            this.lblCorrect.TabIndex = 16;
            this.lblCorrect.Text = "Questions correct:";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(358, 276);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 44;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(256, 276);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(85, 23);
            this.btnNewGame.TabIndex = 43;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            // 
            // frmEndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(454, 331);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblPatientTabUser);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.btnMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEndGame";
            this.Text = "Game Over Dude";
            this.Load += new System.EventHandler(this.frmEndGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEinstein)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblPatientTabUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureEinstein;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblTotalPoints;
        private System.Windows.Forms.Label lblCongrads;
        private System.Windows.Forms.TextBox txtMissed;
        private System.Windows.Forms.Label lblMissed;
        private System.Windows.Forms.TextBox txtCorrect;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnNewGame;
    }
}