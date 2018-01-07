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
    /// <summary>
    /// creates connection string to database
    /// </summary>
    public partial class CreateAccount : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\myDB.mdf;Integrated Security=True;Connect Timeout=30");
        public CreateAccount()
        {
            InitializeComponent();
        }
        /// <summary>
        /// display data method
        /// selects from the ASETable
        /// opens and closes connection
        /// can call display_data() in another button without writing full contents of method
        /// </summary>
        public void display_data()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [ASETable]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
            dataadp.Fill(dta);

            //dataGridView1.DataSource = dta;
            connection.Close();
        }
        /// <summary>
        /// inserts username and password into the login table
        /// using insert method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [login] (username,password) values ('" +textBox1.Text+"','" +textBox2.Text+"')";
            cmd.ExecuteNonQuery();
            connection.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            display_data();
            MessageBox.Show("user created successfully");
        }
        /// <summary>
        /// hides the user creation form takes you to login form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage form3 = new LoginPage();
            form3.ShowDialog();
        }
    }
}
