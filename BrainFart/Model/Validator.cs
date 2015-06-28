using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace BrainFart.Model
{
    class Validator
    {
        private static string title = "Entry Error";

        public static string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        /// <summary>
        /// check whether each control has value
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public static bool IsPresent(Control control)
        {
            if (control.GetType().ToString() == "System.Windows.Forms.TextBox")
            {
                TextBox textBox = (TextBox)control;
                if (textBox.Text == "")
                {
                    MessageBox.Show(textBox.Tag.ToString() + " is a required field.", Title);
                    textBox.Focus();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if (control.GetType().ToString() == "System.Windows.Forms.ComboBox")
            {
                ComboBox comboBox = (ComboBox)control;
                if (comboBox.SelectedIndex == -1)
                {
                    MessageBox.Show(comboBox.Tag.ToString() + " is a required field.", Title);
                    comboBox.Focus();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return true;
        }

        /// <summary>
        /// check whether value is integer or not
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns></returns>
        public static bool IsInt32(TextBox textBox)
        {
            try
            {
                Convert.ToInt32(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(textBox.Tag.ToString() + " must be an integer value.", Title);
                textBox.Focus();
                return false;
            }
        }

        public static bool IsRadioButtonChecked(RadioButton radioButton, RadioButton radioButton2, RadioButton radioButton3, RadioButton radioButton4)
        {
            if (radioButton.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
            {
                return true;
            }
            else
            {
                MessageBox.Show(" One Answer Must be marked as correct", Title);
                return false;
            }

        }
    }
}
