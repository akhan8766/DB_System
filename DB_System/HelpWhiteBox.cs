﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_System
{
    public partial class HelpWhiteBox : Form
    {
        public HelpWhiteBox()
        {
            InitializeComponent();
        }
        /// <summary>
        /// returns to main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu form2 = new MainMenu();
            form2.ShowDialog();
        }
    }
}
