namespace BrainFart.View
{
    partial class frmUserInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserInfo));
            this.logo = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnResetStats = new System.Windows.Forms.Button();
            this.txtTotalMissed = new System.Windows.Forms.TextBox();
            this.lblTotalMissed = new System.Windows.Forms.Label();
            this.txtTotalCorrect = new System.Windows.Forms.TextBox();
            this.lblTotalCorrect = new System.Windows.Forms.Label();
            this.txtAvgScore = new System.Windows.Forms.TextBox();
            this.lblAvgScore = new System.Windows.Forms.Label();
            this.txtHighScore = new System.Windows.Forms.TextBox();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.txtGamesPlayed = new System.Windows.Forms.TextBox();
            this.lblGamesPlayed = new System.Windows.Forms.Label();
            this.btnEditInfo = new System.Windows.Forms.Button();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.groupStats = new System.Windows.Forms.GroupBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.groupInfo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.groupStats.SuspendLayout();
            this.groupInfo.SuspendLayout();
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
            this.logo.TabIndex = 37;
            this.logo.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(333, 348);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Return";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnResetStats
            // 
            this.btnResetStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetStats.Location = new System.Drawing.Point(198, 114);
            this.btnResetStats.Name = "btnResetStats";
            this.btnResetStats.Size = new System.Drawing.Size(62, 21);
            this.btnResetStats.TabIndex = 36;
            this.btnResetStats.Text = "Reset";
            this.btnResetStats.UseVisualStyleBackColor = true;
            this.btnResetStats.Click += new System.EventHandler(this.btnResetStats_Click);
            // 
            // txtTotalMissed
            // 
            this.txtTotalMissed.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotalMissed.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtTotalMissed.Location = new System.Drawing.Point(257, 68);
            this.txtTotalMissed.Name = "txtTotalMissed";
            this.txtTotalMissed.ReadOnly = true;
            this.txtTotalMissed.Size = new System.Drawing.Size(26, 20);
            this.txtTotalMissed.TabIndex = 13;
            // 
            // lblTotalMissed
            // 
            this.lblTotalMissed.AutoSize = true;
            this.lblTotalMissed.Location = new System.Drawing.Point(158, 71);
            this.lblTotalMissed.Name = "lblTotalMissed";
            this.lblTotalMissed.Size = new System.Drawing.Size(92, 13);
            this.lblTotalMissed.TabIndex = 14;
            this.lblTotalMissed.Text = "Questions missed:";
            // 
            // txtTotalCorrect
            // 
            this.txtTotalCorrect.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotalCorrect.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtTotalCorrect.Location = new System.Drawing.Point(257, 32);
            this.txtTotalCorrect.Name = "txtTotalCorrect";
            this.txtTotalCorrect.ReadOnly = true;
            this.txtTotalCorrect.Size = new System.Drawing.Size(26, 20);
            this.txtTotalCorrect.TabIndex = 11;
            // 
            // lblTotalCorrect
            // 
            this.lblTotalCorrect.AutoSize = true;
            this.lblTotalCorrect.Location = new System.Drawing.Point(158, 39);
            this.lblTotalCorrect.Name = "lblTotalCorrect";
            this.lblTotalCorrect.Size = new System.Drawing.Size(93, 13);
            this.lblTotalCorrect.TabIndex = 12;
            this.lblTotalCorrect.Text = "Questions correct:";
            // 
            // txtAvgScore
            // 
            this.txtAvgScore.BackColor = System.Drawing.SystemColors.Window;
            this.txtAvgScore.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtAvgScore.Location = new System.Drawing.Point(90, 64);
            this.txtAvgScore.Name = "txtAvgScore";
            this.txtAvgScore.ReadOnly = true;
            this.txtAvgScore.Size = new System.Drawing.Size(40, 20);
            this.txtAvgScore.TabIndex = 10;
            // 
            // lblAvgScore
            // 
            this.lblAvgScore.AutoSize = true;
            this.lblAvgScore.Location = new System.Drawing.Point(6, 67);
            this.lblAvgScore.Name = "lblAvgScore";
            this.lblAvgScore.Size = new System.Drawing.Size(81, 13);
            this.lblAvgScore.TabIndex = 9;
            this.lblAvgScore.Text = "Average Score:";
            // 
            // txtHighScore
            // 
            this.txtHighScore.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtHighScore.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtHighScore.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtHighScore.Location = new System.Drawing.Point(90, 32);
            this.txtHighScore.Name = "txtHighScore";
            this.txtHighScore.ReadOnly = true;
            this.txtHighScore.Size = new System.Drawing.Size(40, 20);
            this.txtHighScore.TabIndex = 6;
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.Location = new System.Drawing.Point(6, 35);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(63, 13);
            this.lblHighScore.TabIndex = 5;
            this.lblHighScore.Text = "High Score:";
            // 
            // txtGamesPlayed
            // 
            this.txtGamesPlayed.BackColor = System.Drawing.SystemColors.Window;
            this.txtGamesPlayed.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtGamesPlayed.Location = new System.Drawing.Point(90, 100);
            this.txtGamesPlayed.Name = "txtGamesPlayed";
            this.txtGamesPlayed.ReadOnly = true;
            this.txtGamesPlayed.Size = new System.Drawing.Size(53, 20);
            this.txtGamesPlayed.TabIndex = 3;
            // 
            // lblGamesPlayed
            // 
            this.lblGamesPlayed.AutoSize = true;
            this.lblGamesPlayed.Location = new System.Drawing.Point(6, 103);
            this.lblGamesPlayed.Name = "lblGamesPlayed";
            this.lblGamesPlayed.Size = new System.Drawing.Size(78, 13);
            this.lblGamesPlayed.TabIndex = 4;
            this.lblGamesPlayed.Text = "Games Played:";
            // 
            // btnEditInfo
            // 
            this.btnEditInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditInfo.Location = new System.Drawing.Point(294, 23);
            this.btnEditInfo.Name = "btnEditInfo";
            this.btnEditInfo.Size = new System.Drawing.Size(59, 25);
            this.btnEditInfo.TabIndex = 35;
            this.btnEditInfo.Text = "Edit Info";
            this.btnEditInfo.UseVisualStyleBackColor = true;
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Location = new System.Drawing.Point(51, 226);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(113, 23);
            this.btnAddQuestion.TabIndex = 7;
            this.btnAddQuestion.Text = "Add Question";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // groupStats
            // 
            this.groupStats.Controls.Add(this.btnResetStats);
            this.groupStats.Controls.Add(this.txtTotalMissed);
            this.groupStats.Controls.Add(this.lblTotalMissed);
            this.groupStats.Controls.Add(this.txtTotalCorrect);
            this.groupStats.Controls.Add(this.lblTotalCorrect);
            this.groupStats.Controls.Add(this.txtAvgScore);
            this.groupStats.Controls.Add(this.lblAvgScore);
            this.groupStats.Controls.Add(this.txtHighScore);
            this.groupStats.Controls.Add(this.lblHighScore);
            this.groupStats.Controls.Add(this.txtGamesPlayed);
            this.groupStats.Controls.Add(this.lblGamesPlayed);
            this.groupStats.Location = new System.Drawing.Point(42, 54);
            this.groupStats.Name = "groupStats";
            this.groupStats.Size = new System.Drawing.Size(327, 150);
            this.groupStats.TabIndex = 6;
            this.groupStats.TabStop = false;
            this.groupStats.Text = "Stats";
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.SystemColors.Window;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtUser.Location = new System.Drawing.Point(98, 26);
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(162, 20);
            this.txtUser.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(9, 29);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(63, 13);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "User Name:";
            // 
            // groupInfo
            // 
            this.groupInfo.Controls.Add(this.btnEditInfo);
            this.groupInfo.Controls.Add(this.btnAddQuestion);
            this.groupInfo.Controls.Add(this.groupStats);
            this.groupInfo.Controls.Add(this.label2);
            this.groupInfo.Controls.Add(this.txtUser);
            this.groupInfo.Controls.Add(this.lblUser);
            this.groupInfo.Location = new System.Drawing.Point(12, 87);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Size = new System.Drawing.Size(396, 255);
            this.groupInfo.TabIndex = 38;
            this.groupInfo.TabStop = false;
            this.groupInfo.Text = " Information and Stats";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // frmUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(454, 384);
            this.Controls.Add(this.groupInfo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User Information";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.groupStats.ResumeLayout(false);
            this.groupStats.PerformLayout();
            this.groupInfo.ResumeLayout(false);
            this.groupInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnResetStats;
        private System.Windows.Forms.TextBox txtTotalMissed;
        private System.Windows.Forms.Label lblTotalMissed;
        private System.Windows.Forms.TextBox txtTotalCorrect;
        private System.Windows.Forms.Label lblTotalCorrect;
        private System.Windows.Forms.TextBox txtAvgScore;
        private System.Windows.Forms.Label lblAvgScore;
        private System.Windows.Forms.TextBox txtHighScore;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.TextBox txtGamesPlayed;
        private System.Windows.Forms.Label lblGamesPlayed;
        private System.Windows.Forms.Button btnEditInfo;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.GroupBox groupStats;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.GroupBox groupInfo;
        private System.Windows.Forms.Label label2;
    }
}