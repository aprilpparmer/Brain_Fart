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


        public frmNewGame()
        {
            InitializeComponent();
            this.loadComboBoxes();
        }

        private void btnGameStart_Click(object sender, EventArgs e)
        {
            questions = new frmQuestions();
            this.questions.Show();
            this.Close();
        }

        private void loadComboBoxes()
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