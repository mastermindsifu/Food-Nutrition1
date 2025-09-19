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

    
    public partial class WorkerRegcs : Form
    {
        public Form1 _mainForm;
        public WorkerRegcs()
        {
            InitializeComponent();
        }
        public WorkerRegcs(Form1 mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;

            string userid = textBox2.Text;

            string email = textBox3.Text;

            string password = textBox4.Text;


            string details = username + " \n " + userid + " \n " + email + " \n " + password;

            MessageBox.Show(" given " + details);

            if (string.IsNullOrWhiteSpace(username))


            {
                MessageBox.Show("Username fields must be filled out.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrWhiteSpace(userid))


            {
                MessageBox.Show("UserId fields must be filled out.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Email fields must be filled out.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else if (string.IsNullOrWhiteSpace(password))

            {
                MessageBox.Show("Password fields must be filled out.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }











            string connectionString = @"data source=DESKTOP-T3I39VA\SQLEXPRESS; database=Food; integrated security=SSPI";
            string query = "INSERT INTO worker (username,userid,email,password) VALUES (@username, @userid, @email, @password)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@userid", userid);
                command.Parameters.AddWithValue("@email", email);
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

