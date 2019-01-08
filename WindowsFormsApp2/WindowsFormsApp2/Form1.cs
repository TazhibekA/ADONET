using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
 
            builder.DataSource = textBox1.Text;
            builder.InitialCatalog = textBox2.Text;
            builder.UserID = textBox3.Text;
            builder.Password = textBox4.Text;

            //textBox5.Text = builder.ConnectionString;​
            textBox5.Text = builder.ConnectionString;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                try
                {
                    // Assigning an invalid connection string
                    // throws an ArgumentException.
                    connection.Open();
                }
                catch (SqlException ex)
                {
                    label5.Text = "Invalid connection string";
                }
                catch (Exception ex)
                {
                    label5.Text = "Invalid connection string";
                }
                
                   
                

                }
            
        }
    }
}
