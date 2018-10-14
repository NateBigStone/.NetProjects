using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace TotalProducts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /*This method collect the input of products, price, and quantity from the user and
         * Calculate the total price with the tax*/
        
        //Declaring the product, price and quantity arrays list.
        ArrayList product = new ArrayList();
        ArrayList price = new ArrayList();
        ArrayList quantity = new ArrayList();

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            //Declaring the productString to empty string,
            //and subtotal, taxtotal, and total to decimal type to 0.
            string productString = "";
            decimal subtotal = 0m;
            decimal taxTotal = 0m;
            decimal total = 0m;
            
            //Exception handling.
            try
            {
                { 
                    //For loops iterate over our 3 lists to extract the data. 
                    for (var i = 0; i < product.Count - 1; i++)
                    {
                        //declaring the priceDecimal
                        decimal priceDecimal = Convert.ToDecimal(price[i]);
                        //display the products detail.
                        productString += product[i] + "\t\t\t" + quantity[i] + "\t\t" 
                            + priceDecimal.ToString("c") + "\n";
                        //calculate the subtotal.
                        subtotal = subtotal + priceDecimal;
                    }
                    //calulate the tax total and total.
                    taxTotal = subtotal * .055m;
                    total = taxTotal + subtotal;

                    MessageBox.Show(
                    "Product: \t\t\t" + "Qty: \t\t" + "Price: \n\n" +
                    productString + "\n" +
                    "Subtotal: \t\t\t\t" + subtotal.ToString("c") + "\n" +
                    "Tax: \t\t\t\t\t" + taxTotal.ToString("c") + "\n" +
                    "Total: \t\t\t\t\t" + total.ToString("c"), "Products List");
                }
            }
            catch(OverflowException)
            {
                MessageBox.Show("Overflow error. Please enter smaller values.", "Entry Error");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        public bool valid()
        {
            return
                IsPresent(ProductInput, "Product") &&

                IsPresent(QuantityInput, "Quantity") &&
                IsDecimal(QuantityInput, "Quantity") &&

                IsPresent(PriceInput, "Price") &&
                IsDecimal(PriceInput, "Price");
        }

        //check if the input data is present for all the text boxes.
        public bool IsPresent(TextBox textBox, string name)
        {
           if (textBox.Text == "")
            {
                MessageBox.Show(name + " is required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        //check if the input data is decimal for the price and quantity.
        public bool IsDecimal(TextBox textBox, string name)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be decimal value.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //input validation
            if (valid())
            {
                Decimal PriceToAdd = Convert.ToDecimal(PriceInput.Text);
                Decimal QuantityToAdd = Convert.ToDecimal(QuantityInput.Text);

                product.Add(ProductInput.Text);
                price.Add(PriceToAdd * QuantityToAdd);
                quantity.Add(QuantityToAdd);

                ProductInput.Text = "";
                PriceInput.Text = "";
                QuantityInput.Text = "";
                
            }

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
