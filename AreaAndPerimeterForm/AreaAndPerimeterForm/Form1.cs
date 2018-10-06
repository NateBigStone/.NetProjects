using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaAndPerimeterForm
{
    public partial class AreaAndPerimeter : Form
    {
        public AreaAndPerimeter()
        {
            InitializeComponent();
        }

        public bool IsPresent(TextBox textBox, string name)  //input validation, text that textbox isnt blank
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool IsDecimal(TextBox textBox, string name)  //Input validation, tests that the text entered is a number
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number)) 
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be a number", "Entry Error"); //If it's NaN, it returns false and shows an error
                textBox.Focus();
                return false;
            }
        }

        public bool IsValidData()
        {
            if(!IsPresent(txtLength, "Length"))  //tests to ensure a length was entered
            {
                return false;
            }
            if(!IsDecimal(txtLength, "Length"))  //tests to ensure length is a number
            {
                return false;
            }
            if (!IsPresent(txtWidth, "Width"))  //tests to ensure a width was entered
            {
                return false;
            }
            if (!IsDecimal(txtWidth, "Width")) //tests to ensure width is a number
            {
                return false;
            }
            return true;
        }

        private void btnExit_Click(object sender, EventArgs e)    //exit button closes the app. Esc key access this via form properties 
        {
            this.Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try  //makes sure our tests return true before calculating
            {
                if (IsValidData())
                {
                    decimal length = (decimal)Convert.ToDecimal(txtLength.Text);  //initiates length variable and sets it as the the text entered and converts that text to decimal
                    decimal width = (decimal)Convert.ToDecimal(txtWidth.Text);   //initiates width variable and sets it as the the text entered and converts that text to decimal
                    decimal area = length * width;  //initiates area variable and does calculation
                    decimal perimeter = (length * 2) + (width * 2);  //initiates perimeter variable and does calculations
                    lblArea.Text = Convert.ToString(area);   //converts variable to string and sets the text box to it
                    lblPerim.Text = Convert.ToString(perimeter);  //converts variable to string and sets the text box to it
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Entries must be numbers", "Entry Error");  //redundant but maybe my input validation could miss this
                txtLength.Focus();
            }
            catch (OverflowException)
            {
                MessageBox.Show("Please enter a smaller number", "Entry Error");  //message pops up if stack overflow
                txtLength.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());  //message pops up for other error
                txtLength.Focus();
            }
        }

        private void txtLength_TextChanged(object sender, EventArgs e)   //erases results when the length is changed. Width accesses this via form properties
        {
            lblArea.Text = "";
            lblPerim.Text = "";
        }

        private void txtLength_Click(object sender, EventArgs e)  //disregard
        {
        }

        private void btnExit_KeyPress(object sender, KeyPressEventArgs e)   //disregard
        {
        }
    }
}
