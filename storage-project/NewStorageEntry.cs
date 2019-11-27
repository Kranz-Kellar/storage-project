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
            CreateNewItem();
        }

        private Item CreateNewItem()
        {
            string name = itemName.Text;
            string code = itemCode.Text;
            string weight = itemWeight.Text;
            string volume = itemVolume.Text;
            DateTime endOfItemStorage = endOfItemStoraging.Value;
            string numberOfRack = itemNumberOfRack.Text;
            string owner = itemOwner.Text;

            return new Item(StringToInt(code), name, StringToInt(weight),
                StringToInt(volume), owner,
                StringToInt(numberOfRack),
                DateTime.Now, endOfItemStorage);
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


    }
}
