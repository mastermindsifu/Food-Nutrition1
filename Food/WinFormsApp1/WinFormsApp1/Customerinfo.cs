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
namespace WinFormsApp1
{
    public partial class Customerinfo : Form
    {
        string connectionString = @"data source=DESKTOP-T3I39VA\SQLEXPRESS; database=Food; integrated security=SSPI";
        public Customerinfo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string query = "SELECT * FROM Hello";

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    richTextBox1.Clear();

                    while (reader.Read())
                    {
                        richTextBox1.AppendText(
                          $"Nam: {reader["Nam"]}, " +
                          $"Email: {reader["Email"]}, " +
                          $"PhoneNo: {reader["PhoneNo"]}\n "

                        );
                    }
                }
            }
        }
    }
}
