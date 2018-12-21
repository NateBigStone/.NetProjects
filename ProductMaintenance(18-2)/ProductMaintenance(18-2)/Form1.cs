using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProductMaintenance_18_2_
{
    public partial class frmProductMaintenance : Form
    {
        public frmProductMaintenance()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            productCodeTextBox.ReadOnly = true;
            nameTextBox.Focus();

            try
            {
                this.productsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.techSupport_DataDataSet);
            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show("A concurrency error occurred. " + "Some rows were not updated.", "Concurrency Exception");
                this.productsTableAdapter.Fill(this.techSupport_DataDataSet.Products);
            }
            catch (DataException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                productsBindingSource.CancelEdit();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error # " + ex.Number + ": " + ex.Message, ex.GetType().ToString());
            }

        }

        private void frmProductMaintenance_Load(object sender, EventArgs e)


        {
            nameTextBox.Focus();
            // TODO: This line of code loads data into the 'techSupport_DataDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.techSupport_DataDataSet.Products);

        }

        private void releaseDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }    

        private void toolStripBtnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                this.productsTableAdapter.FillByProductCode(this.techSupport_DataDataSet.Products, toolStripTxtQuery.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)

        {
            productCodeTextBox.Focus();
            productCodeTextBox.ReadOnly = false;
        }

        private void productCodeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
