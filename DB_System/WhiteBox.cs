﻿using System;
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
    /// connection string which links you to the database your tables are located in
    /// </summary>
    public partial class WhiteBox : Form
    {
    
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\myDB.mdf;Integrated Security=True;Connect Timeout=30");
        private readonly string connectionString;

        public WhiteBox()
        {
            InitializeComponent();
        }

      
        /// <summary>
        /// insert method
        /// inserts into the ASE Table and the correct rows 
        /// rows are in conjunction to the textbox fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [ASETable] (ClassFile,Method,CodeBlock,CodeAuthor) values ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox6.Text +"')";
            cmd.ExecuteNonQuery();
            connection.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            display_data();
            MessageBox.Show("Data inserted Successfully");
        }

        // display data
        /// <summary>
        /// This is the display method 
        /// created a sql command and used the select sql command to select from specified table
        /// 
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
            dataGridView1.DataSource = dta;
            connection.Close();
        }

    /// <summary>
    /// deletes bug from the database
    /// shows the datagrid view with bugs
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from [ASETable] where name = '" + textBox5.Text + "'";
            cmd.ExecuteNonQuery();
            connection.Close();
            //textBox1.Text = "";
            //textBox2.Text = "";
            //textBox3.Text = "";
           // textBox4.Text = "";
            //textBox5.Text = "";
            display_data();
            MessageBox.Show("Data deleted Successfully");

        }
        /// <summary>
        /// updates the specified columns in the ASE table 
        /// does not allow to edit any of the data that has been entered by the black box
        /// for example not allowed to enter a Name and cause
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button3_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update ASETable set Method = '" + textBox2.Text + "' , ClassFile = '" + textBox1.Text + "', CodeBlock = '" + textBox3.Text + "', CodeAuthor = '" + textBox6.Text +"' where  BugId = '" + textBox5.Text +"'";
            cmd.ExecuteNonQuery();
            connection.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            display_data();
            MessageBox.Show("Data updated Successfully");
        }
        /// <summary>
        /// created command type
        /// command text selects from table the sql name and the assigned textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select * from [ASETable] where name = '" + textBox4.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dta= new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
            
            dataadp.Fill(dta);
          
            dataGridView1.DataSource = dta;
            connection.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";            
        }
        /// <summary>
        /// exits the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
        /// <summary>
        /// back button, takes back to the specified form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu form2 = new MainMenu();
            form2.ShowDialog();

        }
        /// <summary>
        /// 
        /// displays the data onto the gridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button5_Click_1(object sender, EventArgs e)
        {
            display_data();
        }

        
    }
}
