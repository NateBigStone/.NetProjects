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
            try
            {
                long num = (long)Convert.ToDouble(txtNumber.Text);
                long result = 1;
                if (num > 0 && num <= 20)
                {

                    for (var i = num; i > 0; i--)
                    {
                        result = result * num;
                        num--;
                    }
                    lblResult.Text = $"{result:n0}";
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void factorialCalculator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtNumber.Text.Length >= 2)
            {
                btnCalculate.Focus();
            }
        }
    }
}
