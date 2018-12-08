using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;


namespace TicketApp
{
	public partial class TicketAppForm : Form
	{
		private readonly Form _optionsForm = new TicketAppOptions();
		private Timeslot _timeSlot = new Timeslot();
		private List<Ticket> _tickets = new List<Ticket>();
		private int _ticketCounter;
		private int _counter = 1;
		private bool _nextTimeSlot;
		private int _minutes;

		public TicketAppForm()
		{
			this.InitializeComponent();
		}

		private string ReturnStatus()
		{

			return "Open";

		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void TicketAppForm_Load(object sender, EventArgs e)
		{
			this.tmrTimeslot.Enabled = false;
			this._optionsForm.Tag = this._timeSlot;
			this._optionsForm.ShowDialog();
			this.Text = DateTime.Now.ToLongTimeString();
			this.tmrTimeslot.Enabled = true;
			this._ticketCounter = this._timeSlot.FirstTicketNumber;

		}

		private void btnOptions_Click(object sender, EventArgs e)
		{
			var dialogResult = MessageBox.Show(
				"This will clear all time slots",
				"Clear?",
				MessageBoxButtons.OKCancel);

			if (dialogResult == DialogResult.OK)
			{
				this.lblGuestNumber.Text = string.Empty;
				this.lstTickets.Items.Clear();
				this.lblNextAvailableTime.Text = string.Empty;
				this._tickets = null;
				this.tmrTimeslot.Enabled = false;
				this._counter = 1;
				this._timeSlot = new Timeslot();
				this.lblOutstandingTickets.Text = string.Empty;
				this._optionsForm.Tag = this._timeSlot;
				this._optionsForm.ShowDialog();
				this._ticketCounter = this._timeSlot.FirstTicketNumber;
				this.Text = $"{DateTime.Now.ToLongTimeString()} {this.ReturnStatus()}";
				this.tmrTimeslot.Enabled = true;
			}
		}

		private void btnIssueTicket_Click(object sender, EventArgs e)
		{
			if (DateTime.Now > this._timeSlot.EndTime)
			{
				MessageBox.Show("The time window for purchasing tickets has passed");
				return;
			}

			DateTime timeScheduled;
			if (this._counter > this._timeSlot.Guests)
			{
				this._nextTimeSlot = true;
				this._minutes = this._minutes + this._timeSlot.Minutes;
			}

			else
			{
				this._nextTimeSlot = false;
			}

			if (this._nextTimeSlot)
			{
				this._minutes = this._timeSlot.Minutes;
				timeScheduled = this._timeSlot.StartTime.AddMinutes(this._minutes);
				this._timeSlot.StartTime = timeScheduled;
				this._counter = 1;
				this._nextTimeSlot = false;

			}
			else
			{
				timeScheduled = this._timeSlot.StartTime;

			}

			this._counter++;

			if (this._tickets == null)
			{
				this._tickets = new List<Ticket>();
			}

			this._tickets.Add(
				new Ticket {TicketNumber = this._ticketCounter++, TimeScheduled = timeScheduled});
			this.PopulateTicketList(this._timeSlot.StartTime);

		}

		private void PopulateTicketList(DateTime nextAvailableEntry)
		{
			this.lstTickets.Items.Clear();

			foreach (var ticket in this._tickets)
			{
				this.lstTickets.Items.Add(
					$"Ticket {ticket.TicketNumber}: {ticket.TimeScheduled:t}");
			}

			if (this._tickets.Any())
			{
				this.lblNextAvailableTime.Text = nextAvailableEntry.ToLongTimeString();
				this.lblOutstandingTickets.Text = this.lstTickets.Items.Count.ToString();
			}
			else
			{
				this.lblNextAvailableTime.Text = string.Empty;
				this.lblOutstandingTickets.Text = string.Empty;
			}

		}

		private void tmrTimeslot_Tick(object sender, EventArgs e)
		{
			var status = this.lstTickets.Items.Count == 0 && DateTime.Now < this._timeSlot.EndTime
				? Timeslot.TicketAppStatus.Closed
				: Timeslot.TicketAppStatus.Open;

			if (string.IsNullOrEmpty(this.Text))
			{
				this.Text = $"{DateTime.Now.ToLongTimeString()} {"- " + status}";
			}
			else
			{
				var currentTime = DateTime.Now;
				this.Text = $"{currentTime:hh:mm:ss} ({status})";
			}

			if (this._tickets != null)
			{
				var expiredTickets =
					this._tickets.Where(t => t.TimeScheduled < DateTime.Now).ToList();

				if (expiredTickets.Count > 0)
				{
					var minValue = expiredTickets.Min(t => t.TicketNumber);
					var maxValue = expiredTickets.Max(t => t.TicketNumber);
					this.lblGuests.Text = $"{minValue} - {maxValue}";
				}

				foreach (var ticket in this._tickets.Where(t => t.TimeScheduled < DateTime.Now)
					.ToList())
				{
					this._tickets.Remove(ticket);

				}

				this.PopulateTicketList(this._timeSlot.StartTime);
			}

			if (DateTime.Now == this._timeSlot.EndTime || DateTime.Now > this._timeSlot.EndTime)
			{
				this.btnIssueTicket.Enabled = false;
			}
		}
	}
}

