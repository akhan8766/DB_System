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
    public partial class Form5 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\myDB.mdf;Integrated Security=True;Connect Timeout=30");
        public Form5()
        {
            InitializeComponent();
        }
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
            dataGridView1.DataSource = dta;
            connection.Close();
        }

        private void bugdisp_Click(object sender, EventArgs e)
        {
            display_data();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[,] Datavalue = new string[dataGridView1.Rows.Count, dataGridView1.Columns.Count];
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    Datavalue[row.Index, col.Index] = dataGridView1.Rows[row.Index].Cells[col.Index].Value.ToString();
                }
            }
            int i = 0;
            foreach (string ss in Datavalue)
                listBox1.Items.Add(ss);
            i++;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
    }

