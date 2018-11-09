using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchOrder
{
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        double courseCost = 0.00;       //creates variables for cost
        double addonCost = 0.00;
        double addonValue = 0.00;

        private void btnExit_Click(object sender, EventArgs e) //exit button
        {
            this.Close();
        }

        private void btnOrder_Click(object sender, EventArgs e) //order button calculates
        {
            checkChanged();
            if (checkBox1.Checked)              //adds addons
            {
                addonCost += addonValue;
            }
            if (checkBox2.Checked)
            {
                addonCost += addonValue;
            }
            if (checkBox3.Checked)
            {
                addonCost += addonValue;
            }
            double subTotal = courseCost + addonCost;  //calculates subtotal tax total
            double tax = subTotal * .0775;
            double total = subTotal + tax;

            txtSub.Text = subTotal.ToString("C");
            txtTax.Text = tax.ToString("C");
            txtTotal.Text = total.ToString("C");
        }

        public void checkChanged()
        {
            courseCost = 0.00;    //sets values back to zero
            addonCost = 0.00;
            addonValue = 0.00;

            if (rdoHam.Checked == true)      //check which course
            {
                courseChecked("Hamburger");
            }
            else if (rdoPizza.Checked == true)
            {
                courseChecked("Pizza");
            }
            else if (rdoSalad.Checked == true)
            {
                courseChecked("Salad");
            }
        }

        public void courseChecked(string courseFood)   //changes groupbox
        {
            if (courseFood == "Hamburger")
            {
                grpAddon.Text = "Add-on items ($.75/each";
                checkBox1.Text = "Lettuce, tomato, and onions";
                checkBox2.Text = "Ketchup, mustard, and mayo";
                checkBox3.Text = "French fries";
                courseFood = "Hamburger";
                courseCost = 6.95;
                addonValue = 0.75;
            }
            else if (courseFood == "Pizza")
            {
                grpAddon.Text = "Add-on items ($.50/each";
                checkBox1.Text = "Pepperoni";
                checkBox2.Text = "Sausage";
                checkBox3.Text = "Olives";
                courseFood = "Pizza";
                courseCost = 5.95;
                addonValue = 0.50;
            }
            else if (courseFood == "Salad")
            {
                grpAddon.Text = "Add-on items ($.25/each";
                checkBox1.Text = "Croutons";
                checkBox2.Text = "Bacon bits";
                checkBox3.Text = "Bread sticks";
                courseFood = "Salad";
                courseCost = 4.95;
                addonValue = 0.25;
            }
        }

        private void rdoHam_CheckedChanged(object sender, EventArgs e) //checks changed
        {
            checkChanged();
        }
    }
}
