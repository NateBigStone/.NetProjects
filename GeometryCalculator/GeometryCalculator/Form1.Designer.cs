namespace GeometryCalculator
{
    partial class frmGeometryCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGeometryCalculator));
            this.bxShape = new System.Windows.Forms.GroupBox();
            this.rdoOctagon = new System.Windows.Forms.RadioButton();
            this.rdoHexagon = new System.Windows.Forms.RadioButton();
            this.rdoCircle = new System.Windows.Forms.RadioButton();
            this.rdoTrapezoid = new System.Windows.Forms.RadioButton();
            this.rdoTriangle = new System.Windows.Forms.RadioButton();
            this.rdoRhombus = new System.Windows.Forms.RadioButton();
            this.rdoParallelogram = new System.Windows.Forms.RadioButton();
            this.rdoSquare = new System.Windows.Forms.RadioButton();
            this.rdoRectangle = new System.Windows.Forms.RadioButton();
            this.bxCalculation = new System.Windows.Forms.GroupBox();
            this.rdoAreaAndPerimeter = new System.Windows.Forms.RadioButton();
            this.rdoPerimeter = new System.Windows.Forms.RadioButton();
            this.rdoArea = new System.Windows.Forms.RadioButton();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblInputOne = new System.Windows.Forms.Label();
            this.lblInputTwo = new System.Windows.Forms.Label();
            this.lblInputThree = new System.Windows.Forms.Label();
            this.lblInputFour = new System.Windows.Forms.Label();
            this.lblInputFive = new System.Windows.Forms.Label();
            this.txtOne = new System.Windows.Forms.TextBox();
            this.txtTwo = new System.Windows.Forms.TextBox();
            this.txtThree = new System.Windows.Forms.TextBox();
            this.txtFour = new System.Windows.Forms.TextBox();
            this.txtFive = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.grpCalc = new System.Windows.Forms.GroupBox();
            this.rdoRemainder = new System.Windows.Forms.RadioButton();
            this.rdoPercent = new System.Windows.Forms.RadioButton();
            this.pctPicture = new System.Windows.Forms.PictureBox();
            this.bxShape.SuspendLayout();
            this.bxCalculation.SuspendLayout();
            this.grpCalc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // bxShape
            // 
            this.bxShape.Controls.Add(this.rdoOctagon);
            this.bxShape.Controls.Add(this.rdoHexagon);
            this.bxShape.Controls.Add(this.rdoCircle);
            this.bxShape.Controls.Add(this.rdoTrapezoid);
            this.bxShape.Controls.Add(this.rdoTriangle);
            this.bxShape.Controls.Add(this.rdoRhombus);
            this.bxShape.Controls.Add(this.rdoParallelogram);
            this.bxShape.Controls.Add(this.rdoSquare);
            this.bxShape.Controls.Add(this.rdoRectangle);
            this.bxShape.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bxShape.Location = new System.Drawing.Point(34, 30);
            this.bxShape.Margin = new System.Windows.Forms.Padding(4);
            this.bxShape.Name = "bxShape";
            this.bxShape.Padding = new System.Windows.Forms.Padding(4);
            this.bxShape.Size = new System.Drawing.Size(237, 403);
            this.bxShape.TabIndex = 0;
            this.bxShape.TabStop = false;
            this.bxShape.Text = "Shape";
            // 
            // rdoOctagon
            // 
            this.rdoOctagon.AutoSize = true;
            this.rdoOctagon.Location = new System.Drawing.Point(22, 358);
            this.rdoOctagon.Name = "rdoOctagon";
            this.rdoOctagon.Size = new System.Drawing.Size(201, 30);
            this.rdoOctagon.TabIndex = 9;
            this.rdoOctagon.Text = "Regular Octagon";
            this.rdoOctagon.UseVisualStyleBackColor = true;
            this.rdoOctagon.CheckedChanged += new System.EventHandler(this.rdoChanged);
            // 
            // rdoHexagon
            // 
            this.rdoHexagon.AutoSize = true;
            this.rdoHexagon.Location = new System.Drawing.Point(22, 321);
            this.rdoHexagon.Name = "rdoHexagon";
            this.rdoHexagon.Size = new System.Drawing.Size(206, 30);
            this.rdoHexagon.TabIndex = 8;
            this.rdoHexagon.Text = "Regular Hexagon";
            this.rdoHexagon.UseVisualStyleBackColor = true;
            this.rdoHexagon.CheckedChanged += new System.EventHandler(this.rdoChanged);
            // 
            // rdoCircle
            // 
            this.rdoCircle.AutoSize = true;
            this.rdoCircle.Location = new System.Drawing.Point(22, 283);
            this.rdoCircle.Margin = new System.Windows.Forms.Padding(4);
            this.rdoCircle.Name = "rdoCircle";
            this.rdoCircle.Size = new System.Drawing.Size(93, 30);
            this.rdoCircle.TabIndex = 7;
            this.rdoCircle.Text = "Circle";
            this.rdoCircle.UseVisualStyleBackColor = true;
            this.rdoCircle.CheckedChanged += new System.EventHandler(this.rdoChanged);
            // 
            // rdoTrapezoid
            // 
            this.rdoTrapezoid.AutoSize = true;
            this.rdoTrapezoid.Location = new System.Drawing.Point(22, 243);
            this.rdoTrapezoid.Margin = new System.Windows.Forms.Padding(4);
            this.rdoTrapezoid.Name = "rdoTrapezoid";
            this.rdoTrapezoid.Size = new System.Drawing.Size(132, 30);
            this.rdoTrapezoid.TabIndex = 6;
            this.rdoTrapezoid.Text = "Trapezoid";
            this.rdoTrapezoid.UseVisualStyleBackColor = true;
            this.rdoTrapezoid.CheckedChanged += new System.EventHandler(this.rdoChanged);
            // 
            // rdoTriangle
            // 
            this.rdoTriangle.AutoSize = true;
            this.rdoTriangle.Location = new System.Drawing.Point(22, 203);
            this.rdoTriangle.Margin = new System.Windows.Forms.Padding(4);
            this.rdoTriangle.Name = "rdoTriangle";
            this.rdoTriangle.Size = new System.Drawing.Size(114, 30);
            this.rdoTriangle.TabIndex = 5;
            this.rdoTriangle.Text = "Triangle";
            this.rdoTriangle.UseVisualStyleBackColor = true;
            this.rdoTriangle.CheckedChanged += new System.EventHandler(this.rdoChanged);
            // 
            // rdoRhombus
            // 
            this.rdoRhombus.AutoSize = true;
            this.rdoRhombus.Location = new System.Drawing.Point(22, 162);
            this.rdoRhombus.Margin = new System.Windows.Forms.Padding(4);
            this.rdoRhombus.Name = "rdoRhombus";
            this.rdoRhombus.Size = new System.Drawing.Size(131, 30);
            this.rdoRhombus.TabIndex = 4;
            this.rdoRhombus.Text = "Rhombus";
            this.rdoRhombus.UseVisualStyleBackColor = true;
            this.rdoRhombus.CheckedChanged += new System.EventHandler(this.rdoChanged);
            // 
            // rdoParallelogram
            // 
            this.rdoParallelogram.AutoSize = true;
            this.rdoParallelogram.Location = new System.Drawing.Point(22, 122);
            this.rdoParallelogram.Margin = new System.Windows.Forms.Padding(4);
            this.rdoParallelogram.Name = "rdoParallelogram";
            this.rdoParallelogram.Size = new System.Drawing.Size(172, 30);
            this.rdoParallelogram.TabIndex = 3;
            this.rdoParallelogram.Text = "Parallelogram";
            this.rdoParallelogram.UseVisualStyleBackColor = true;
            this.rdoParallelogram.CheckedChanged += new System.EventHandler(this.rdoChanged);
            // 
            // rdoSquare
            // 
            this.rdoSquare.AutoSize = true;
            this.rdoSquare.Location = new System.Drawing.Point(22, 82);
            this.rdoSquare.Margin = new System.Windows.Forms.Padding(4);
            this.rdoSquare.Name = "rdoSquare";
            this.rdoSquare.Size = new System.Drawing.Size(107, 30);
            this.rdoSquare.TabIndex = 2;
            this.rdoSquare.Text = "Square";
            this.rdoSquare.UseVisualStyleBackColor = true;
            this.rdoSquare.CheckedChanged += new System.EventHandler(this.rdoChanged);
            // 
            // rdoRectangle
            // 
            this.rdoRectangle.AutoSize = true;
            this.rdoRectangle.Location = new System.Drawing.Point(22, 42);
            this.rdoRectangle.Margin = new System.Windows.Forms.Padding(4);
            this.rdoRectangle.Name = "rdoRectangle";
            this.rdoRectangle.Size = new System.Drawing.Size(135, 30);
            this.rdoRectangle.TabIndex = 1;
            this.rdoRectangle.Text = "Rectangle";
            this.rdoRectangle.UseVisualStyleBackColor = true;
            this.rdoRectangle.CheckedChanged += new System.EventHandler(this.rdoChanged);
            // 
            // bxCalculation
            // 
            this.bxCalculation.Controls.Add(this.rdoAreaAndPerimeter);
            this.bxCalculation.Controls.Add(this.rdoPerimeter);
            this.bxCalculation.Controls.Add(this.rdoArea);
            this.bxCalculation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bxCalculation.Location = new System.Drawing.Point(297, 30);
            this.bxCalculation.Margin = new System.Windows.Forms.Padding(4);
            this.bxCalculation.Name = "bxCalculation";
            this.bxCalculation.Padding = new System.Windows.Forms.Padding(4);
            this.bxCalculation.Size = new System.Drawing.Size(276, 175);
            this.bxCalculation.TabIndex = 1;
            this.bxCalculation.TabStop = false;
            this.bxCalculation.Text = "Calculation";
            // 
            // rdoAreaAndPerimeter
            // 
            this.rdoAreaAndPerimeter.AutoSize = true;
            this.rdoAreaAndPerimeter.Location = new System.Drawing.Point(29, 118);
            this.rdoAreaAndPerimeter.Margin = new System.Windows.Forms.Padding(4);
            this.rdoAreaAndPerimeter.Name = "rdoAreaAndPerimeter";
            this.rdoAreaAndPerimeter.Size = new System.Drawing.Size(226, 30);
            this.rdoAreaAndPerimeter.TabIndex = 12;
            this.rdoAreaAndPerimeter.Text = "Area and Perimeter";
            this.rdoAreaAndPerimeter.UseVisualStyleBackColor = true;
            this.rdoAreaAndPerimeter.CheckedChanged += new System.EventHandler(this.rdoChanged);
            // 
            // rdoPerimeter
            // 
            this.rdoPerimeter.AutoSize = true;
            this.rdoPerimeter.Location = new System.Drawing.Point(29, 80);
            this.rdoPerimeter.Margin = new System.Windows.Forms.Padding(4);
            this.rdoPerimeter.Name = "rdoPerimeter";
            this.rdoPerimeter.Size = new System.Drawing.Size(132, 30);
            this.rdoPerimeter.TabIndex = 11;
            this.rdoPerimeter.Text = "Perimeter";
            this.rdoPerimeter.UseVisualStyleBackColor = true;
            this.rdoPerimeter.CheckedChanged += new System.EventHandler(this.rdoChanged);
            // 
            // rdoArea
            // 
            this.rdoArea.AutoSize = true;
            this.rdoArea.Location = new System.Drawing.Point(29, 42);
            this.rdoArea.Margin = new System.Windows.Forms.Padding(4);
            this.rdoArea.Name = "rdoArea";
            this.rdoArea.Size = new System.Drawing.Size(83, 30);
            this.rdoArea.TabIndex = 10;
            this.rdoArea.Text = "Area";
            this.rdoArea.UseVisualStyleBackColor = true;
            this.rdoArea.CheckedChanged += new System.EventHandler(this.rdoChanged);
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Location = new System.Drawing.Point(302, 337);
            this.btnChange.Margin = new System.Windows.Forms.Padding(4);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(111, 34);
            this.btnChange.TabIndex = 15;
            this.btnChange.Text = "Calculate";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(421, 337);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(111, 34);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(421, 379);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 34);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblInputOne
            // 
            this.lblInputOne.AutoSize = true;
            this.lblInputOne.Location = new System.Drawing.Point(39, 448);
            this.lblInputOne.Name = "lblInputOne";
            this.lblInputOne.Size = new System.Drawing.Size(0, 26);
            this.lblInputOne.TabIndex = 5;
            // 
            // lblInputTwo
            // 
            this.lblInputTwo.AutoSize = true;
            this.lblInputTwo.Location = new System.Drawing.Point(39, 487);
            this.lblInputTwo.Name = "lblInputTwo";
            this.lblInputTwo.Size = new System.Drawing.Size(0, 26);
            this.lblInputTwo.TabIndex = 6;
            // 
            // lblInputThree
            // 
            this.lblInputThree.AutoSize = true;
            this.lblInputThree.Location = new System.Drawing.Point(39, 526);
            this.lblInputThree.Name = "lblInputThree";
            this.lblInputThree.Size = new System.Drawing.Size(0, 26);
            this.lblInputThree.TabIndex = 7;
            // 
            // lblInputFour
            // 
            this.lblInputFour.AutoSize = true;
            this.lblInputFour.Location = new System.Drawing.Point(39, 565);
            this.lblInputFour.Name = "lblInputFour";
            this.lblInputFour.Size = new System.Drawing.Size(0, 26);
            this.lblInputFour.TabIndex = 8;
            // 
            // lblInputFive
            // 
            this.lblInputFive.AutoSize = true;
            this.lblInputFive.Location = new System.Drawing.Point(39, 603);
            this.lblInputFive.Name = "lblInputFive";
            this.lblInputFive.Size = new System.Drawing.Size(0, 26);
            this.lblInputFive.TabIndex = 9;
            // 
            // txtOne
            // 
            this.txtOne.Location = new System.Drawing.Point(150, 445);
            this.txtOne.Name = "txtOne";
            this.txtOne.Size = new System.Drawing.Size(100, 32);
            this.txtOne.TabIndex = 18;
            this.txtOne.Visible = false;
            // 
            // txtTwo
            // 
            this.txtTwo.Location = new System.Drawing.Point(150, 484);
            this.txtTwo.Name = "txtTwo";
            this.txtTwo.Size = new System.Drawing.Size(100, 32);
            this.txtTwo.TabIndex = 19;
            this.txtTwo.Visible = false;
            // 
            // txtThree
            // 
            this.txtThree.Location = new System.Drawing.Point(150, 523);
            this.txtThree.Name = "txtThree";
            this.txtThree.Size = new System.Drawing.Size(100, 32);
            this.txtThree.TabIndex = 20;
            this.txtThree.Visible = false;
            // 
            // txtFour
            // 
            this.txtFour.Location = new System.Drawing.Point(150, 562);
            this.txtFour.Name = "txtFour";
            this.txtFour.Size = new System.Drawing.Size(100, 32);
            this.txtFour.TabIndex = 21;
            this.txtFour.Visible = false;
            // 
            // txtFive
            // 
            this.txtFive.Location = new System.Drawing.Point(150, 600);
            this.txtFive.Name = "txtFive";
            this.txtFive.Size = new System.Drawing.Size(100, 32);
            this.txtFive.TabIndex = 22;
            this.txtFive.Visible = false;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(21, 651);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(0, 82);
            this.lblArea.TabIndex = 15;
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimeter.Location = new System.Drawing.Point(20, 733);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(0, 82);
            this.lblPerimeter.TabIndex = 16;
            // 
            // grpCalc
            // 
            this.grpCalc.Controls.Add(this.rdoRemainder);
            this.grpCalc.Controls.Add(this.rdoPercent);
            this.grpCalc.Location = new System.Drawing.Point(297, 214);
            this.grpCalc.Name = "grpCalc";
            this.grpCalc.Size = new System.Drawing.Size(276, 116);
            this.grpCalc.TabIndex = 24;
            this.grpCalc.TabStop = false;
            this.grpCalc.Text = "Other Calculations";
            // 
            // rdoRemainder
            // 
            this.rdoRemainder.AutoSize = true;
            this.rdoRemainder.Location = new System.Drawing.Point(21, 68);
            this.rdoRemainder.Name = "rdoRemainder";
            this.rdoRemainder.Size = new System.Drawing.Size(144, 30);
            this.rdoRemainder.TabIndex = 14;
            this.rdoRemainder.Text = "Remainder";
            this.rdoRemainder.UseVisualStyleBackColor = true;
            this.rdoRemainder.CheckedChanged += new System.EventHandler(this.rdoChangedTwo);
            // 
            // rdoPercent
            // 
            this.rdoPercent.AutoSize = true;
            this.rdoPercent.Location = new System.Drawing.Point(21, 31);
            this.rdoPercent.Name = "rdoPercent";
            this.rdoPercent.Size = new System.Drawing.Size(112, 30);
            this.rdoPercent.TabIndex = 13;
            this.rdoPercent.Text = "Percent";
            this.rdoPercent.UseVisualStyleBackColor = true;
            this.rdoPercent.CheckedChanged += new System.EventHandler(this.rdoChangedTwo);
            // 
            // pctPicture
            // 
            this.pctPicture.Image = global::GeometryCalculator.Properties.Resources.random;
            this.pctPicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("pctPicture.InitialImage")));
            this.pctPicture.Location = new System.Drawing.Point(297, 431);
            this.pctPicture.Name = "pctPicture";
            this.pctPicture.Size = new System.Drawing.Size(276, 216);
            this.pctPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPicture.TabIndex = 19;
            this.pctPicture.TabStop = false;
            this.pctPicture.Click += new System.EventHandler(this.pctPicture_Click);
            // 
            // frmGeometryCalculator
            // 
            this.AcceptButton = this.btnChange;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(610, 839);
            this.Controls.Add(this.grpCalc);
            this.Controls.Add(this.pctPicture);
            this.Controls.Add(this.lblPerimeter);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.txtFive);
            this.Controls.Add(this.txtFour);
            this.Controls.Add(this.txtThree);
            this.Controls.Add(this.txtTwo);
            this.Controls.Add(this.txtOne);
            this.Controls.Add(this.lblInputFive);
            this.Controls.Add(this.lblInputFour);
            this.Controls.Add(this.lblInputThree);
            this.Controls.Add(this.lblInputTwo);
            this.Controls.Add(this.lblInputOne);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.bxCalculation);
            this.Controls.Add(this.bxShape);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGeometryCalculator";
            this.Text = "Common Geometry Formulas Calculator";
            this.bxShape.ResumeLayout(false);
            this.bxShape.PerformLayout();
            this.bxCalculation.ResumeLayout(false);
            this.bxCalculation.PerformLayout();
            this.grpCalc.ResumeLayout(false);
            this.grpCalc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox bxShape;
        private System.Windows.Forms.RadioButton rdoCircle;
        private System.Windows.Forms.RadioButton rdoTrapezoid;
        private System.Windows.Forms.RadioButton rdoTriangle;
        private System.Windows.Forms.RadioButton rdoRhombus;
        private System.Windows.Forms.RadioButton rdoParallelogram;
        private System.Windows.Forms.RadioButton rdoSquare;
        private System.Windows.Forms.RadioButton rdoRectangle;
        private System.Windows.Forms.GroupBox bxCalculation;
        private System.Windows.Forms.RadioButton rdoAreaAndPerimeter;
        private System.Windows.Forms.RadioButton rdoPerimeter;
        private System.Windows.Forms.RadioButton rdoArea;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblInputOne;
        private System.Windows.Forms.Label lblInputTwo;
        private System.Windows.Forms.Label lblInputThree;
        private System.Windows.Forms.Label lblInputFour;
        private System.Windows.Forms.Label lblInputFive;
        private System.Windows.Forms.TextBox txtOne;
        private System.Windows.Forms.TextBox txtTwo;
        private System.Windows.Forms.TextBox txtThree;
        private System.Windows.Forms.TextBox txtFour;
        private System.Windows.Forms.TextBox txtFive;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.PictureBox pctPicture;
        private System.Windows.Forms.RadioButton rdoOctagon;
        private System.Windows.Forms.RadioButton rdoHexagon;
        private System.Windows.Forms.GroupBox grpCalc;
        private System.Windows.Forms.RadioButton rdoRemainder;
        private System.Windows.Forms.RadioButton rdoPercent;
    }
}

