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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label questionLabel;
            this.answerLabel = new System.Windows.Forms.Label();
            this.answerChoice1 = new System.Windows.Forms.RadioButton();
            this.answerChoice2 = new System.Windows.Forms.RadioButton();
            this.answerChoice3 = new System.Windows.Forms.RadioButton();
            this.answerChoice4 = new System.Windows.Forms.RadioButton();
            this.submitButton = new System.Windows.Forms.Button();
            this.questionDescripLabel = new System.Windows.Forms.Label();
            questionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Location = new System.Drawing.Point(45, 159);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(42, 13);
            this.answerLabel.TabIndex = 1;
            this.answerLabel.Text = "Answer";
            // 
            // answerChoice1
            // 
            this.answerChoice1.AutoSize = true;
            this.answerChoice1.Location = new System.Drawing.Point(122, 159);
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
            this.answerChoice2.Location = new System.Drawing.Point(122, 182);
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
            this.answerChoice3.Location = new System.Drawing.Point(122, 205);
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
            this.answerChoice4.Location = new System.Drawing.Point(122, 228);
            this.answerChoice4.Name = "answerChoice4";
            this.answerChoice4.Size = new System.Drawing.Size(68, 17);
            this.answerChoice4.TabIndex = 5;
            this.answerChoice4.TabStop = true;
            this.answerChoice4.Text = "answer 3";
            this.answerChoice4.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(122, 272);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // questionLabel
            // 
            questionLabel.AutoSize = true;
            questionLabel.Location = new System.Drawing.Point(45, 50);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new System.Drawing.Size(52, 13);
            questionLabel.TabIndex = 8;
            questionLabel.Text = "Question:";
            // 
            // questionDescripLabel
            // 
            this.questionDescripLabel.Location = new System.Drawing.Point(103, 50);
            this.questionDescripLabel.Name = "questionDescripLabel";
            this.questionDescripLabel.Size = new System.Drawing.Size(207, 106);
            this.questionDescripLabel.TabIndex = 9;
            this.questionDescripLabel.Text = "***************";
            // 
            // frmQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(364, 324);
            this.Controls.Add(questionLabel);
            this.Controls.Add(this.questionDescripLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.answerChoice4);
            this.Controls.Add(this.answerChoice3);
            this.Controls.Add(this.answerChoice2);
            this.Controls.Add(this.answerChoice1);
            this.Controls.Add(this.answerLabel);
            this.Name = "frmQuestions";
            this.Text = "       ";
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
    }
}