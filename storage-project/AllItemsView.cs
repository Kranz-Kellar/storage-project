using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace storage_project
{
    public partial class AllItemsView : Form
    {
        int currentSelectedItemId;
        public AllItemsView()
        {
            InitializeComponent();
        }

        private void AllItemsView_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = StorageHandler.GetAllItemsForDataGridView();
            dataGridView1.ReadOnly = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                int indexRow = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[indexRow];
                currentSelectedItemId = Convert.ToInt32(row.Cells[0].Value);
                itemCode.Text = row.Cells[1].Value.ToString();
                itemName.Text = row.Cells[2].Value.ToString();
                itemWeight.Text = row.Cells[3].Value.ToString();
                itemVolume.Text = row.Cells[4].Value.ToString();
                itemSupplier.Text = row.Cells[5].Value.ToString();
                itemNumberOfRack.Text = row.Cells[6].Value.ToString();
                itemStartDateStoraging.Text = row.Cells[7].Value.ToString();
                itemEndDateStoraging.Text = row.Cells[8].Value.ToString();
            }
            catch(Exception)
            {
                //Do nothing
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var item = new Item(currentSelectedItemId, Convert.ToInt32(itemCode.Text), itemName.Text, Convert.ToInt32(itemWeight.Text),
                    Convert.ToInt32(itemVolume.Text),
                    itemSupplier.Text, Convert.ToInt32(itemNumberOfRack.Text),
                    Convert.ToDateTime(itemStartDateStoraging.Text), Convert.ToDateTime(itemEndDateStoraging.Text));
                StorageHandler.UpdateItem(item);
                this.dataGridView1.DataSource = StorageHandler.GetAllItemsForDataGridView();
            }
            catch(Exception)
            {
                MessageBox.Show("Введены неверные параметры");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                
                StorageHandler.DeleteItem(currentSelectedItemId);

                currentSelectedItemId = -1;
                this.dataGridView1.DataSource = StorageHandler.GetAllItemsForDataGridView();
            }
            catch(Exception)
            {
                
            }
        }

        private Item CreateItemFromInputBoxes()
        {
            return new Item(currentSelectedItemId, Convert.ToInt32(itemCode.Text), itemName.Text, Convert.ToInt32(itemWeight.Text),
                    Convert.ToInt32(itemVolume.Text),
                    itemSupplier.Text, Convert.ToInt32(itemNumberOfRack.Text),
                    Convert.ToDateTime(itemStartDateStoraging.Text), Convert.ToDateTime(itemEndDateStoraging.Text));
        }
    }
}
