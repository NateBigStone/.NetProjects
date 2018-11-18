using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketApp
{
	public class Timeslot
	{

	    public int Minutes { get; set; }
		public int Guests { get; set; }
		public int RemainingGuests { get; set; }
		public DateTime StartTime { get; set; }
		public DateTime EndTime { get; set; }
		public int FirstTicketNumber { get; set; }


    }
}
