namespace TotalProducts
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.ProductInput = new System.Windows.Forms.TextBox();
            this.PriceInput = new System.Windows.Forms.TextBox();
            this.QuantityInput = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Products:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity";
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(19, 239);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(93, 37);
            this.BtnCalculate.TabIndex = 9;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(213, 238);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(85, 38);
            this.BtnExit.TabIndex = 10;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // ProductInput
            // 
            this.ProductInput.Location = new System.Drawing.Point(117, 20);
            this.ProductInput.Name = "ProductInput";
            this.ProductInput.Size = new System.Drawing.Size(100, 22);
            this.ProductInput.TabIndex = 5;
            // 
            // PriceInput
            // 
            this.PriceInput.Location = new System.Drawing.Point(117, 131);
            this.PriceInput.Name = "PriceInput";
            this.PriceInput.Size = new System.Drawing.Size(100, 22);
            this.PriceInput.TabIndex = 7;
            // 
            // QuantityInput
            // 
            this.QuantityInput.Location = new System.Drawing.Point(117, 77);
            this.QuantityInput.Name = "QuantityInput";
            this.QuantityInput.Size = new System.Drawing.Size(100, 22);
            this.QuantityInput.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(117, 186);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 33);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CancelButton = this.BtnExit;
            this.ClientSize = new System.Drawing.Size(326, 345);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.QuantityInput);
            this.Controls.Add(this.PriceInput);
            this.Controls.Add(this.ProductInput);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Total Products";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.TextBox ProductInput;
        private System.Windows.Forms.TextBox PriceInput;
        private System.Windows.Forms.TextBox QuantityInput;
        private System.Windows.Forms.Button btnAdd;
    }
}

