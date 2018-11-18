using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TicketApp
{
    public partial class TicketAppForm : Form
    {
	    Form optionsForm = new TicketAppOptions();

        public TicketAppForm()
        {
			
            this.InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
			this.Close();
        }

        private void TicketAppForm_Load(object sender, EventArgs e)
        {
	        this.optionsForm.ShowDialog();
	        var now = DateTime.Now;
	        this.Text = now.ToLongTimeString();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
	        this.optionsForm.ShowDialog();
	        var timeslot = (Timeslot) this.optionsForm.Tag;
	        MessageBox.Show(timeslot.ToString());
        }

        private void btnIssueTicket_Click(object sender, EventArgs e)
        {
			this.btnIssueTicket.Click += EventHandler(this.btnIssueTicket)

        }
    }




	}
}
