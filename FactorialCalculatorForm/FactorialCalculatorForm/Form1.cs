using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorialCalculatorForm
{
    public partial class factorialCalculator : Form
    {
        public factorialCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try //exception handling to ensure whats entered can be converted into a number
            {
                long num = (long)Convert.ToDouble(txtNumber.Text);  //converts entered text into a long number
                long result = 1;
                if (num > 0 && num <= 20)   //ensures the number entered is between 1 and 20
                {

                    for (var i = num; i > 0; i--)  //loops through the entered number down to 1
                    {
                        result = result * num;     //multiplies the numbers together
                        num--;                      //decrements the number
                    }
                    lblResult.Text = $"{result:n0}";            //displays the result with commas
                }
                else
                {
                    MessageBox.Show(
                   "Please enter a number between 1 and 20.",
                   "Entry Error"
                   );
                    txtNumber.Text = "";
                    txtNumber.Focus();
                }
            }
            catch(FormatException)
            {
                MessageBox.Show(
                    "Invalid numeric format.",
                    "Entry Error"
                    );
                txtNumber.Text = "";
                txtNumber.Focus();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)   //exit button closes form
        {
            this.Close();
        }

        private void factorialCalculator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)                   //esc button closes form 
            {
                this.Close();
            }
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtNumber.Text.Length >= 2)                 //puts the focus on Enter button before too many numbers are entered
            {
                btnCalculate.Focus();
            }
        }
    }
}
