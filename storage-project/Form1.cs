﻿using System;
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
       
        public MainForm()
        {
            InitializeComponent();

           
        }

        private void addNewItem_Click(object sender, EventArgs e)
        {
            NewStorageEntry form = new NewStorageEntry();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
