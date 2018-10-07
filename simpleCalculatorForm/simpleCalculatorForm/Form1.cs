using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleCalculatorForm
{
    public partial class simpleCalculatorForm : Form
    {
        public simpleCalculatorForm()
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
                MessageBox.Show(name + " must be a number", "Entry Error"); //If it's not a number, it returns false and shows an error
                textBox.Focus();
                return false;
            }
        }

        public bool IsWithinRange(TextBox textBox, string name, decimal min, decimal max)  //Input validation, tests that the text is within range
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(name + " must be between " + min.ToString() + " and " + max.ToString() + ".", "Entry Error"); //Message box shows if not within range
                textBox.Focus();
                return false;
            }
            else
            { 
                return true;
            }
        }
        public bool IsOperator(TextBox textBox, string name)  // tests that the operator is valid
        {
            if(
                textBox.Text == "+" ||
                textBox.Text == "-" ||
                textBox.Text == "*" ||
                textBox.Text == "/"
                )
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be a +, -, *, or / .", "Entry Error"); //ensures a proper operator was entered
                textBox.Focus();
                return false;
            }
        }

        public bool IsValidData()
        {
            return
            //operand 1 tests
            IsPresent(txtOperandOne, "Operand 1") &&
            IsDecimal(txtOperandOne, "Operand 1") &&
            IsWithinRange(txtOperandOne, "Operand 1", 0, 1000000) &&
            //operand 2 tests
            IsPresent(txtOperandTwo, "Operand 2") &&
            IsDecimal(txtOperandTwo, "Operand 2") &&
            IsWithinRange(txtOperandTwo, "Operand 2", 0, 1000000) &&
            //operator tests
            IsPresent(txtOperator, "Operator") &&
            IsOperator(txtOperator, "Operator");
        }



        private void btnExit_Click(object sender, EventArgs e)  //exit button
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)   //calculates the calculations
        {
            try
            {
                if(IsValidData())                        //runs the validations methods 
                {
                    decimal operandOne = Convert.ToDecimal(txtOperandOne.Text);     //creates variables for entries
                    decimal operandTwo = Convert.ToDecimal(txtOperandTwo.Text);
                    string operatorVariable = txtOperator.Text;
                    decimal result = 0;
                    if (operatorVariable == "+")                                   //all the maths
                    {
                        result = operandOne + operandTwo;
                    }
                    else if(operatorVariable == "-")
                    {
                        result = operandOne - operandTwo;
                    }
                    else if (operatorVariable == "*")
                    {
                        result = operandOne * operandTwo;
                    }
                    else if (operatorVariable == "/")
                    {
                        result = operandOne / operandTwo;
                    }
                    txtResult.Text = string.Format("{0:f4}", result);
                }
            }
            catch(DivideByZeroException)       //catches a divide by 0
            {
                MessageBox.Show("Cannot divide by 0, please enter another value.", "Entry Error");
                txtOperandTwo.Text = "";
                txtOperandTwo.Focus();
            }
            catch(Exception ex)     //catches all other exceptions
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                
            }
        }

        private void simpleCalculatorForm_Load(object sender, EventArgs e)
        {

        }

        private void txtOperandOne_TextChanged(object sender, EventArgs e)  //if text is changed, the result is cleared. The other two textboxes access this function via properties
        {
            txtResult.Text = "";
        }
    }
}
