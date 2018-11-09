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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Orion - Create inventory list
        List<Array> inventoryList = new List<Array>();
        int inventoryListCount;
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Form1_Load(object sender, EventArgs e)
        {

            //initialize inventory list
            inventoryList.Add(new string[7] {"The Matrix", "1999", "R", "Sci-Fi", "1", "BluRay", "10/22/2018"});
            inventoryList.Add(new string[7] {"Pulp Fiction", "1995", "R", "Action", "2", "DVD", "10/21/2018"});
            inventoryList.Add(new string[7] { "The Dark Knight", "2008", "R", "Action", "1", "DVD", "10/22/2018" });
            inventoryList.Add(new string[7] { "Schindler's List", "1993", "R", "Drama", "1", "BluRay", "10/22/2018" });
            inventoryList.Add(new string[7] { "Fight Club  ", "1999", "R", "Action", "1", "BluRay", "10/22/2018" });
            inventoryList.Add(new string[7] { "Forrest Gump", "1994", "R", "Drama", "4", "DVD", "10/22/2018" });
            inventoryList.Add(new string[7] { "Inception  ", "2010", "R", "Sci-Fi", "1", "BluRay", "10/22/2018" });
            inventoryList.Add(new string[7] { "Goodfellas", "1990", "R", "Crime", "2", "DVD", "10/22/2018" });
            inventoryList.Add(new string[7] { "Spirited Away", "2001", "R", "Animation", "2", "BluRay", "10/22/2018" });

            UpdateView();
        }

        public void btnAdd_Click(object sender, EventArgs e)
        {
            //Opens movie entry form
            //Coded by Nathan
            //string[] newMovie = new string[7];
            //inventoryList.Add(newMovie);
            UpdateView();


            Form movieEntryForm = new movieEntry();
            //this.Tag = newMovie[0];
            DialogResult selectedButton = movieEntryForm.ShowDialog();
            if (selectedButton == DialogResult.OK)
            {
                string newMovie = (string) movieEntryForm.Tag;
                string[] newMovieArray = newMovie.Split('|');
                inventoryList.Add(newMovieArray);
                UpdateView();
            }

//            this.Load += new System.EventHandler(this.movieEntry_Load);
//            string[] newMovie = new string[7];
//            UpdateView(newMovie);

        }
        public void UpdateView()
        {
            //Coded by Nathan
            //Clears the listbox then propogates the current Inventory into the listbox
           lsbxInventory.Items.Clear();
            foreach (Array arr in inventoryList) {
              string movieString = "";
              foreach (string el in arr)
                {
                    movieString += el + "\t";
                }
                lsbxInventory.Items.Add(movieString);
            }
            inventoryListCount = inventoryList.Count();
            lblTotalTitles.Text = "Total Titles: " + Convert.ToString(inventoryListCount);
        }

        //
        private void lsbxInventory_SelectedIndexChanged(object sender, EventArgs e) //disregard
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //Coded by Christian Gisala
            int selected = lsbxInventory.SelectedIndex;

            //Ensures that the user selects a recored before allowing to delete
            if(selected == -1)
            {
                MessageBox.Show("Please select a record to delete", "Entry Error");
            }
            else
            {
                inventoryList.RemoveAt(selected);
                UpdateView();
            }
        }
        //Disregard
        private void btnSort_Click(object sender, EventArgs e)
        {
            
        }
        //Disregard
       private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }
    }
}
