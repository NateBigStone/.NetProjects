namespace LunchOrder
{
    partial class frmOrder
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
            this.grpMain = new System.Windows.Forms.GroupBox();
            this.grpAddon = new System.Windows.Forms.GroupBox();
            this.grpTotals = new System.Windows.Forms.GroupBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.rdoHam = new System.Windows.Forms.RadioButton();
            this.rdoPizza = new System.Windows.Forms.RadioButton();
            this.rdoSalad = new System.Windows.Forms.RadioButton();
            this.txtSub = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.grpMain.SuspendLayout();
            this.grpAddon.SuspendLayout();
            this.grpTotals.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMain
            // 
            this.grpMain.Controls.Add(this.rdoSalad);
            this.grpMain.Controls.Add(this.rdoPizza);
            this.grpMain.Controls.Add(this.rdoHam);
            this.grpMain.Location = new System.Drawing.Point(22, 25);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(211, 143);
            this.grpMain.TabIndex = 0;
            this.grpMain.TabStop = false;
            this.grpMain.Text = "Main course";
            // 
            // grpAddon
            // 
            this.grpAddon.Controls.Add(this.checkBox3);
            this.grpAddon.Controls.Add(this.checkBox2);
            this.grpAddon.Controls.Add(this.checkBox1);
            this.grpAddon.Location = new System.Drawing.Point(252, 25);
            this.grpAddon.Name = "grpAddon";
            this.grpAddon.Size = new System.Drawing.Size(233, 143);
            this.grpAddon.TabIndex = 1;
            this.grpAddon.TabStop = false;
            this.grpAddon.Text = "Add-on items ($.75/each";
            // 
            // grpTotals
            // 
            this.grpTotals.Controls.Add(this.label3);
            this.grpTotals.Controls.Add(this.label2);
            this.grpTotals.Controls.Add(this.label1);
            this.grpTotals.Controls.Add(this.txtTotal);
            this.grpTotals.Controls.Add(this.txtTax);
            this.grpTotals.Controls.Add(this.txtSub);
            this.grpTotals.Location = new System.Drawing.Point(22, 175);
            this.grpTotals.Name = "grpTotals";
            this.grpTotals.Size = new System.Drawing.Size(294, 149);
            this.grpTotals.TabIndex = 2;
            this.grpTotals.TabStop = false;
            this.grpTotals.Text = "Order total";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(341, 185);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(144, 28);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Place Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(341, 290);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(143, 33);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rdoHam
            // 
            this.rdoHam.AutoSize = true;
            this.rdoHam.Checked = true;
            this.rdoHam.Location = new System.Drawing.Point(18, 30);
            this.rdoHam.Name = "rdoHam";
            this.rdoHam.Size = new System.Drawing.Size(113, 17);
            this.rdoHam.TabIndex = 0;
            this.rdoHam.TabStop = true;
            this.rdoHam.Text = "Hamburger - $6.95";
            this.rdoHam.UseVisualStyleBackColor = true;
            this.rdoHam.CheckedChanged += new System.EventHandler(this.rdoHam_CheckedChanged);
            // 
            // rdoPizza
            // 
            this.rdoPizza.AutoSize = true;
            this.rdoPizza.Location = new System.Drawing.Point(18, 63);
            this.rdoPizza.Name = "rdoPizza";
            this.rdoPizza.Size = new System.Drawing.Size(86, 17);
            this.rdoPizza.TabIndex = 1;
            this.rdoPizza.Text = "Pizza - $5.95";
            this.rdoPizza.UseVisualStyleBackColor = true;
            this.rdoPizza.CheckedChanged += new System.EventHandler(this.rdoHam_CheckedChanged);
            // 
            // rdoSalad
            // 
            this.rdoSalad.AutoSize = true;
            this.rdoSalad.Location = new System.Drawing.Point(18, 99);
            this.rdoSalad.Name = "rdoSalad";
            this.rdoSalad.Size = new System.Drawing.Size(82, 17);
            this.rdoSalad.TabIndex = 2;
            this.rdoSalad.Text = "Salad $4.95";
            this.rdoSalad.UseVisualStyleBackColor = true;
            this.rdoSalad.CheckedChanged += new System.EventHandler(this.rdoHam_CheckedChanged);
            // 
            // txtSub
            // 
            this.txtSub.Location = new System.Drawing.Point(124, 39);
            this.txtSub.Name = "txtSub";
            this.txtSub.ReadOnly = true;
            this.txtSub.Size = new System.Drawing.Size(100, 20);
            this.txtSub.TabIndex = 0;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(124, 65);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(100, 20);
            this.txtTax.TabIndex = 1;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(124, 91);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Subtotal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tax(7.75%):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Order total:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(31, 30);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(158, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Lettuce, tomato, and onions";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(31, 64);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(161, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Ketchup, mustard, and mayo";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(31, 99);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(81, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "French fries";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // frmOrder
            // 
            this.AcceptButton = this.btnOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(505, 336);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.grpTotals);
            this.Controls.Add(this.grpAddon);
            this.Controls.Add(this.grpMain);
            this.Name = "frmOrder";
            this.Text = "Lunch Order";
            this.grpMain.ResumeLayout(false);
            this.grpMain.PerformLayout();
            this.grpAddon.ResumeLayout(false);
            this.grpAddon.PerformLayout();
            this.grpTotals.ResumeLayout(false);
            this.grpTotals.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMain;
        private System.Windows.Forms.GroupBox grpAddon;
        private System.Windows.Forms.GroupBox grpTotals;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rdoSalad;
        private System.Windows.Forms.RadioButton rdoPizza;
        private System.Windows.Forms.RadioButton rdoHam;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtSub;
    }
}

