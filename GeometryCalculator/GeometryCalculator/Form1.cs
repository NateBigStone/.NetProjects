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
                if (IsChecked())
                {
                    /*the following if statements create appropriate labels, and make the
                     * apporpriate text boxes visible depending on which radio button is checked*/
                    if (rdoRectangle.Checked == true)
                    {
                        lblInputOne.Text = "Length:"; //changes label to display appropriate information
                        lblInputTwo.Text = "Width:";
                        txtOne.Visible = true; //makes textbox visible
                        txtTwo.Visible = true;
                        txtThree.Text = "0"; //sets unused textboxes to zero for later processing
                        txtFour.Text = "0";
                        txtFive.Text = "0";
                        btnChange.Text = "Answer"; //changes button display
                        txtOne.Focus(); //brings focus to first text box
                    }
                    else if (rdoSquare.Checked == true)
                    {
                        lblInputOne.Text = "Length:";
                        txtOne.Visible = true;
                        txtTwo.Text = "0";
                        txtThree.Text = "0";
                        txtFour.Text = "0";
                        txtFive.Text = "0";
                        btnChange.Text = "Answer";
                        txtOne.Focus();
                    }
                    else if (rdoParallelogram.Checked == true)
                    {
                        if (rdoArea.Checked == true) //gives different text box options depending on which calculation type is checked
                        {
                            lblInputOne.Text = "Base:";
                            lblInputTwo.Text = "Height:";
                            txtOne.Visible = true;
                            txtTwo.Visible = true;
                            txtThree.Text = "0";
                            txtFour.Text = "0";
                            txtFive.Text = "0";
                            btnChange.Text = "Answer";
                            txtOne.Focus();
                        }
                        else if (rdoPerimeter.Checked == true)
                        {
                            lblInputOne.Text = "Length:";
                            lblInputTwo.Text = "Width:";
                            txtOne.Visible = true;
                            txtTwo.Visible = true;
                            txtThree.Text = "0";
                            txtFour.Text = "0";
                            txtFive.Text = "0";
                            btnChange.Text = "Answer";
                            txtOne.Focus();
                        }
                        else if (rdoAreaAndPerimeter.Checked == true)
                        {
                            lblInputOne.Text = "Length (Base):";
                            lblInputTwo.Text = "Width:";
                            lblInputThree.Text = "Height:";
                            txtOne.Visible = true;
                            txtTwo.Visible = true;
                            txtThree.Visible = true;
                            txtFour.Text = "0";
                            txtFive.Text = "0";
                            btnChange.Text = "Answer";
                            txtOne.Focus();
                        }
                    }
                    else if (rdoRhombus.Checked == true)
                    {
                        if (rdoPerimeter.Checked == true)
                        {
                            lblInputOne.Text = "Length:";
                            txtOne.Visible = true;
                            txtTwo.Text = "0";
                            txtThree.Text = "0";
                            txtFour.Text = "0";
                            txtFive.Text = "0";
                            btnChange.Text = "Answer";
                            txtOne.Focus();
                        }
                        else
                        {
                            lblInputOne.Text = "Length:";
                            lblInputTwo.Text = "Height:";
                            txtOne.Visible = true;
                            txtTwo.Visible = true;
                            txtThree.Text = "0";
                            txtFour.Text = "0";
                            txtFive.Text = "0";
                            btnChange.Text = "Answer";
                            txtOne.Focus();
                        }
                    }
                    else if (rdoTriangle.Checked == true)
                    {
                        if (rdoArea.Checked == true)
                        {
                            lblInputOne.Text = "Base:";
                            lblInputTwo.Text = "Height:";
                            txtOne.Visible = true;
                            txtTwo.Visible = true;
                            txtThree.Text = "0";
                            txtFour.Text = "0";
                            txtFive.Text = "0";
                            btnChange.Text = "Answer";
                            txtOne.Focus();
                        }
                        else if (rdoPerimeter.Checked == true)
                        {
                            lblInputOne.Text = "Side A:";
                            lblInputTwo.Text = "Side B:";
                            lblInputThree.Text = "Side C:";
                            txtOne.Visible = true;
                            txtTwo.Visible = true;
                            txtThree.Visible = true;
                            txtFour.Text = "0";
                            txtFive.Text = "0";
                            btnChange.Text = "Answer";
                            txtOne.Focus();
                        }
                        else if (rdoAreaAndPerimeter.Checked == true)
                        {
                            lblInputOne.Text = "Base:";
                            lblInputTwo.Text = "Side B:";
                            lblInputThree.Text = "Side C:";
                            lblInputFour.Text = "Height:";
                            txtOne.Visible = true;
                            txtTwo.Visible = true;
                            txtThree.Visible = true;
                            txtFour.Visible = true;
                            txtFive.Text = "0";
                            btnChange.Text = "Answer";
                            txtOne.Focus();
                        }
                    }
                    else if (rdoTrapezoid.Checked == true)
                    {
                        if (rdoArea.Checked == true)
                        {
                            lblInputOne.Text = "Base:";
                            lblInputTwo.Text = "Top:";
                            lblInputThree.Text = "Height:";
                            txtOne.Visible = true;
                            txtTwo.Visible = true;
                            txtThree.Visible = true;
                            txtFour.Text = "0";
                            txtFive.Text = "0";
                            btnChange.Text = "Answer";
                            txtOne.Focus();
                        }
                        else if (rdoPerimeter.Checked == true)
                        {
                            lblInputOne.Text = "Side A:";
                            lblInputTwo.Text = "Side B:";
                            lblInputThree.Text = "Side C:";
                            lblInputFour.Text = "Side D:";
                            txtOne.Visible = true;
                            txtTwo.Visible = true;
                            txtThree.Visible = true;
                            txtFour.Visible = true;
                            txtFive.Text = "0";
                            btnChange.Text = "Answer";
                            txtOne.Focus();
                        }
                        else if (rdoAreaAndPerimeter.Checked == true)
                        {
                            lblInputOne.Text = "Base:";
                            lblInputTwo.Text = "Top:";
                            lblInputThree.Text = "Side C:";
                            lblInputFour.Text = "Side D:";
                            lblInputFive.Text = "Height:";
                            txtOne.Visible = true;
                            txtTwo.Visible = true;
                            txtThree.Visible = true;
                            txtFour.Visible = true;
                            txtFive.Visible = true;
                            btnChange.Text = "Answer";
                            txtOne.Focus();
                        }
                    }
                    else if (rdoCircle.Checked == true)
                    {
                        lblInputOne.Text = "Radius:";
                        txtOne.Visible = true;
                        txtTwo.Text = "0";
                        txtThree.Text = "0";
                        txtFour.Text = "0";
                        txtFive.Text = "0";
                        btnChange.Text = "Answer";
                        txtOne.Focus();
                    }
                    else if (rdoHexagon.Checked == true)
                    {
                        lblInputOne.Text = "Length:";
                        txtOne.Visible = true;
                        txtTwo.Text = "0";
                        txtThree.Text = "0";
                        txtFour.Text = "0";
                        txtFive.Text = "0";
                        btnChange.Text = "Answer";
                        txtOne.Focus();
                    }
                    else if (rdoOctagon.Checked == true)
                    {
                        lblInputOne.Text = "Length:";
                        txtOne.Visible = true;
                        txtTwo.Text = "0";
                        txtThree.Text = "0";
                        txtFour.Text = "0";
                        txtFive.Text = "0";
                        btnChange.Text = "Answer";
                        txtOne.Focus();
                    }
                    else if (rdoPercent.Checked == true)
                    {
                        lblInputOne.Text = "Dividend:";
                        lblInputTwo.Text = "Divisor:";
                        txtOne.Visible = true;
                        txtTwo.Visible = true;
                        txtThree.Text = "0";
                        txtFour.Text = "0";
                        txtFive.Text = "0";
                        btnChange.Text = "Answer";
                        txtOne.Focus();
                    }
                    else if (rdoRemainder.Checked == true)
                    {
                        lblInputOne.Text = "Dividend:";
                        lblInputTwo.Text = "Divisor:";
                        txtOne.Visible = true;
                        txtTwo.Visible = true;
                        txtThree.Text = "0";
                        txtFour.Text = "0";
                        txtFive.Text = "0";
                        btnChange.Text = "Answer";
                        txtOne.Focus();
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
                        /*initializing variables*/
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
                            if (rdoAreaAndPerimeter.Checked == true)
                            {
                                area = sideA * sideC;
                                perimeter = (sideA + sideB) * 2;
                            }
                            else
                            {
                                area = sideA * sideB;
                                perimeter = (sideA + sideB) * 2;
                            }
                        }
                        else if (rdoRhombus.Checked == true)
                        {
                            if (rdoPerimeter.Checked == true)
                            {
                                perimeter = sideA * 4;
                            }
                            else
                            {
                                area = sideA * sideB;
                                perimeter = sideA * 4;
                            }
                        }
                        else if (rdoTriangle.Checked == true)
                        {
                            if (rdoArea.Checked == true)
                            {
                                area = (sideA * sideB) / 2;
                            }
                            else if (rdoPerimeter.Checked == true)
                            {
                                perimeter = sideA + sideB + sideC;
                            }
                            else if (rdoAreaAndPerimeter.Checked == true)
                            {
                                area = (sideA * sideD) / 2;
                                perimeter = sideA + sideB + sideC;
                            }
                        }
                        else if (rdoTrapezoid.Checked == true)
                        {
                            if (rdoArea.Checked == true)
                            {
                                area = ((sideA + sideB) / 2) * sideC;
                            }
                            else if (rdoPerimeter.Checked == true)
                            {
                                perimeter = sideA + sideB + sideC + sideD;
                            }
                            else if (rdoAreaAndPerimeter.Checked == true)
                            {
                                area = ((sideA + sideB) / 2) * sideE;
                                perimeter = sideA + sideB + sideC + sideD;
                            }
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

                        /*The folloing performs calculations and displays information depending on which tertiary radio button was checked*/
                        if (rdoPercent.Checked == true)
                        {
                            decimal one = Convert.ToDecimal(txtOne.Text);
                            decimal two = Convert.ToDecimal(txtTwo.Text);
                            decimal answer = two / one;
                            lblArea.Text = Convert.ToString("The percentage is: " + $"{answer:p1}");
                        }
                        else if (rdoRemainder.Checked == true)
                        {
                            decimal one = Convert.ToDecimal(txtOne.Text);
                            decimal two = Convert.ToDecimal(txtTwo.Text);
                            decimal answer = one % two;
                            lblArea.Text = Convert.ToString("The remainder is: " + answer);
                        }
                    }
                }

                /*Catching overflow errors*/
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
            this.Close(); //closes the form
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Calls the IsChanged() function
            IsChanged();
            //Resets display picture
            pctPicture.Image = GeometryCalculator.Properties.Resources.random;
            //Resets the radio buttons
            changeRadios();
            rdoPercent.Checked = false;
            rdoRemainder.Checked = false;
        }

        private void rdoChanged(object sender, EventArgs e)
        {
            if (rdoRectangle.Checked == true)
            {
                rdoPercent.Checked = false; //turns radio buttons off
                rdoRemainder.Checked = false;
                pctPicture.Image = GeometryCalculator.Properties.Resources.rectangle; //changes picture
            }
            else if (rdoSquare.Checked == true)
            {
                rdoPercent.Checked = false;
                rdoRemainder.Checked = false;
                pctPicture.Image = GeometryCalculator.Properties.Resources.square;
            }
            else if (rdoParallelogram.Checked == true)
            {
                rdoPercent.Checked = false;
                rdoRemainder.Checked = false;
                pctPicture.Image = GeometryCalculator.Properties.Resources.parallelogram;
            }
            else if (rdoRhombus.Checked == true)
            {
                rdoPercent.Checked = false;
                rdoRemainder.Checked = false;
                pctPicture.Image = GeometryCalculator.Properties.Resources.rhombus;
            }
            else if (rdoTriangle.Checked == true)
            {
                rdoPercent.Checked = false;
                rdoRemainder.Checked = false;
                pctPicture.Image = GeometryCalculator.Properties.Resources.triangle;
            }
            else if (rdoTrapezoid.Checked == true)
            {
                rdoPercent.Checked = false;
                rdoRemainder.Checked = false;
                pctPicture.Image = GeometryCalculator.Properties.Resources.trapezoid;
            }
            else if (rdoCircle.Checked == true)
            {
                rdoPercent.Checked = false;
                rdoRemainder.Checked = false;
                pctPicture.Image = GeometryCalculator.Properties.Resources.circle;
            }
            else if (rdoHexagon.Checked == true)
            {
                rdoPercent.Checked = false;
                rdoRemainder.Checked = false;
                pctPicture.Image = GeometryCalculator.Properties.Resources.hexagon;
            }
            else if (rdoOctagon.Checked == true)
            {
                rdoPercent.Checked = false;
                rdoRemainder.Checked = false;
                pctPicture.Image = GeometryCalculator.Properties.Resources.octagon;
            }
            else if (rdoArea.Checked == true)
            {
                rdoPercent.Checked = false;
                rdoRemainder.Checked = false;
                if (rdoRectangle.Checked == false && rdoSquare.Checked == false && rdoParallelogram.Checked == false &&
                rdoRhombus.Checked == false && rdoTriangle.Checked == false && rdoTrapezoid.Checked == false &&
                rdoCircle.Checked == false && rdoHexagon.Checked == false && rdoOctagon.Checked == false)
                {
                    pctPicture.Image = GeometryCalculator.Properties.Resources.random;
                }
            }
            else if (rdoPerimeter.Checked == true)
            {
                rdoPercent.Checked = false;
                rdoRemainder.Checked = false;
                if (rdoRectangle.Checked == false && rdoSquare.Checked == false && rdoParallelogram.Checked == false &&
                rdoRhombus.Checked == false && rdoTriangle.Checked == false && rdoTrapezoid.Checked == false &&
                rdoCircle.Checked == false && rdoHexagon.Checked == false && rdoOctagon.Checked == false)
                {
                    pctPicture.Image = GeometryCalculator.Properties.Resources.random;
                }
            }
            else if (rdoAreaAndPerimeter.Checked == true)
            {
                rdoPercent.Checked = false;
                rdoRemainder.Checked = false;
                if (rdoRectangle.Checked == false && rdoSquare.Checked == false && rdoParallelogram.Checked == false &&
                rdoRhombus.Checked == false && rdoTriangle.Checked == false && rdoTrapezoid.Checked == false &&
                rdoCircle.Checked == false && rdoHexagon.Checked == false && rdoOctagon.Checked == false)
                {
                    pctPicture.Image = GeometryCalculator.Properties.Resources.random;
                }
            }
            IsChanged();
        }

        private void rdoChangedTwo(object sender, EventArgs e)
        {
            if (rdoPercent.Checked == true)
            {
                changeRadios(); //calls function to clear radio buttons
                pctPicture.Image = GeometryCalculator.Properties.Resources.percent;
            }
            else if (rdoRemainder.Checked == true)
            {
                changeRadios();
                pctPicture.Image = GeometryCalculator.Properties.Resources.remainder;
            }
            IsChanged();
        }

        public void changeRadios()
        {
            rdoRectangle.Checked = false;
            rdoSquare.Checked = false;
            rdoParallelogram.Checked = false;
            rdoRhombus.Checked = false;
            rdoTriangle.Checked = false;
            rdoTrapezoid.Checked = false;
            rdoCircle.Checked = false;
            rdoHexagon.Checked = false;
            rdoOctagon.Checked = false;
            rdoArea.Checked = false;
            rdoPerimeter.Checked = false;
            rdoAreaAndPerimeter.Checked = false;
        }

        public void IsChanged()
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
        }

        public bool IsValid()
        {
            return
                //The following calls data validation functions for each text box
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

        public bool IsPresent(TextBox box, string name) //This function tests if data was added
        {
            if (box.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error"); //Displays error message if not
                box.Focus();
                return false;
            }
            return true;
        }

        public bool IsDecimal(TextBox box, string name) //This function tests if data added was a decimal
        {
            decimal number = 0m;
            if (Decimal.TryParse(box.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(
                    name + " must be an integer. No letters or special symbols allowed.",
                    "Entry Error");
                box.Focus();
                return false;
            }
        }

        public bool IsChecked() //This function tests if corresponding radio buttons are checked
        {
            if (rdoPercent.Checked == true || rdoRemainder.Checked == true)
            {
                return true;
            }
            else if ((rdoArea.Checked == true || rdoPerimeter.Checked == true || rdoAreaAndPerimeter.Checked == true) &&
            (rdoRectangle.Checked == true || rdoSquare.Checked == true || rdoParallelogram.Checked == true ||
            rdoRhombus.Checked == true || rdoTriangle.Checked == true || rdoTrapezoid.Checked == true ||
            rdoCircle.Checked == true || rdoHexagon.Checked == true || rdoOctagon.Checked == true))
            {
                return true;
            }
            else
            {
                MessageBox.Show(
                    "Please check one of the radio buttons under \"Shape\" and \"Calculation\", or a radio button under \"Other Calculations\"", "Entry Error");
                return false;
            }
        }

        private void btnOther_Click(object sender, EventArgs e)
        {

        }

        private void pctPicture_Click(object sender, EventArgs e)
        {

        }
    }
}
