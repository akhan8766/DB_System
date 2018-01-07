using System;
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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WhiteBox Form1 = new WhiteBox();
            Form1.Show();
            this.Hide();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BlackBox Form4 = new BlackBox();
            Form4.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Developer form5 = new Developer();
            form5.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void blackBoxTestingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpBlackBox form7 = new HelpBlackBox();
            form7.Show();
            this.Hide();
        }

        private void whiteBoxTestingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpWhiteBox HelpWhiteBox = new HelpWhiteBox();
            HelpWhiteBox.Show();
            this.Hide();
        }

        private void developerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpDeveloper HelpDeveloper = new HelpDeveloper();
            HelpDeveloper.Show();
            this.Hide();
        }
    }
}
