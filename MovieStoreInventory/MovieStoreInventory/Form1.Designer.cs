﻿namespace MovieStoreInventory
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
            this.lsbxInventory = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTotalTitles = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsbxInventory
            // 
            this.lsbxInventory.Location = new System.Drawing.Point(12, 12);
            this.lsbxInventory.MultiColumn = true;
            this.lsbxInventory.Name = "lsbxInventory";
            this.lsbxInventory.Size = new System.Drawing.Size(414, 251);
            this.lsbxInventory.TabIndex = 1;
            this.lsbxInventory.SelectedIndexChanged += new System.EventHandler(this.lsbxInventory_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(451, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(451, 40);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(385, 305);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(304, 305);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblTotalTitles
            // 
            this.lblTotalTitles.AutoSize = true;
            this.lblTotalTitles.Location = new System.Drawing.Point(13, 270);
            this.lblTotalTitles.Name = "lblTotalTitles";
            this.lblTotalTitles.Size = new System.Drawing.Size(62, 13);
            this.lblTotalTitles.TabIndex = 9;
            this.lblTotalTitles.Text = "Total Titles:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 340);
            this.Controls.Add(this.lblTotalTitles);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lsbxInventory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbxInventory;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTotalTitles;
    }
}

