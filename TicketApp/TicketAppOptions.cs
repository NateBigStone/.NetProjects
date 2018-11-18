using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketApp
{
    public partial class TicketAppOptions : Form
    {
        public TicketAppOptions()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
			//TODO: Add validation here
			if (this.IsValid())
	        {
		        var timeSlot = new Timeslot();
		        this.Tag = timeSlot;
		        this.Close();
            }

        }

	    private bool IsValid()
	    {
		    return true;
	    }
    }
}
