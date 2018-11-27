using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculatorForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Calculator calculation;
        string currentView = "";
        decimal stored = 0.0m;
        bool operatorSelected = false;

        private void numberAdder(string num)  //concats string of a number into view
        {
            if (operatorSelected == true)
            {
                currentView = "";
                txtCurrentValue.Text = currentView;
                operatorSelected = false;
            }
            currentView += num;
            txtCurrentValue.Text = currentView;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
           calculation.CurrentValue = Convert.ToDecimal(currentView);
           txtCurrentValue.Text = Convert.ToString(calculation.Equals());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            calculation = new Calculator();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            calculation.CurrentValue = Convert.ToDecimal(currentView);
            calculation.Add();
            currentView += "+";
            txtCurrentValue.Text = currentView;
            operatorSelected = true;
        }

        private void btnOne_Click(object sender, EventArgs e)  //number one
        {
            numberAdder("1");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            currentView = "";
            txtCurrentValue.Text = currentView;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            numberAdder("2");
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            numberAdder("3");
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            numberAdder("4");
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            numberAdder("5");
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            numberAdder("6");
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            numberAdder("7");
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            numberAdder("8");
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            numberAdder("9");
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            numberAdder("0");
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            calculation.CurrentValue = Convert.ToDecimal(currentView);
            calculation.Subtract();
            currentView += "-";
            txtCurrentValue.Text = currentView;
            operatorSelected = true;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            calculation.CurrentValue = Convert.ToDecimal(currentView);
            calculation.Multiply();
            currentView += "*";
            txtCurrentValue.Text = currentView;
            operatorSelected = true;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            calculation.CurrentValue = Convert.ToDecimal(currentView);
            calculation.Divide();
            currentView += "/";
            txtCurrentValue.Text = currentView;
            operatorSelected = true;
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            if (stored > 0)
            {
                currentView = Convert.ToString(stored);
                txtCurrentValue.Text = currentView;
            }
            
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            char possibleOperator = currentView[currentView.Length - 1];
            if ( 
                possibleOperator == '+' ||
                possibleOperator == '-' ||
                possibleOperator == '*' ||
                possibleOperator == '/'
                )
            {
                stored = Convert.ToDecimal(currentView.Remove(currentView.Length - 1, 1));
            }
            else
            {
                stored = Convert.ToDecimal(currentView);
            }
            txtMemory.Text = "M";
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            stored = 0.0m;
            txtMemory.Text = "";
        }

        private void btnMPlus_Click(object sender, EventArgs e)
        {
            stored += Convert.ToDecimal(currentView);
        }
    }
}
