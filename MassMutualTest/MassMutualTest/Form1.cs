using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MassMutualTest
{
    public partial class FrmMassMutual : Form
    {
        bool flag = false;

        /// <summary>
        /// Constructor
        /// </summary>
        public FrmMassMutual()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This function calculates the total value 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTotal_Click(object sender, EventArgs e)
        {

            string value1 = String.Format("{0:n}", txtVal1.Text);
            string value2 = txtVal2.Text;
            string value3 = txtVal3.Text;
            string value4 = txtVal4.Text;
            string value5 = txtVal5.Text;
            ValidateTextBoxes(value1);
            ValidateTextBoxes(value2);
            ValidateTextBoxes(value3);
            ValidateTextBoxes(value4);
            ValidateTextBoxes(value5);
            string val1 = RemoveDollar(value1);
            string val2 = RemoveDollar(value2);
            string val3 = RemoveDollar(value3);
            string val4 = RemoveDollar(value4);
            string val5 = RemoveDollar(value5);
            
            if (flag == false)
            {
                txtTotalVal.Text = (Convert.ToDouble(val1) + Convert.ToDouble(val2) + Convert.ToDouble(val3) + Convert.ToDouble(val4) + Convert.ToDouble(val5)).ToString();
            }
        }

        /// <summary>
        /// Function to validate input values of text boxes, it will throw error if text box is empty or less than or equal to zero, contains any other character apart from number and if dollar sign is missing
        /// </summary>
        /// <param name="value"></param>
        private void ValidateTextBoxes(string value)
        {

            if (value == string.Empty || !Regex.IsMatch(value, @"^\$[0-9.]+\.[0-9][0-9]$"))
            { 
                MessageBox.Show("Please enter valid number in USD. for Ex: $2");
                txtTotalVal.Text = "";
                flag = true;
                return;
                
            }
            string val = RemoveDollar(value);
            if (Convert.ToDouble(val) <= 0.01)
            {
                MessageBox.Show("Please enter numbers greater than zero");
                txtTotalVal.Text = "";
                flag = true;
                return; 
            }
            
        }

        /// <summary>
        /// Function to remove the dollar sign from the text box value
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        private string RemoveDollar(string val)
        {

            Regex regex = new Regex(@"\$(.*)");
            Match match = regex.Match(val);
            if (match.Success)
            {
                val = match.Groups[1].Value;
            }

            return val;
        }

        /// <summary>
        /// Function invoked whenever value of text box 1 is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtVal1_TextChanged (object sender, EventArgs e)
        {
            string value1 = txtVal1.Text;
            flag = false;
        }

        /// <summary>
        /// Function invoked whenever value of text box 2 is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtVal2_TextChanged(object sender, EventArgs e)
        {
            string value2 = txtVal2.Text;
            flag = false;
        }

        /// <summary>
        /// Function invoked whenever value of text box 3 is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtVal3_TextChanged(object sender, EventArgs e)
        {
            string value3 = txtVal3.Text;
            flag = false;
        }

        /// <summary>
        /// Function invoked whenever value of text box 4 is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtVal4_TextChanged(object sender, EventArgs e)
        {
            string value4 = txtVal4.Text;
            flag = false;
        }

        /// <summary>
        /// Function invoked whenever value of text box 5 is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtVal5_TextChanged(object sender, EventArgs e)
        {
            string value5 = txtVal5.Text;
            flag = false;
        }

        
    }
}
