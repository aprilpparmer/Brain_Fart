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
        private UserAccessController userAccess = UserAccessController.Instance;
        private frmQuestions questions;
        private int categoryID;
        private int numberOfQuestions;
        private string gameOverMode;
        public String userLabel;


        public frmNewGame()
        {
            InitializeComponent();
            this.loadCategoryComboBox();
            this.categoryComboBox.SelectedIndex = 0;
            this.numberQuestionsComboBox.SelectedIndex = 0;
            this.gameOverComboBox.SelectedIndex = 0;
        }

        private void frmNewGame_Load(object sender, EventArgs e)
        {
            this.lblUserTabUser.Text = userLabel;
        }

        private void btnGameStart_Click(object sender, EventArgs e)
        {
            
                if (this.categoryComboBox.SelectedIndex == 0)
                {
                    this.categoryID = -1;
                }
                else
                {
                    Categories c = (Categories)this.categoryComboBox.SelectedItem;
                    this.categoryID = c.CategoryID;
                }
           
                this.numberOfQuestions = Int32.Parse(this.numberQuestionsComboBox.SelectedItem.ToString());
                questions = new frmQuestions(this.categoryID, this.numberOfQuestions);
                questions.userLabel = this.userLabel;
                questions.FormClosed += new FormClosedEventHandler(questions_FormClosed);
                this.questions.Show();
                this.Hide();
                          
        }

        private void questions_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
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

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Are you sure you want to Quit?", "BrainFart", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgResult == DialogResult.No) return;
            else
            {
                this.Close();
            }
        }
    }
}