using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccumulateTestScoreData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)   //disregard
        {

        }

        List<int> scores = new List<int>();         //creates new list of integers 
        List<int> sortScores = new List<int>();        // creates a parrallel list of ints to sort 

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();                 //closes form
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {
                    int scoreText = Convert.ToInt32(txtScore.Text);     //creates score int
                    int total = 0;                                      //initiates total varible
                    int count = 0;                           //initiates count variable
                    int average = 0;                                    //initiates average variable

                    scores.Add(scoreText);                              //adds score to list
                    sortScores.Add(scoreText);                          //adds score to sorted list
                    SortsTheList();                                     //sorts the sorted list

                    int minimum = sortScores[0];
                    int maximum = sortScores[(scores.Count - 1)];

                    for (int i = 0; i < scores.Count; i++)              //loop to add all elements in list
                    {
                        total += scores[i];
                    }

                    count = scores.Count;
                    average = total / count;                           //math for average

                    txtTotal.Text = Convert.ToString(total);            //displays total
                    txtCount.Text = Convert.ToString(count);            //displays Count
                    txtAverage.Text = Convert.ToString(average);        //displays average
                    txtMin.Text = Convert.ToString(minimum);            //displays min
                    txtMax.Text = Convert.ToString(maximum);            //displays max
                    txtScore.Text = "";                                 //clears score
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    ex.GetType().ToString()
                    );
            }
        }

        private void txtScore_Click(object sender, EventArgs e)
        {
            txtScore.Text = "";
        }

        private void btnDispUnsort_Click(object sender, EventArgs e)
        {
            DisplayScores(scores, "Unsorted Scores");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtScore.Text = "";                //clears the display and lists
            txtTotal.Text = "";
            txtCount.Text = "";
            txtAverage.Text = "";
            txtMin.Text = "";
            txtMax.Text = "";
            scores.Clear();
            sortScores.Clear();
        }

        private void btnDispSort_Click(object sender, EventArgs e)
        {
            SortsTheList();
            DisplayScores(sortScores, "Sorted Scores");
        }

        public void DisplayScores(List<int> scoreList, string name) // displays scores
        {
            string scoreDisplay = "";
            for (int j = 0; j < scoreList.Count; j++)     //loop to add all elements in list
            {
                scoreDisplay += Convert.ToString(scoreList[j]) + "\n"; 
            }
            MessageBox.Show(scoreDisplay, name);
        }

        public void SortsTheList()
        {
            sortScores.Sort();
        }

        public bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public bool IsInt(TextBox textBox, string name)
        {
            int number = 0;
            if(Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be a decimal value.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        public bool IsWithinRange(TextBox textBox, string name, int min, int max)
        {
            int number = Convert.ToInt32(textBox.Text);
            if(number < min || number > max)
            {
                MessageBox.Show(name + " must be between " + min.ToString() + " and " + max.ToString() + ".", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public bool IsValidData()
        {
            return
                IsPresent(txtScore, "Score") &&
                IsInt(txtScore, "Score") &&
                IsWithinRange(txtScore, "Score", 0, 100);
        }

        private void label1_Click(object sender, EventArgs e)   //disregard
        {

        }

        private void label2_Click(object sender, EventArgs e)       //disregard
        {

        }
    }
}
