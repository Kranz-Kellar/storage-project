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
    public partial class NewStorageEntry : Form
    {
        public NewStorageEntry()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Item newItem = CreateNewItem();
            if (newItem != null)
            {
                string resultMessage = StorageHandler.AddItemOnRack(newItem.NumberOfRack, newItem);
                MessageBox.Show(resultMessage);
            }
        }

        private Item CreateNewItem()
        {
            try
            {
                string name = itemName.Text;
                int code = StringToInt(itemCode.Text);
                int weight = StringToInt(itemWeight.Text);
                int volume = StringToInt(itemVolume.Text);
                DateTime endOfItemStorage = endOfItemStoraging.Value;
                int numberOfRack = StringToInt(itemNumberOfRack.Text);
                string owner = itemOwner.Text;

                return new Item(code, name, weight, volume, owner, numberOfRack, DateTime.Now, endOfItemStorage);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private int StringToInt(string text)
        {
            int result;
            if(int.TryParse(text, out result))
            {
                return result;
            }

            throw new Exception("Введено неверное значение");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
