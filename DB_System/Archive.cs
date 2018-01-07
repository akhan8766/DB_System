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
using ColorCode;
namespace DB_System
{
    public partial class Archive : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\myDB.mdf;Integrated Security=True;Connect Timeout=30");
        public Archive()
        {
            InitializeComponent();
        }
        /// <summary>
        /// display data method, when used display_data(); will use this method 
        /// can call this method instead of writing all this code for every buton to display data
        /// selects the data in the table named ArchiveTable
        /// 
        /// </summary>
        public void display_data()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Archivetable]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
            dataadp.Fill(dta);
            dataGridView1.DataSource = dta;
            connection.Close();
        }

        private void btndisp_Click(object sender, EventArgs e)
        {


            display_data();



        }


        private void buttonBck_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu form2 = new MainMenu();
            form2.ShowDialog();
        }

        /// <summary>
        /// click on datagridview
        /// click on display archive bug to view the bigs in the datagrid
        /// if you click the datagrid without displaying, will recieve error message
        /// once clicked on display archive bug you can view bugs
        /// click on row and informaion will display in specified textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                textBox6.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                textBox7.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                textBox8.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                textBox9.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                textBox10.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            }
            else
            {
                MessageBox.Show("please click Display Archive Bug ");
            }
            

        } 

        
    }
}
