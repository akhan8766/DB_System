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
    /// <summary>
    /// creates connection string linking to the appropriate database
    /// </summary>
    public partial class Developer : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\myDB.mdf;Integrated Security=True;Connect Timeout=30");
        public Developer()
        {
            InitializeComponent();
        }
        /// <summary>
        /// display data method
        /// you can call this method
        /// selects using sql form the ASE table
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
        /// calls the display_data method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bugdisp_Click(object sender, EventArgs e)
        {
            
            display_data();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// hides the current form opens the main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu form2 = new MainMenu();
            form2.ShowDialog();
        }

        /// <summary>
        /// inserts into the archive table
        /// using insert method
        /// adds data into the rows of developername date and comment
        /// once entered mesagebox informs data inserted successfully
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button2_Click(object sender, EventArgs e)
        {

            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [ArchiveTable] (DeveloperName,Date,Comment) values ('" + textBox1.Text + "','" + textBox2.Text + "', '" + textBox3.Text + "')";
            cmd.ExecuteNonQuery();
            connection.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            display_data();
            MessageBox.Show("Data inserted successfully");
        }

        
        /// <summary>
        /// update method
        /// updates the columns in the ASETable which then translates all the information 
        /// this is done using insert into method
        /// calls the archive table and all the correct row values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void btnUpArch_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "update ASETable set DeveloperName = '" + textBox1.Text + "', Date = '" + textBox2.Text + "', Comment = '" + textBox3.Text + "' where  BugId = '" + textBox4.Text + "' insert into [ArchiveTable] (Name,Cause,ClassFile,Method,CodeBlock,CodeAuthor,DeveloperName,Date,Comment)" + " select Name,Cause,ClassFile,Method,CodeBlock,CodeAuthor,DeveloperName,Date,Comment from [ASETable] where BugId = '"+textBox4.Text+"' delete from [ASETable] where BugId = '"+textBox4.Text+"'";
            cmd.ExecuteNonQuery();
            connection.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            display_data();
            MessageBox.Show("Data updated successfully");
        }

        /// <summary>
        /// directs to new form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            Archive form6 = new Archive();
            form6.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// colorcode for syntax color in html
        /// html cbody used a title head and body
        /// calls the string and displays the code form the textbox to the webbrowser field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click_1(object sender, EventArgs e)
        {
            string colourizedSourceCode = new CodeColorizer().Colorize(txtSourceCodeView.Text, Languages.CSharp);
            //txtSourceCode.Text = colourizedSourceCode;

            string html = ("<!doctype html><head><meta charset=\"utf-8\" <title> Code Snippet </title> </head> <body>" + colourizedSourceCode + "</body></html>");
            //System.IO.File.WriteAllText(@"F:\Advanced software engineering module\DB_System6\DB_System\Code.html", html);
            webBrowser1.DocumentText = html;
        }

        public void ColourCodeCSharp()
        {

           


        }
        /// <summary>
        /// updates the syntax code in the textbox to update the table
        /// source code is now changed to the copied code
        /// using update method once button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button3_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "update ArchiveTable set CodeBlock = '" +txtSourceCodeView.Text+"' where BugId = '" + textBox4.Text +"'";
            cmd.ExecuteNonQuery();
            connection.Close();
            txtSourceCodeView.Text = "";
            display_data();
            MessageBox.Show("Source Code updated successfully");
        }
    }
    }

