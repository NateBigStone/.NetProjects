using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_Pricing
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        //Variables
        const int MaxCount = 20;
        string[] product = new string[MaxCount]; //Initializes the product array
        decimal[] price = new decimal[MaxCount]; //Initializes the price array
        int[] quantity = new int[MaxCount]; //Initializes the quantity array
		string[] size = new string[MaxCount];
        int counter = 0;
        decimal grandTotal = 0m, taxTotal = 0m, priceTotal = 0m;
        decimal tax = .05m;
	    private decimal total = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
	        try
	        {
		        if (this.IsValid())
		        {
			        product[counter] = txtProduct.Text; //Adds items to the product array
			        price[counter] = Convert.ToDecimal(txtPrice.Text); // Adds price to the price array
			        quantity[counter] = Convert.ToInt32(txtQuantity.Text); //Adds quantity to the quantity array
			        this.size[this.counter] = this.cmbSize.Text;

			        var total = this.price[this.counter] * this.quantity[this.counter];
			        var runningtTotal = Convert.ToDecimal(this.lblRunningTotal.Text.Replace("$", string.Empty)) + total;
			        this.lblRunningTotal.Text = runningtTotal.ToString("c2");
			        counter++;
			        txtProduct.Text = "";
			        txtPrice.Text = "";
			        txtQuantity.Text = "";
			        this.cmbSize.SelectedIndex = 0;
			        txtProduct.Focus();
		        }
            }
	        catch (Exception ex)
	        {
		        MessageBox.Show(
			        $"{ex.Message}{Environment.NewLine}{Environment.NewLine}"
			        + $"{ex.GetType()}{Environment.NewLine}{ex.StackTrace}",
			        "Exception");
            }
	        
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Displays the items in the array
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string totalProduct = "";

            for (int i = 0; i < counter; i++)
            {

                if (quantity[i] == 0)
                {
                    break;
                }
                else
                {
                    totalProduct += product[i] + "\t\t" + price[i] + "\t" + quantity[i] + "\t" + this.size[i] + "\n" ;
                }
            }
            //Calculations:
            for (int i = 0; i < counter; i++)
            {
                priceTotal += (price[i] * quantity[i]); //Calculates total price.
            }

            taxTotal = priceTotal * tax; //Calculates total tax.
            grandTotal = taxTotal + priceTotal; //Adds total price and total tax

            //Displays the result in a receipt format.
               MessageBox.Show("Product" + "\t\tPrice" + "\tQuantity" + "\tSize\n" +
                   totalProduct + "\n" +
                   "Tax = " + taxTotal.ToString("c") + "\n" +
                   "Grand Total: " + grandTotal.ToString("c"), "Receipt");

	        // this.txtMessage.Text = "Product" + "\t\tPrice" + "\tQuantity\n" +
		       //  totalProduct + "\n" +
		       //  "Tax = " + taxTotal + "\n" +
		       //  "Grand Total: " + grandTotal.ToString("c");

        }

	    public bool IsPresent(string value, string name)
	    {
		    if (string.IsNullOrEmpty(value))
		    {
			    MessageBox.Show($"{name} must be provided");
			    return false;
		    }

		    return true;
	    }

        private void ProductForm_Load(object sender, EventArgs e)
        {
	        this.cmbSize.SelectedIndex = 0;
			
        }

        public bool IsDecimal(string value, string name)
	    {
		    if (!decimal.TryParse(value, out var theValue))
		    {
			    MessageBox.Show($"{theValue} is not a valid decimal");
			    return false;

		    }

		    return true;
	    }

	    public bool IsValid()
	    {
		    return this.IsPresent(this.txtProduct.Text, "Product")
			    && this.IsPresent(this.txtPrice.Text, "Price")
			    && this.IsPresent(this.txtQuantity.Text, "Quantity")
			    && this.IsDecimal(this.txtPrice.Text, "Price")
			    && this.IsDecimal(this.txtQuantity.Text, "Quantity");
	    }

    }
}
