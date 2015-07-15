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
        private mainForm main;
        private int difficultyID;


        public frmNewGame()
        {
            InitializeComponent();
            this.loadCategoryComboBox();
            this.loadDifficultyComboBox();
            this.categoryComboBox.SelectedIndex = 0;
            this.difficultyComboBox.SelectedIndex = 0;
            this.numberQuestionsComboBox.SelectedIndex = 0;
            this.gameOverComboBox.SelectedIndex = 0;
            UserAccessController uac = UserAccessController.Instance;
            if (uac.CurrentLoggedUser != null)
            {
                this.loggedInLabel.Text = uac.CurrentLoggedUser.UserName;
            }
        }


        private void btnGameStart_Click(object sender, EventArgs e)
        {

            this.Hide();
                if (this.categoryComboBox.SelectedIndex == 0)
                {
                    this.categoryID = -1;
                }
                else
                {
                    Categories c = (Categories)this.categoryComboBox.SelectedItem;
                    this.categoryID = c.CategoryID;
                }

                if (this.difficultyComboBox.SelectedIndex == 0)
                {
                    this.difficultyID = -1;
                }
                else
                {
                    Difficulties d = (Difficulties)this.difficultyComboBox.SelectedItem;
                    this.difficultyID = d.DifficultyID;
                }
                
                this.numberOfQuestions = Int32.Parse(this.numberQuestionsComboBox.SelectedItem.ToString());
                questions = new frmQuestions(this.categoryID, this.numberOfQuestions, this.gameOverMode, this.difficultyID);             
                this.questions.ShowDialog();
                
                          
        }

        private void loadDifficultyComboBox()
        {
            try
            {
                this.difficultyComboBox.Items.Add("All Difficulty Levels");
                List<Difficulties> difficultyList = BrainFartController.getAllDifficulties();
                foreach (Difficulties d in difficultyList)
                {
                    this.difficultyComboBox.Items.Add(d);

                }
                this.difficultyComboBox.DisplayMember = "difficultyDescrip";
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

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Are you sure you want to Quit?", "BrainFart", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgResult == DialogResult.No) return;
            else
            {
                Application.Exit();
            }
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Are you sure you want to return to main menu?", "BrainFart", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgResult == DialogResult.No) return;
            else
            {
                this.Close();
            }
        }

        private void gameOverComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gameOverComboBox.SelectedIndex == 0) 
            {
                this.gameOverMode = "All";
            }
            else 
            {
                this.gameOverMode = "Three Strikes";
            }
        }

        private void lblClearForm_Click(object sender, EventArgs e)
        {
            this.categoryComboBox.SelectedIndex = 0;
            this.numberQuestionsComboBox.SelectedIndex = 0;
            this.gameOverComboBox.SelectedIndex = 0;
            this.difficultyComboBox.SelectedIndex = 0;
        }


    }
}