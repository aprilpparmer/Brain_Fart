using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrainFart
{
    public partial class frmQuestions : Form
    {
        public frmQuestions()
        {
            InitializeComponent();
        }

        private void questionsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.questionsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.questionsDataSet);

        }

        private void frmQuestions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'questionsDataSet.questions' table. You can move, or remove it, as needed.
            this.questionsTableAdapter.Fill(this.questionsDataSet.questions);

        }
    }
}
