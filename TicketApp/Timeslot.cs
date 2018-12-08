using System;
using System.Windows.Forms;

namespace TicketApp
{
	public class Timeslot
	{
		public int TimeWindow { get; } = 4;
	    public int Minutes { get; set; }
		public int Guests { get; set; }
		public decimal RemainingGuests { get; set;}
		public DateTime StartTime { get; set; }
		public DateTime EndTime { get; set; }
		public int FirstTicketNumber { get; set; }

		public enum TicketAppStatus
		{
			Open,
			Closed
		}

	}
}
