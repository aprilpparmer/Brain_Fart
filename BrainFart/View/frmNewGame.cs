using BrainFart.Controller;
using BrainFart.DAL;
using BrainFart.Model;
using System;
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
    public partial class frmNewGame : Form
    {
        private frmQuestions questions;
        private int categoryID;
        private int numberOfQuestions;
        private string gameOverMode;


        public frmNewGame()
        {
            InitializeComponent();
            this.loadCategoryComboBox();
            this.categoryComboBox.SelectedIndex = 0;
            this.numberQuestionsComboBox.SelectedIndex = 0;
            this.gameOverComboBox.SelectedIndex = 0;
        }

        private void btnGameStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.categoryComboBox.SelectedValue == null)
                {
                    this.categoryID = -1;
                }
                else
                {
                    Categories c = (Categories)this.categoryComboBox.SelectedItem;
                    this.categoryID = c.CategoryID;
                }
                questions = new frmQuestions(this.categoryID);
                this.questions.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }                
        }

        private void loadCategoryComboBox()
        {
            try
            {
                this.categoryComboBox.Items.Add("All Categories");
                List<Categories> categoryList = BrainFartController.getAllCategories();
                foreach (Categories c in categoryList)
                {
                    this.categoryComboBox.Items.Add(c);
                    
                }
                this.categoryComboBox.DisplayMember = "categoryDescrip";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}