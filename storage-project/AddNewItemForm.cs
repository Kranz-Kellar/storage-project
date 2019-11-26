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
    public partial class AddNewItemForm : Form
    {
        private Storage storage;
        public AddNewItemForm(Storage storage)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int amount = StringToInt(itemAmount.Text);
                int weight = StringToInt(itemWeight.Text);
                int volume = StringToInt(itemVolume.Text);
                Item item = new Item(1, itemName.Text, amount, weight, volume);
                storage.AddNewItem(item);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

        private int StringToInt(string text)
        {
            int result;
            if(int.TryParse(text, out result))
            {
                return result;
            }

            throw new ArgumentException("Введены неверные параметры");
        }
    }
}
