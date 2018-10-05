using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometryCalculator
{
    public partial class frmGeometryCalculator : Form
    {
        public frmGeometryCalculator()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            /*performs certain functions during first button click*/
            if (btnChange.Text == "Calculate")
            {
                /*performing data validation; making sure each radio button is checked*/
                if (rdoArea.Checked == false && rdoPerimeter.Checked == false && rdoAreaAndPerimeter.Checked == false)
                {
                    MessageBox.Show(
                        "Please check one of the radio buttons under \"Calculations\"", "Entry Error");
                }
                else
                {

                    /*the following if statements create appropriate labels, and make the
                     * apporpriate text boxes visible depending on which radio button is checked*/
                    if (rdoRectangle.Checked == true)
                    {
                        lblInputOne.Text = "Length:"; //changes label to display appropriate information
                        lblInputTwo.Text = "Width:";
                        txtThree.Text = "0"; //sets unused textboxes to zero for later processing
                        txtFour.Text = "0";
                        txtFive.Text = "0";
                        txtOne.Visible = true; //makes textbox visible
                        txtTwo.Visible = true;
                        btnChange.Text = "Answer"; //changes button display
                        pctPicture.Image = GeometryCalculator.Properties.Resources.rectangle; //changes picture
                    }
                    else if (rdoSquare.Checked == true)
                    {
                        lblInputOne.Text = "Length:";
                        txtTwo.Text = "0";
                        txtThree.Text = "0";
                        txtFour.Text = "0";
                        txtFive.Text = "0";
                        txtOne.Visible = true;
                        btnChange.Text = "Answer";
                        pctPicture.Image = GeometryCalculator.Properties.Resources.square;
                    }
                    else if (rdoParallelogram.Checked == true)
                    {
                        lblInputOne.Text = "Length:";
                        lblInputTwo.Text = "Width:";
                        lblInputThree.Text = "Height:";
                        txtFour.Text = "0";
                        txtFive.Text = "0";
                        txtOne.Visible = true;
                        txtTwo.Visible = true;
                        txtThree.Visible = true;
                        btnChange.Text = "Answer";
                        pctPicture.Image = GeometryCalculator.Properties.Resources.parallelogram;
                    }
                    else if (rdoRhombus.Checked == true)
                    {
                        lblInputOne.Text = "Length:";
                        lblInputTwo.Text = "Height:";
                        txtThree.Text = "0";
                        txtFour.Text = "0";
                        txtFive.Text = "0";
                        txtOne.Visible = true;
                        txtTwo.Visible = true;
                        btnChange.Text = "Answer";
                        pctPicture.Image = GeometryCalculator.Properties.Resources.rhombus;
                    }
                    else if (rdoTriangle.Checked == true)
                    {
                        lblInputOne.Text = "Base:";
                        lblInputTwo.Text = "Side 1:";
                        lblInputThree.Text = "Side 2:";
                        lblInputFour.Text = "Height:";
                        txtFive.Text = "0";
                        txtOne.Visible = true;
                        txtTwo.Visible = true;
                        txtThree.Visible = true;
                        txtFour.Visible = true;
                        btnChange.Text = "Answer";
                        pctPicture.Image = GeometryCalculator.Properties.Resources.triangle;
                    }
                    else if (rdoTrapezoid.Checked == true)
                    {
                        lblInputOne.Text = "Base:";
                        lblInputTwo.Text = "Top:";
                        lblInputThree.Text = "Side 1:";
                        lblInputFour.Text = "Side 2:";
                        lblInputFive.Text = "Height:";
                        txtOne.Visible = true;
                        txtTwo.Visible = true;
                        txtThree.Visible = true;
                        txtFour.Visible = true;
                        txtFive.Visible = true;
                        btnChange.Text = "Answer";
                        pctPicture.Image = GeometryCalculator.Properties.Resources.trapezoid;
                    }
                    else if (rdoCircle.Checked == true)
                    {
                        lblInputOne.Text = "Radius:";
                        txtTwo.Text = "0";
                        txtThree.Text = "0";
                        txtFour.Text = "0";
                        txtFive.Text = "0";
                        txtOne.Visible = true;
                        btnChange.Text = "Answer";
                        pctPicture.Image = GeometryCalculator.Properties.Resources.circle;
                    }
                    else if (rdoHexagon.Checked == true)
                    {
                        lblInputOne.Text = "Length:";
                        txtTwo.Text = "0";
                        txtThree.Text = "0";
                        txtFour.Text = "0";
                        txtFive.Text = "0";
                        txtOne.Visible = true;
                        btnChange.Text = "Answer";
                        pctPicture.Image = GeometryCalculator.Properties.Resources.hexagon;
                    }
                    else if (rdoOctagon.Checked == true)
                    {
                        lblInputOne.Text = "Length:";
                        txtTwo.Text = "0";
                        txtThree.Text = "0";
                        txtFour.Text = "0";
                        txtFive.Text = "0";
                        txtOne.Visible = true;
                        btnChange.Text = "Answer";
                        pctPicture.Image = GeometryCalculator.Properties.Resources.octagon;
                    }
                }
            }
            /*performs certain functions during first second button click*/
            else if (btnChange.Text == "Answer")
            {
                try //beginning exception handling
                {
                    /*assigning and initiating variables for later calculations*/

                    if (IsValid())
                    {
                        decimal sideA = Convert.ToDecimal(txtOne.Text);
                        decimal sideB = Convert.ToDecimal(txtTwo.Text);
                        decimal sideC = Convert.ToDecimal(txtThree.Text);
                        decimal sideD = Convert.ToDecimal(txtFour.Text);
                        decimal sideE = Convert.ToDecimal(txtFive.Text);
                        decimal area = 0;
                        decimal perimeter = 0;
                        /*The following perform calculations depending on which radio button is checked*/
                        if (rdoRectangle.Checked == true)
                        {
                            area = sideA * sideB;
                            perimeter = (sideA + sideB) * 2;
                        }
                        else if (rdoSquare.Checked == true)
                        {
                            area = sideA * sideA;
                            perimeter = sideA * 4;
                        }
                        else if (rdoParallelogram.Checked == true)
                        {
                            area = sideA * sideC;
                            perimeter = (sideA + sideB) * 2;
                        }
                        else if (rdoRhombus.Checked == true)
                        {
                            area = sideA * sideB;
                            perimeter = sideA * 4;
                        }
                        else if (rdoTriangle.Checked == true)
                        {
                            area = (sideA * sideD) / 2;
                            perimeter = sideA + sideB + sideC;
                        }
                        else if (rdoTrapezoid.Checked == true)
                        {
                            area = ((sideA + sideB) / 2) * sideE; //sideA is base, sideB is top, sideE is height
                            perimeter = sideA + sideB + sideC + sideD;
                        }
                        else if (rdoCircle.Checked == true)
                        {
                            area = sideA * sideA * 3.14m;
                            perimeter = sideA * 2 * 3.14m;
                        }
                        else if (rdoHexagon.Checked == true)
                        {
                            area = 3m * (1.732050807568877m/2m) * (sideA * sideA);
                            perimeter = sideA * 6;
                        }
                        else if (rdoOctagon.Checked == true)
                        {
                            area = 2m * 2.414213562373095m * (sideA * sideA);
                            perimeter = sideA * 8;
                        }

                        /*The folloing display information depending on which secondary radio button was checked*/
                        if (rdoArea.Checked == true)
                        {
                            lblArea.Text = Convert.ToString("The area is " + $"{area:n2}");
                            lblPerimeter.Text = "";
                        }
                        else if (rdoPerimeter.Checked == true)
                        {
                            lblArea.Text = "";
                            lblPerimeter.Text = Convert.ToString("The perimeter is " + $"{perimeter:n2}");
                        }
                        else if (rdoAreaAndPerimeter.Checked == true)
                        {
                            lblArea.Text = Convert.ToString("The area is " + $"{area:n2}");
                            lblPerimeter.Text = Convert.ToString("The perimeter is " + $"{perimeter:n2}");
                        }
                    }
                }

                /*Catching format errors*/
                catch (OverflowException)
                {
                    MessageBox.Show(
                        "Input is too large.",
                        "Entry Error");
                }
                /*Catching all other errors*/
                catch(Exception ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        ex.GetType().ToString());
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Resets labels
            lblInputOne.Text = "";
            lblInputTwo.Text = "";
            lblInputThree.Text = "";
            lblInputFour.Text = "";
            lblInputFive.Text = "";
            lblArea.Text = "";
            lblPerimeter.Text = "";
            //Resets textboxes
            txtOne.Text = "";
            txtTwo.Text = "";
            txtThree.Text = "";
            txtFour.Text = "";
            txtFive.Text = "";
            //Makes textboxes invisible again
            txtOne.Visible = false;
            txtTwo.Visible = false;
            txtThree.Visible = false;
            txtFour.Visible = false;
            txtFive.Visible = false;
            //Resets button display
            btnChange.Text = "Calculate";
            //Resets display picture
            pctPicture.Image = GeometryCalculator.Properties.Resources.random;
        }

        public bool IsValid()
        {
            return
                IsPresent(txtOne, lblInputOne.Text) &&
                IsDecimal(txtOne, lblInputOne.Text) &&

                IsPresent(txtTwo, lblInputTwo.Text) &&
                IsDecimal(txtTwo, lblInputTwo.Text) &&

                IsPresent(txtThree, lblInputThree.Text) &&
                IsDecimal(txtThree, lblInputThree.Text) &&

                IsPresent(txtFour, lblInputFour.Text) &&
                IsDecimal(txtFour, lblInputFour.Text) &&

                IsPresent(txtFive, lblInputFive.Text) &&
                IsDecimal(txtFive, lblInputFive.Text);
        }

        public bool IsPresent(TextBox box, string name)
        {
            if (box.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                box.Focus();
                return false;
            }
            return true;
        }

        public bool IsDecimal(TextBox box, string name)
        {
            decimal number = 0m;
            if (Decimal.TryParse(box.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(
                    name + " must be a decimal.",
                    "Entry Error");
                box.Focus();
                return false;
            }
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            if (rdoPercent.Checked == true)
            {
                lblAnswer.Text = Convert.ToString(Convert.ToDecimal(txtInputOne.Text) * (Convert.ToDecimal(txtInputTwo.Text) / 100));
            }
        }
    }
}
