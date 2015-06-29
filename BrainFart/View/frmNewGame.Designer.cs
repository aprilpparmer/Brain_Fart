﻿namespace BrainFart.View
{
    partial class frmNewGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewGame));
            this.logo = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblPatientTabUser = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblClearForm = new System.Windows.Forms.Button();
            this.btnGameStart = new System.Windows.Forms.Button();
            this.gameOverComboBox = new System.Windows.Forms.ComboBox();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.numberQuestionsComboBox = new System.Windows.Forms.ComboBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesDataSet1 = new BrainFart.CategoriesDataSet();
            this.lblCategory = new System.Windows.Forms.Label();
            this.categoriesTableAdapter = new BrainFart.CategoriesDataSetTableAdapters.categoriesTableAdapter();
            this.fillByCategoryToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataSet1)).BeginInit();
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
            this.logo.TabIndex = 35;
            this.logo.TabStop = false;
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(9, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(50, 25);
            this.btnMenu.TabIndex = 34;
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
            this.lblPatientTabUser.TabIndex = 36;
            this.lblPatientTabUser.Text = "Logged in as: Guest";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblClearForm);
            this.groupBox1.Controls.Add(this.btnGameStart);
            this.groupBox1.Controls.Add(this.gameOverComboBox);
            this.groupBox1.Controls.Add(this.lblGameOver);
            this.groupBox1.Controls.Add(this.numberQuestionsComboBox);
            this.groupBox1.Controls.Add(this.lblNumber);
            this.groupBox1.Controls.Add(this.categoryComboBox);
            this.groupBox1.Controls.Add(this.lblCategory);
            this.groupBox1.Location = new System.Drawing.Point(12, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 206);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Options";
            // 
            // lblClearForm
            // 
            this.lblClearForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClearForm.Location = new System.Drawing.Point(248, 161);
            this.lblClearForm.Name = "lblClearForm";
            this.lblClearForm.Size = new System.Drawing.Size(76, 25);
            this.lblClearForm.TabIndex = 35;
            this.lblClearForm.Text = "Reset";
            this.lblClearForm.UseVisualStyleBackColor = true;
            // 
            // btnGameStart
            // 
            this.btnGameStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGameStart.Location = new System.Drawing.Point(151, 161);
            this.btnGameStart.Name = "btnGameStart";
            this.btnGameStart.Size = new System.Drawing.Size(76, 25);
            this.btnGameStart.TabIndex = 34;
            this.btnGameStart.Text = "Lets Do This";
            this.btnGameStart.UseVisualStyleBackColor = true;
            this.btnGameStart.Click += new System.EventHandler(this.btnGameStart_Click);
            // 
            // gameOverComboBox
            // 
            this.gameOverComboBox.FormattingEnabled = true;
            this.gameOverComboBox.Items.AddRange(new object[] {
            "3 Strikes You\'re Out!",
            "All Questions Attempted"});
            this.gameOverComboBox.Location = new System.Drawing.Point(125, 121);
            this.gameOverComboBox.Name = "gameOverComboBox";
            this.gameOverComboBox.Size = new System.Drawing.Size(119, 21);
            this.gameOverComboBox.TabIndex = 6;
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Location = new System.Drawing.Point(10, 124);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(64, 13);
            this.lblGameOver.TabIndex = 5;
            this.lblGameOver.Text = "Game Over:";
            // 
            // numberQuestionsComboBox
            // 
            this.numberQuestionsComboBox.FormattingEnabled = true;
            this.numberQuestionsComboBox.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.numberQuestionsComboBox.Location = new System.Drawing.Point(125, 73);
            this.numberQuestionsComboBox.Name = "numberQuestionsComboBox";
            this.numberQuestionsComboBox.Size = new System.Drawing.Size(37, 21);
            this.numberQuestionsComboBox.TabIndex = 4;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(10, 76);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(109, 13);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "Number of Questions:";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(125, 26);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(119, 21);
            this.categoryComboBox.TabIndex = 2;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "categories";
            this.categoriesBindingSource.DataSource = this.categoriesDataSet1;
            // 
            // categoriesDataSet1
            // 
            this.categoriesDataSet1.DataSetName = "CategoriesDataSet";
            this.categoriesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(10, 29);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(99, 13);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category Selection:";
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // fillByCategoryToolStripButton
            // 
            this.fillByCategoryToolStripButton.Name = "fillByCategoryToolStripButton";
            this.fillByCategoryToolStripButton.Size = new System.Drawing.Size(23, 23);
            // 
            // frmNewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(454, 331);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPatientTabUser);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.btnMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNewGame";
            this.Text = "Bring it On!";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblPatientTabUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button lblClearForm;
        private System.Windows.Forms.Button btnGameStart;
        private System.Windows.Forms.ComboBox gameOverComboBox;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.ComboBox numberQuestionsComboBox;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label lblCategory;
        private CategoriesDataSet categoriesDataSet1;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private CategoriesDataSetTableAdapters.categoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.ToolStripButton fillByCategoryToolStripButton;
    }
}