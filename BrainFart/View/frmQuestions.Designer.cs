namespace BrainFart
{
    partial class frmQuestions
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
            System.Windows.Forms.Label questionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuestions));
            this.answerLabel = new System.Windows.Forms.Label();
            this.answerChoice1 = new System.Windows.Forms.RadioButton();
            this.answerChoice2 = new System.Windows.Forms.RadioButton();
            this.answerChoice3 = new System.Windows.Forms.RadioButton();
            this.answerChoice4 = new System.Windows.Forms.RadioButton();
            this.submitButton = new System.Windows.Forms.Button();
            this.questionDescripLabel = new System.Windows.Forms.Label();
            this.correctLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.lblCorrectAnswer = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPatientTabUser = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            questionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            questionLabel.AutoSize = true;
            questionLabel.Location = new System.Drawing.Point(15, 25);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new System.Drawing.Size(52, 13);
            questionLabel.TabIndex = 8;
            questionLabel.Text = "Question:";
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Location = new System.Drawing.Point(25, 86);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(42, 13);
            this.answerLabel.TabIndex = 1;
            this.answerLabel.Text = "Answer";
            // 
            // answerChoice1
            // 
            this.answerChoice1.AutoSize = true;
            this.answerChoice1.Location = new System.Drawing.Point(76, 86);
            this.answerChoice1.Name = "answerChoice1";
            this.answerChoice1.Size = new System.Drawing.Size(68, 17);
            this.answerChoice1.TabIndex = 2;
            this.answerChoice1.TabStop = true;
            this.answerChoice1.Text = "answer 1";
            this.answerChoice1.UseVisualStyleBackColor = true;
            // 
            // answerChoice2
            // 
            this.answerChoice2.AutoSize = true;
            this.answerChoice2.Location = new System.Drawing.Point(76, 109);
            this.answerChoice2.Name = "answerChoice2";
            this.answerChoice2.Size = new System.Drawing.Size(68, 17);
            this.answerChoice2.TabIndex = 3;
            this.answerChoice2.TabStop = true;
            this.answerChoice2.Text = "answer 2";
            this.answerChoice2.UseVisualStyleBackColor = true;
            // 
            // answerChoice3
            // 
            this.answerChoice3.AutoSize = true;
            this.answerChoice3.Location = new System.Drawing.Point(76, 132);
            this.answerChoice3.Name = "answerChoice3";
            this.answerChoice3.Size = new System.Drawing.Size(68, 17);
            this.answerChoice3.TabIndex = 4;
            this.answerChoice3.TabStop = true;
            this.answerChoice3.Text = "answer 3";
            this.answerChoice3.UseVisualStyleBackColor = true;
            // 
            // answerChoice4
            // 
            this.answerChoice4.AutoSize = true;
            this.answerChoice4.Location = new System.Drawing.Point(76, 155);
            this.answerChoice4.Name = "answerChoice4";
            this.answerChoice4.Size = new System.Drawing.Size(68, 17);
            this.answerChoice4.TabIndex = 5;
            this.answerChoice4.TabStop = true;
            this.answerChoice4.Text = "answer 4";
            this.answerChoice4.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(233, 175);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // questionDescripLabel
            // 
            this.questionDescripLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionDescripLabel.Location = new System.Drawing.Point(73, 25);
            this.questionDescripLabel.Name = "questionDescripLabel";
            this.questionDescripLabel.Size = new System.Drawing.Size(326, 58);
            this.questionDescripLabel.TabIndex = 9;
            this.questionDescripLabel.Text = "***************";
            // 
            // correctLabel
            // 
            this.correctLabel.AutoSize = true;
            this.correctLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.correctLabel.Location = new System.Drawing.Point(72, 175);
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(145, 20);
            this.correctLabel.TabIndex = 10;
            this.correctLabel.Text = "Correct/Incorrect";
            this.correctLabel.Visible = false;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(314, 175);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 11;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Visible = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // lblCorrectAnswer
            // 
            this.lblCorrectAnswer.AutoSize = true;
            this.lblCorrectAnswer.Location = new System.Drawing.Point(119, 298);
            this.lblCorrectAnswer.Name = "lblCorrectAnswer";
            this.lblCorrectAnswer.Size = new System.Drawing.Size(0, 13);
            this.lblCorrectAnswer.TabIndex = 13;
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(9, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(50, 25);
            this.btnMenu.TabIndex = 32;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("logo.InitialImage")));
            this.logo.Location = new System.Drawing.Point(71, 4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(294, 60);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 33;
            this.logo.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblScore);
            this.groupBox1.Controls.Add(questionLabel);
            this.groupBox1.Controls.Add(this.questionDescripLabel);
            this.groupBox1.Controls.Add(this.answerLabel);
            this.groupBox1.Controls.Add(this.answerChoice1);
            this.groupBox1.Controls.Add(this.answerChoice2);
            this.groupBox1.Controls.Add(this.correctLabel);
            this.groupBox1.Controls.Add(this.nextButton);
            this.groupBox1.Controls.Add(this.answerChoice3);
            this.groupBox1.Controls.Add(this.submitButton);
            this.groupBox1.Controls.Add(this.answerChoice4);
            this.groupBox1.Location = new System.Drawing.Point(24, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 200);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category:";
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
            this.lblPatientTabUser.TabIndex = 22;
            this.lblPatientTabUser.Text = "Logged in as: Guest";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(367, 292);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 25);
            this.button3.TabIndex = 35;
            this.button3.Text = "Quit";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(308, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(75, 13);
            this.lblScore.TabIndex = 29;
            this.lblScore.Text = "Current Score:";
            // 
            // frmQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(454, 331);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lblPatientTabUser);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblCorrectAnswer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuestions";
            this.Text = "       ";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.RadioButton answerChoice1;
        private System.Windows.Forms.RadioButton answerChoice2;
        private System.Windows.Forms.RadioButton answerChoice3;
        private System.Windows.Forms.RadioButton answerChoice4;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label questionDescripLabel;
        private System.Windows.Forms.Label correctLabel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label lblCorrectAnswer;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPatientTabUser;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblScore;
    }
}