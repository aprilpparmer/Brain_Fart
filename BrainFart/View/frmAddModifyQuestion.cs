using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrainFart.Model;
using BrainFart.Controller;

namespace BrainFart.View
{
    public partial class frmAddModifyQuestion : Form
    {
        public frmAddModifyQuestion()
        {
            InitializeComponent();
        }

        public bool addQuestion;

        private void frmAddModifyQuestion_Load_1(object sender, EventArgs e)
        {
            this.LoadQuestionComboBoxes();
            if (addQuestion)
            {
                this.Text = "Add Question";
                cbCategory.Enabled = true;
                cbCategory.SelectedIndex = -1;
                cbDifficulty.Enabled = true;
                cbDifficulty.SelectedIndex = -1;
            }
            else
            {
                this.Text = "Modify Question";
                //Code to be completed Second Iteration
            }
        }

        private void LoadQuestionComboBoxes()
        {
            try
            {
                List<Categories> categorylist;
                categorylist = BrainFartController.getAllCategories();
                cbCategory.DataSource = categorylist;
                cbCategory.DisplayMember = "categoryDescrip";
                cbCategory.ValueMember = "categoryID";

                List<Difficulties> difficultylist;
                difficultylist = BrainFartController.getAllDifficulties();
                cbDifficulty.DataSource = difficultylist;
                cbDifficulty.DisplayMember = "difficultyDescrip";
                cbDifficulty.ValueMember = "difficultyID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

    }
}
