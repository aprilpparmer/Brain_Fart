﻿namespace BrainFart
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
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label dificultyLabel;
            System.Windows.Forms.Label point_valueLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuestions));
            this.answerLabel = new System.Windows.Forms.Label();
            this.answerChoice1 = new System.Windows.Forms.RadioButton();
            this.answerChoice2 = new System.Windows.Forms.RadioButton();
            this.answerChoice3 = new System.Windows.Forms.RadioButton();
            this.answerChoice4 = new System.Windows.Forms.RadioButton();
            this.submitButton = new System.Windows.Forms.Button();
            this.difficultiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.difficultiesDataSet = new BrainFart.DifficultiesDataSet();
            this.correctLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.lblCorrectAnswer = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.questionDescripLabel = new System.Windows.Forms.Label();
            this.pointValueLabel = new System.Windows.Forms.Label();
            this.difficultyDescripLabel = new System.Windows.Forms.Label();
            this.categoryDescripLabel = new System.Windows.Forms.Label();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesDataSet = new BrainFart.CategoriesDataSet();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblUserTabUser = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.categoriesTableAdapter = new BrainFart.CategoriesDataSetTableAdapters.categoriesTableAdapter();
            this.tableAdapterManager = new BrainFart.CategoriesDataSetTableAdapters.TableAdapterManager();
            this.difficultiesTableAdapter = new BrainFart.DifficultiesDataSetTableAdapters.difficultiesTableAdapter();
            this.tableAdapterManager1 = new BrainFart.DifficultiesDataSetTableAdapters.TableAdapterManager();
            this.btnMain = new System.Windows.Forms.Button();
            this.loggedInLabel = new System.Windows.Forms.Label();
            questionLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            dificultyLabel = new System.Windows.Forms.Label();
            point_valueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.difficultiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difficultiesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataSet)).BeginInit();
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
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            categoryLabel.Location = new System.Drawing.Point(6, 0);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(52, 13);
            categoryLabel.TabIndex = 29;
            categoryLabel.Text = "Category:";
            // 
            // dificultyLabel
            // 
            dificultyLabel.AutoSize = true;
            dificultyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dificultyLabel.Location = new System.Drawing.Point(159, 0);
            dificultyLabel.Name = "dificultyLabel";
            dificultyLabel.Size = new System.Drawing.Size(50, 13);
            dificultyLabel.TabIndex = 30;
            dificultyLabel.Text = "Difficulty:";
            // 
            // point_valueLabel
            // 
            point_valueLabel.AutoSize = true;
            point_valueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            point_valueLabel.Location = new System.Drawing.Point(6, 223);
            point_valueLabel.Name = "point_valueLabel";
            point_valueLabel.Size = new System.Drawing.Size(64, 13);
            point_valueLabel.TabIndex = 31;
            point_valueLabel.Text = "Point Value:";
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Location = new System.Drawing.Point(28, 69);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(42, 13);
            this.answerLabel.TabIndex = 1;
            this.answerLabel.Text = "Answer";
            // 
            // answerChoice1
            // 
            this.answerChoice1.Location = new System.Drawing.Point(79, 69);
            this.answerChoice1.Name = "answerChoice1";
            this.answerChoice1.Size = new System.Drawing.Size(326, 30);
            this.answerChoice1.TabIndex = 2;
            this.answerChoice1.TabStop = true;
            this.answerChoice1.Text = "answer 1";
            this.answerChoice1.UseVisualStyleBackColor = true;
            // 
            // answerChoice2
            // 
            this.answerChoice2.Location = new System.Drawing.Point(79, 105);
            this.answerChoice2.Name = "answerChoice2";
            this.answerChoice2.Size = new System.Drawing.Size(326, 30);
            this.answerChoice2.TabIndex = 3;
            this.answerChoice2.TabStop = true;
            this.answerChoice2.Text = "answer 2";
            this.answerChoice2.UseVisualStyleBackColor = true;
            // 
            // answerChoice3
            // 
            this.answerChoice3.Location = new System.Drawing.Point(79, 141);
            this.answerChoice3.Name = "answerChoice3";
            this.answerChoice3.Size = new System.Drawing.Size(326, 30);
            this.answerChoice3.TabIndex = 4;
            this.answerChoice3.TabStop = true;
            this.answerChoice3.Text = "answer 3";
            this.answerChoice3.UseVisualStyleBackColor = true;
            // 
            // answerChoice4
            // 
            this.answerChoice4.Location = new System.Drawing.Point(79, 177);
            this.answerChoice4.Name = "answerChoice4";
            this.answerChoice4.Size = new System.Drawing.Size(326, 30);
            this.answerChoice4.TabIndex = 5;
            this.answerChoice4.TabStop = true;
            this.answerChoice4.Text = "answer 4";
            this.answerChoice4.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(257, 218);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // difficultiesBindingSource
            // 
            this.difficultiesBindingSource.DataMember = "difficulties";
            this.difficultiesBindingSource.DataSource = this.difficultiesDataSet;
            // 
            // difficultiesDataSet
            // 
            this.difficultiesDataSet.DataSetName = "DifficultiesDataSet";
            this.difficultiesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // correctLabel
            // 
            this.correctLabel.AutoSize = true;
            this.correctLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.correctLabel.Location = new System.Drawing.Point(106, 220);
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(145, 20);
            this.correctLabel.TabIndex = 10;
            this.correctLabel.Text = "Correct/Incorrect";
            this.correctLabel.Visible = false;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(338, 218);
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
            this.lblCorrectAnswer.Location = new System.Drawing.Point(17, 338);
            this.lblCorrectAnswer.Name = "lblCorrectAnswer";
            this.lblCorrectAnswer.Size = new System.Drawing.Size(332, 48);
            this.lblCorrectAnswer.TabIndex = 13;
            this.lblCorrectAnswer.Text = "Correct Answer:";
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
            this.groupBox1.Controls.Add(this.scoreLabel);
            this.groupBox1.Controls.Add(this.questionDescripLabel);
            this.groupBox1.Controls.Add(point_valueLabel);
            this.groupBox1.Controls.Add(this.pointValueLabel);
            this.groupBox1.Controls.Add(dificultyLabel);
            this.groupBox1.Controls.Add(this.difficultyDescripLabel);
            this.groupBox1.Controls.Add(categoryLabel);
            this.groupBox1.Controls.Add(this.categoryDescripLabel);
            this.groupBox1.Controls.Add(this.lblScore);
            this.groupBox1.Controls.Add(questionLabel);
            this.groupBox1.Controls.Add(this.answerLabel);
            this.groupBox1.Controls.Add(this.answerChoice1);
            this.groupBox1.Controls.Add(this.answerChoice2);
            this.groupBox1.Controls.Add(this.correctLabel);
            this.groupBox1.Controls.Add(this.nextButton);
            this.groupBox1.Controls.Add(this.answerChoice3);
            this.groupBox1.Controls.Add(this.submitButton);
            this.groupBox1.Controls.Add(this.answerChoice4);
            this.groupBox1.Location = new System.Drawing.Point(17, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 249);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(367, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(35, 13);
            this.scoreLabel.TabIndex = 34;
            this.scoreLabel.Text = "*******";
            // 
            // questionDescripLabel
            // 
            this.questionDescripLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionDescripLabel.Location = new System.Drawing.Point(73, 25);
            this.questionDescripLabel.Name = "questionDescripLabel";
            this.questionDescripLabel.Size = new System.Drawing.Size(340, 45);
            this.questionDescripLabel.TabIndex = 33;
            this.questionDescripLabel.Text = "**************";
            // 
            // pointValueLabel
            // 
            this.pointValueLabel.AutoSize = true;
            this.pointValueLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.difficultiesBindingSource, "point_value", true));
            this.pointValueLabel.Location = new System.Drawing.Point(66, 223);
            this.pointValueLabel.Name = "pointValueLabel";
            this.pointValueLabel.Size = new System.Drawing.Size(39, 13);
            this.pointValueLabel.TabIndex = 32;
            this.pointValueLabel.Text = "********";
            // 
            // difficultyDescripLabel
            // 
            this.difficultyDescripLabel.AutoSize = true;
            this.difficultyDescripLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.difficultiesBindingSource, "difficultyDescrip", true));
            this.difficultyDescripLabel.ForeColor = System.Drawing.Color.Maroon;
            this.difficultyDescripLabel.Location = new System.Drawing.Point(210, 0);
            this.difficultyDescripLabel.Name = "difficultyDescripLabel";
            this.difficultyDescripLabel.Size = new System.Drawing.Size(39, 13);
            this.difficultyDescripLabel.TabIndex = 31;
            this.difficultyDescripLabel.Text = "********";
            // 
            // categoryDescripLabel
            // 
            this.categoryDescripLabel.AutoSize = true;
            this.categoryDescripLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriesBindingSource, "categoryDescrip", true));
            this.categoryDescripLabel.ForeColor = System.Drawing.Color.Olive;
            this.categoryDescripLabel.Location = new System.Drawing.Point(57, 0);
            this.categoryDescripLabel.Name = "categoryDescripLabel";
            this.categoryDescripLabel.Size = new System.Drawing.Size(43, 13);
            this.categoryDescripLabel.TabIndex = 30;
            this.categoryDescripLabel.Text = "*********";
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "categories";
            this.categoriesBindingSource.DataSource = this.categoriesDataSet;
            // 
            // categoriesDataSet
            // 
            this.categoriesDataSet.DataSetName = "CategoriesDataSet";
            this.categoriesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblScore.Location = new System.Drawing.Point(293, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(75, 13);
            this.lblScore.TabIndex = 29;
            this.lblScore.Text = "Current Score:";
            // 
            // lblUserTabUser
            // 
            this.lblUserTabUser.AutoSize = true;
            this.lblUserTabUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserTabUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblUserTabUser.Location = new System.Drawing.Point(276, 58);
            this.lblUserTabUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserTabUser.Name = "lblUserTabUser";
            this.lblUserTabUser.Size = new System.Drawing.Size(89, 16);
            this.lblUserTabUser.TabIndex = 22;
            this.lblUserTabUser.Text = "Logged in as:";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(364, 341);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 25);
            this.btnQuit.TabIndex = 35;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoriesTableAdapter = this.categoriesTableAdapter;
            this.tableAdapterManager.UpdateOrder = BrainFart.CategoriesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // difficultiesTableAdapter
            // 
            this.difficultiesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.difficultiesTableAdapter = this.difficultiesTableAdapter;
            this.tableAdapterManager1.UpdateOrder = BrainFart.DifficultiesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.Location = new System.Drawing.Point(12, 12);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(50, 25);
            this.btnMain.TabIndex = 40;
            this.btnMain.Text = "Main";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // loggedInLabel
            // 
            this.loggedInLabel.AutoSize = true;
            this.loggedInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggedInLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.loggedInLabel.Location = new System.Drawing.Point(361, 60);
            this.loggedInLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loggedInLabel.Name = "loggedInLabel";
            this.loggedInLabel.Size = new System.Drawing.Size(40, 13);
            this.loggedInLabel.TabIndex = 41;
            this.loggedInLabel.Text = "Guest";
            // 
            // frmQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(454, 384);
            this.ControlBox = false;
            this.Controls.Add(this.lblCorrectAnswer);
            this.Controls.Add(this.loggedInLabel);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lblUserTabUser);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuestions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "       ";
            ((System.ComponentModel.ISupportInitialize)(this.difficultiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difficultiesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataSet)).EndInit();
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
        private System.Windows.Forms.Label correctLabel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label lblCorrectAnswer;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblUserTabUser;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblScore;
        private CategoriesDataSet categoriesDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private CategoriesDataSetTableAdapters.categoriesTableAdapter categoriesTableAdapter;
        private CategoriesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label categoryDescripLabel;
        private DifficultiesDataSet difficultiesDataSet;
        private System.Windows.Forms.BindingSource difficultiesBindingSource;
        private DifficultiesDataSetTableAdapters.difficultiesTableAdapter difficultiesTableAdapter;
        private DifficultiesDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Label pointValueLabel;
        private System.Windows.Forms.Label difficultyDescripLabel;
        private System.Windows.Forms.Label questionDescripLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Label loggedInLabel;
    }
}