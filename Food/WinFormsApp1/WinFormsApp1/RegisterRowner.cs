using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class RegisterRowner : Form
    {
        public RegisterRowner()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;

            string phone = textBox2.Text;

            string email = textBox3.Text;

            string resturantname = textBox4.Text;
            string place = richTextBox1.Text;
            string date = dateTimePicker1.Text;
            string password = textBox5.Text;

            string connectionString = @"data source=DESKTOP-T3I39VA\SQLEXPRESS; database=Food; integrated security=SSPI";
            string query = "INSERT INTO ResReg (username,phone,email,resturantname,place,date,password) VALUES (@username,@phone,@email,@resturantname,@place,@date,@password)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@phone", phone);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@resturantname", resturantname);
                command.Parameters.AddWithValue("@place", place);
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@password", password);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Profile created successfully!", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Failed to create the profile. Please try again.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
