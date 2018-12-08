using System;
using System.Windows.Forms;

namespace TicketApp
{
    public partial class TicketAppOptions : Form
    {
	    private Timeslot _timeSlot;
        public TicketAppOptions()
        {
            this.InitializeComponent();
        }

	    private void btnOk_Click(object sender, EventArgs e)
	    {
		    if (this.dtpEnd.Value < this.dtpStart.Value)
		    {
			    MessageBox.Show("End time must be greater than start time");
				return;
		    }
		    this.SetTimeSlot();
		    this.Close();
	    }

	    private void TicketAppOptions_Load(object sender, EventArgs e)
        {
	        this._timeSlot = (Timeslot)this.Tag;
	        this.dtpStart.Value = this.dtpStart.Value.AddMinutes((double)this.nudMinutes.Value);
	        var startTime = this.dtpStart.Value;
	        this.dtpEnd.Value = startTime.AddHours(this._timeSlot.TimeWindow);
            this.SetTimeSlot();
        }

	    private void SetTimeSlot()
	    {
		    this._timeSlot.Minutes = (int)this.nudMinutes.Value;
		    this._timeSlot.Guests = (int)this.nudGuestsPerWindow.Value;
		    this._timeSlot.RemainingGuests = this.nudGuestsPerWindow.Value;
		    this._timeSlot.StartTime = this.dtpStart.Value;
		    this._timeSlot.EndTime = this.dtpEnd.Value;
		    this._timeSlot.FirstTicketNumber = (int)this.nudFirstTicketNumber.Value;
	    }
    }
}
