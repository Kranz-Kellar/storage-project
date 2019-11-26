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
    public partial class MainForm : Form
    {
        Storage storage;
        public MainForm()
        {
            InitializeComponent();

            storage = new Storage(1000, 1000000);
        }

        private void addNewItem_Click(object sender, EventArgs e)
        {
            AddNewItemForm form = new AddNewItemForm(storage);
            form.ShowDialog();
        }
    }
}
