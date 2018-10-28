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

        List<Array> inventoryList = new List<Array>();

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Form1_Load(object sender, EventArgs e)
        {


            inventoryList.Add(new string[7] {"The Matrix", "1999", "R", "Sci-Fi", "1", "BluRay", "10/22/18"});
            inventoryList.Add(new string[7] {"Pulp Fiction", "1995", "R", "Action", "2", "DVD", "10/21/18"});
            UpdateView();


            /*            foreach(Array inventory in inventoryList)
                        {
                            string movieString = "";
                            foreach (string el in inventory)
                            {
                                movieString += el + "\t";
                            }
                            lsbxInventory.Items.Add(movieString);
                        }
              */
        }

        public void btnAdd_Click(object sender, EventArgs e)
        {
            string[] newMovie = new string[7];
            inventoryList.Add(newMovie);
            UpdateView();


            Form movieEntryForm = new movieEntry();
            DialogResult selectedButton = movieEntryForm.ShowDialog();
            if (selectedButton == DialogResult.OK)
            {

            }

//            this.Load += new System.EventHandler(this.movieEntry_Load);
//            string[] newMovie = new string[7];
//            UpdateView(newMovie);

        }
        public void UpdateView()
        {
           lsbxInventory.Items.Clear();
            foreach (Array arr in inventoryList) {
              string movieString = "";
              foreach (string el in arr)
                {
                    movieString += el + "\t";
                }
                lsbxInventory.Items.Add(movieString);
            }

        }
    }
}
