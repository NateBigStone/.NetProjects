using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieStoreInventory
{
    public partial class movieEntry : Form
    {
        public movieEntry()
        {
            InitializeComponent();
        }
        string[] newMovie = new string[7];
        DateTime currentDate = DateTime.Today;
        private void movieEntry_Load(object sender, EventArgs e)
        {

            //On form load provides list for our combo box including ratings genres and year of publication
            //Coded by Christian and Orion

            string[] ratings = { "Select Rating...", "G", "PG", "PG-13", "R" };
            foreach (string rating in ratings)
            {
                cboRating.Items.Add(rating);
            }
            cboRating.SelectedIndex = 0;

            string[] genres = { "Select Genre...", "Drama", "Animation", "Action", "Romance", "Anime","Noir","Documentary" };
            foreach (string genre in genres)
            {
                cboGenre.Items.Add(genre);
            }
            cboGenre.SelectedIndex = 0;

            //DateTime currentDate = DateTime.Now;
            Int32 yearInt = Convert.ToInt32(currentDate.Year);
            string yearString = Convert.ToString(yearInt);
            cboYear.Items.Add("Select Year...");

            for (int year = yearInt; year>(yearInt-30);year--)
            {
                yearString = Convert.ToString(year); 
                cboYear.Items.Add(yearString);
            }
            cboYear.SelectedIndex = 0;

            string[] formats = { "Select Genre...", "DVD", "BluRay"};
            foreach (string format in formats)
            {
                cboFormat.Items.Add(format);
            }
            cboFormat.SelectedIndex = 0;

            Form mainForm = new Form1();
            //Array newMovie = mainForm.Tag;


        }

        private void SaveData()
        {
            //Coded by Nathan and Christian
            string title = txtTitle.Text;
            string year = cboYear.Text;
            string rating = cboRating.Text;
            string genre = cboGenre.Text;
            string quantity = txtQuantity.Text;
            string format = cboFormat.Text;

            string newMovie = $"{title}|{year}|{rating}|{genre}|{quantity}|{format}|{currentDate.ToShortDateString()}";
            this.Tag = newMovie;
            this.DialogResult = DialogResult.OK;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           
        }

        //Ensures that all the form requirement are met.
        private bool IsValidData()
        {
            //Coded by Christian Gisala
            if(txtTitle.Text == "")
            {
                MessageBox.Show("You must enter a movie title.", "Entry Error");
                txtTitle.Focus();
                return false;
            }
            if (cboYear.SelectedIndex == 0)
            {
                MessageBox.Show("You must select a year.", "Entry Error");
                cboYear.Focus();
                return false;
            }
            if (cboRating.SelectedIndex == 0)
            {
                MessageBox.Show("You must select a rating.", "Entry Error");
                cboRating.Focus();
                return false;
            }
            if (cboGenre.SelectedIndex == 0)
            {
                MessageBox.Show("You must select a genre.", "Entry Error");
                cboGenre.Focus();
                return false;
            }
            if (txtQuantity.Text == "")
            {
                MessageBox.Show("You must enter a quantity.", "Entry Error");
                txtQuantity.Focus();
                return false;
            }
            if (cboFormat.SelectedIndex == 0)
            {
                MessageBox.Show("You must select a format.", "Entry Error");
                cboGenre.Focus();
                return false;
            }
        
            return true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(IsValidData())
            {
                this.SaveData();
            }
        }

    }
}
