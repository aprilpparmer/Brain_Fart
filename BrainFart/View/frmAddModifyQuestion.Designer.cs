namespace BrainFart.View
{
    partial class frmAddModifyQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddModifyQuestion));
            this.logo = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.cbDifficulty = new System.Windows.Forms.ComboBox();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtAnswerD = new System.Windows.Forms.TextBox();
            this.txtAnswerC = new System.Windows.Forms.TextBox();
            this.txtAnswerB = new System.Windows.Forms.TextBox();
            this.txtAnswerA = new System.Windows.Forms.TextBox();
            this.lblD = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblAnswers = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblPatientTabUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(9, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(50, 25);
            this.btnMenu.TabIndex = 36;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(372, 205);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(52, 20);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(372, 181);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(52, 20);
            this.btnSubmit.TabIndex = 34;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.lblCorrect);
            this.groupBox1.Controls.Add(this.cbDifficulty);
            this.groupBox1.Controls.Add(this.lblDifficulty);
            this.groupBox1.Controls.Add(this.cbCategory);
            this.groupBox1.Controls.Add(this.lblCategory);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.txtAnswerD);
            this.groupBox1.Controls.Add(this.txtAnswerC);
            this.groupBox1.Controls.Add(this.txtAnswerB);
            this.groupBox1.Controls.Add(this.txtAnswerA);
            this.groupBox1.Controls.Add(this.lblD);
            this.groupBox1.Controls.Add(this.lblC);
            this.groupBox1.Controls.Add(this.lblB);
            this.groupBox1.Controls.Add(this.lblA);
            this.groupBox1.Controls.Add(this.lblAnswers);
            this.groupBox1.Controls.Add(this.txtQuestion);
            this.groupBox1.Controls.Add(this.lblQuestion);
            this.groupBox1.Location = new System.Drawing.Point(12, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 230);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Location = new System.Drawing.Point(288, 90);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(136, 13);
            this.lblCorrect.TabIndex = 20;
            this.lblCorrect.Text = "Check One Correct Answer";
            // 
            // cbDifficulty
            // 
            this.cbDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDifficulty.FormattingEnabled = true;
            this.cbDifficulty.Location = new System.Drawing.Point(239, 202);
            this.cbDifficulty.Name = "cbDifficulty";
            this.cbDifficulty.Size = new System.Drawing.Size(121, 21);
            this.cbDifficulty.TabIndex = 19;
            this.cbDifficulty.Tag = "Difficulty";
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Location = new System.Drawing.Point(186, 205);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(50, 13);
            this.lblDifficulty.TabIndex = 18;
            this.lblDifficulty.Text = "Difficulty:";
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(59, 202);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(121, 21);
            this.cbCategory.TabIndex = 17;
            this.cbCategory.Tag = "Category ";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(6, 205);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 16;
            this.lblCategory.Text = "Category:";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(346, 176);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(14, 13);
            this.radioButton4.TabIndex = 15;
            this.radioButton4.TabStop = true;
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(346, 153);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(14, 13);
            this.radioButton3.TabIndex = 14;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(346, 130);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Tag = "Correct Answer";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(346, 106);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "Correct Answer";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtAnswerD
            // 
            this.txtAnswerD.Location = new System.Drawing.Point(82, 173);
            this.txtAnswerD.Name = "txtAnswerD";
            this.txtAnswerD.Size = new System.Drawing.Size(258, 20);
            this.txtAnswerD.TabIndex = 11;
            this.txtAnswerD.Tag = "Answer D";
            // 
            // txtAnswerC
            // 
            this.txtAnswerC.Location = new System.Drawing.Point(82, 150);
            this.txtAnswerC.Name = "txtAnswerC";
            this.txtAnswerC.Size = new System.Drawing.Size(258, 20);
            this.txtAnswerC.TabIndex = 10;
            this.txtAnswerC.Tag = "Answer C";
            // 
            // txtAnswerB
            // 
            this.txtAnswerB.Location = new System.Drawing.Point(82, 127);
            this.txtAnswerB.Name = "txtAnswerB";
            this.txtAnswerB.Size = new System.Drawing.Size(258, 20);
            this.txtAnswerB.TabIndex = 9;
            this.txtAnswerB.Tag = "Answer B";
            // 
            // txtAnswerA
            // 
            this.txtAnswerA.Location = new System.Drawing.Point(82, 105);
            this.txtAnswerA.Name = "txtAnswerA";
            this.txtAnswerA.Size = new System.Drawing.Size(258, 20);
            this.txtAnswerA.TabIndex = 8;
            this.txtAnswerA.Tag = "Answer A";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(56, 176);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(21, 13);
            this.lblD.TabIndex = 7;
            this.lblD.Text = "D.)";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(56, 153);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(20, 13);
            this.lblC.TabIndex = 6;
            this.lblC.Text = "C.)";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(56, 130);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(20, 13);
            this.lblB.TabIndex = 5;
            this.lblB.Text = "B.)";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(56, 108);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(20, 13);
            this.lblA.TabIndex = 4;
            this.lblA.Text = "A.)";
            // 
            // lblAnswers
            // 
            this.lblAnswers.AutoSize = true;
            this.lblAnswers.Location = new System.Drawing.Point(0, 89);
            this.lblAnswers.Name = "lblAnswers";
            this.lblAnswers.Size = new System.Drawing.Size(92, 13);
            this.lblAnswers.TabIndex = 3;
            this.lblAnswers.Text = "Possible Answers:";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(59, 13);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(351, 73);
            this.txtQuestion.TabIndex = 2;
            this.txtQuestion.Tag = "Question";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(6, 16);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(52, 13);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "Question:";
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
            this.lblPatientTabUser.TabIndex = 39;
            this.lblPatientTabUser.Text = "Logged in as: Guest";
            // 
            // frmAddModifyQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(454, 331);
            this.Controls.Add(this.lblPatientTabUser);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.btnMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddModifyQuestion";
            this.Text = "Add/Modify/Question";
            this.Load += new System.EventHandler(this.frmAddModifyQuestion_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.ComboBox cbDifficulty;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txtAnswerD;
        private System.Windows.Forms.TextBox txtAnswerC;
        private System.Windows.Forms.TextBox txtAnswerB;
        private System.Windows.Forms.TextBox txtAnswerA;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblAnswers;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblPatientTabUser;
    }
}