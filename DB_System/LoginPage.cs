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
namespace DB_System
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       
    
        /// <summary>
        /// connects to database using data string passed
        /// accesses the login table   
        /// once entered correct login credentials next form will open which is the main menu
        /// if clicked the login without entering anything in text box or the incorrect credentials error message will show
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\myDB.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter dataadp = new SqlDataAdapter("select count (*) from login where username = '" + textBox1.Text + "' and password ='" + textBox2.Text + "'", connection);
            DataTable dta = new DataTable();
            dataadp.Fill(dta);
            if (dta.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                MainMenu form2 = new MainMenu();
                form2.Show();
            }
            else
            {
                MessageBox.Show("please enter correct username and password", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// close the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateAccount createaccount = new CreateAccount();
            createaccount.Show();
        }
    }
}
