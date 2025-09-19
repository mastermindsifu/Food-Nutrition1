using Microsoft.VisualBasic.ApplicationServices;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
//using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string uname= richTextBox1.Text;
            string pass= richTextBox2.Text;
            //string details = id + "  " + pass;
            //MessageBox.Show("given :" + details);

            //valid inputs message
            if (string.IsNullOrWhiteSpace(uname) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Please enter both Id and Name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if(uname=="admin" || pass=="admin")
            {
                Admin a= new Admin();
                a.Show();
            } 
            
                


                //mysql connection
                //string connectionString = @"Data Source=DESKTOP-T3I39VA\SQLEXPRESS;Initial Catalog=Food;Integrated Security=True";
                string connectionString = @"data source=DESKTOP-T3I39VA\SQLEXPRESS; database=Food; integrated security=SSPI";

            string query = "SELECT COUNT(*) FROM Hello WHERE Nam = @uname AND Pass = @pass";
            string query1 = "SELECT COUNT(*) FROM Hell WHERE Nam = @uname AND Pass = @pass";
            string query2 = "SELECT COUNT(*) FROM Delivery WHERE username = @uname AND password = @pass";
            string query3 = "SELECT COUNT(*) FROM Worker WHERE username = @uname AND password = @pass";
            string query4 = "SELECT COUNT(*) FROM ResReg WHERE username = @uname AND password = @pass";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters safely
                    command.Parameters.AddWithValue("@uname", uname);
                    command.Parameters.AddWithValue("@pass", pass);

                  

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Login successful! Diet User", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();

                        // If Form3 expects userId as int, parse it safely
                        // Form3 f3 = new Form3(int.Parse(userId));
                       
                        DietC d1= new DietC();
                        d1.Show();
                        return;
                    }
                   
                }
            

            //2nd query
            
                using (SqlCommand command = new SqlCommand(query1, connection))
                {
                    // Add parameters safely
                    command.Parameters.AddWithValue("@uname", uname);
                    command.Parameters.AddWithValue("@pass", pass);

                    

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Login successful! Regular User", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();

                        // If Form3 expects userId as int, parse it safely
                        // Form3 f3 = new Form3(int.Parse(userId));
                        RegularFormLogcs f4 = new RegularFormLogcs();
                        Restaurant r1= new Restaurant();
                        r1.Show();
                        return;
                    }
                    
                }

                //3rd

                using (SqlCommand command = new SqlCommand(query2, connection))
                {
                    // Add parameters safely
                    command.Parameters.AddWithValue("@uname", uname);
                    command.Parameters.AddWithValue("@pass", pass);



                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Login successful! Delivery User", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();

                        // If Form3 expects userId as int, parse it safely
                        // Form3 f3 = new Form3(int.Parse(userId));
                       Delivery d= new Delivery();
                        d.Show();
                        return;
                    }

                }


                //4th

                using (SqlCommand command = new SqlCommand(query3, connection))
                {
                    // Add parameters safely
                    command.Parameters.AddWithValue("@uname", uname);
                    command.Parameters.AddWithValue("@pass", pass);



                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Login successful! Worker User", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();

                        // If Form3 expects userId as int, parse it safely
                        // Form3 f3 = new Form3(int.Parse(userId));
                        Worker w= new Worker();
                        w.Show();
                        return;
                    }

                }

                //5th

                using (SqlCommand command = new SqlCommand(query4, connection))
                {
                    // Add parameters safely
                    command.Parameters.AddWithValue("@uname", uname);
                    command.Parameters.AddWithValue("@pass", pass);



                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Login successful! Resturant Owner User", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();

                        // If Form3 expects userId as int, parse it safely
                        // Form3 f3 = new Form3(int.Parse(userId));
                        OwnerForm w= new OwnerForm();
                        w.Show();
                        return;
                    }

                }
                MessageBox.Show("Invalid Name or Pass.", "Login Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

        
          
        }

    }
}

