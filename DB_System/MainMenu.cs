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
        /// <summary>
        /// directs you to whitebox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button1_Click(object sender, EventArgs e)
        {
            WhiteBox Form1 = new WhiteBox();
            Form1.Show();
            this.Hide();
        }
        /// <summary>
        /// closes application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// directs you to blackbox form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            BlackBox Form4 = new BlackBox();
            Form4.Show();
            this.Hide();

        }
        /// <summary>
        /// directs you to developer form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

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
        /// <summary>
        /// directs you to help black box menu strip form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void blackBoxTestingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpBlackBox form7 = new HelpBlackBox();
            form7.Show();
            this.Hide();
        }
        /// <summary>
        /// directs you to white box texting explanation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void whiteBoxTestingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpWhiteBox HelpWhiteBox = new HelpWhiteBox();
            HelpWhiteBox.Show();
            this.Hide();
        }
        /// <summary>
        /// directs to developer help form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void developerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpDeveloper HelpDeveloper = new HelpDeveloper();
            HelpDeveloper.Show();
            this.Hide();
        }
        /// <summary>
        /// closes application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
