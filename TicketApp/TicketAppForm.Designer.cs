namespace TicketApp
{
    partial class TicketAppForm
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
            this.btnIssueTicket = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstTimeSlots = new System.Windows.Forms.ListBox();
            this.gbGuests = new System.Windows.Forms.GroupBox();
            this.lblGuestNumber = new System.Windows.Forms.Label();
            this.gbAvailability = new System.Windows.Forms.GroupBox();
            this.lblNextAvailableTime = new System.Windows.Forms.Label();
            this.lblOutstandingTickets = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbGuests.SuspendLayout();
            this.gbAvailability.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIssueTicket
            // 
            this.btnIssueTicket.Location = new System.Drawing.Point(12, 105);
            this.btnIssueTicket.Name = "btnIssueTicket";
            this.btnIssueTicket.Size = new System.Drawing.Size(94, 26);
            this.btnIssueTicket.TabIndex = 0;
            this.btnIssueTicket.Text = "Issue Ticket";
            this.btnIssueTicket.UseVisualStyleBackColor = true;
            this.btnIssueTicket.Click += new System.EventHandler(this.btnIssueTicket_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(21, 493);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(75, 26);
            this.btnOptions.TabIndex = 1;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(318, 493);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 26);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstTimeSlots
            // 
            this.lstTimeSlots.FormattingEnabled = true;
            this.lstTimeSlots.ItemHeight = 16;
            this.lstTimeSlots.Location = new System.Drawing.Point(21, 273);
            this.lstTimeSlots.Name = "lstTimeSlots";
            this.lstTimeSlots.Size = new System.Drawing.Size(372, 196);
            this.lstTimeSlots.TabIndex = 3;
            // 
            // gbGuests
            // 
            this.gbGuests.Controls.Add(this.lblGuestNumber);
            this.gbGuests.Location = new System.Drawing.Point(22, 12);
            this.gbGuests.Name = "gbGuests";
            this.gbGuests.Size = new System.Drawing.Size(371, 100);
            this.gbGuests.TabIndex = 4;
            this.gbGuests.TabStop = false;
            this.gbGuests.Text = "Guests with the following tickets may now enter:";
            // 
            // lblGuestNumber
            // 
            this.lblGuestNumber.Location = new System.Drawing.Point(19, 47);
            this.lblGuestNumber.Name = "lblGuestNumber";
            this.lblGuestNumber.Size = new System.Drawing.Size(100, 23);
            this.lblGuestNumber.TabIndex = 1;
            // 
            // gbAvailability
            // 
            this.gbAvailability.Controls.Add(this.lblNextAvailableTime);
            this.gbAvailability.Controls.Add(this.lblOutstandingTickets);
            this.gbAvailability.Controls.Add(this.label2);
            this.gbAvailability.Controls.Add(this.label1);
            this.gbAvailability.Controls.Add(this.btnIssueTicket);
            this.gbAvailability.Location = new System.Drawing.Point(22, 118);
            this.gbAvailability.Name = "gbAvailability";
            this.gbAvailability.Size = new System.Drawing.Size(371, 149);
            this.gbAvailability.TabIndex = 0;
            this.gbAvailability.TabStop = false;
            this.gbAvailability.Text = "Ticket Availability";
            // 
            // lblNextAvailableTime
            // 
            this.lblNextAvailableTime.Location = new System.Drawing.Point(188, 66);
            this.lblNextAvailableTime.Name = "lblNextAvailableTime";
            this.lblNextAvailableTime.Size = new System.Drawing.Size(100, 23);
            this.lblNextAvailableTime.TabIndex = 5;
            // 
            // lblOutstandingTickets
            // 
            this.lblOutstandingTickets.Location = new System.Drawing.Point(195, 35);
            this.lblOutstandingTickets.Name = "lblOutstandingTickets";
            this.lblOutstandingTickets.Size = new System.Drawing.Size(100, 23);
            this.lblOutstandingTickets.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Next available Entry: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total tickets outstanding: ";
            // 
            // TicketAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(405, 531);
            this.Controls.Add(this.gbGuests);
            this.Controls.Add(this.lstTimeSlots);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.gbAvailability);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TicketAppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.TicketAppForm_Load);
            this.gbGuests.ResumeLayout(false);
            this.gbAvailability.ResumeLayout(false);
            this.gbAvailability.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIssueTicket;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstTimeSlots;
        private System.Windows.Forms.GroupBox gbGuests;
        private System.Windows.Forms.Label lblGuestNumber;
        private System.Windows.Forms.GroupBox gbAvailability;
        private System.Windows.Forms.Label lblNextAvailableTime;
        private System.Windows.Forms.Label lblOutstandingTickets;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

