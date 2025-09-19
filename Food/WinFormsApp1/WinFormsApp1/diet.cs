
using System.Data.SqlClient;
using System;
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
    public partial class diet : Form
    {

        private double totalCalories = 0;
        private double totalAmount = 0;
        private Showdetails f2; // reference to the details form
        public DietC d1;
        private double salaryValue = 0;
        double targetCalories = 0;

        public diet()
        {
            InitializeComponent();
        }

        private void diet_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = richTextBox1.Text;
            string email = richTextBox2.Text;
            string phone = richTextBox3.Text;
            string Password = richTextBox4.Text;
            string salary = richTextBox5.Text;
            string height = richTextBox6.Text;
            string weight = richTextBox7.Text;
            string gender = groupBox1.Text;
            string age = richTextBox8.Text;
            string goal;
            int genderFactor;


            //checks male or female
            if (radioButton4.Checked)
            {
                gender = radioButton4.Text;
                genderFactor = 5;
            }
            else
            {
                gender = radioButton2.Text;
                genderFactor = -161;
            }



            if (!double.TryParse(height, out double Height) ||
                !double.TryParse(weight, out double Weight) ||
                !int.TryParse(age, out int Age) ||
                !double.TryParse(salary, out salaryValue))
            {
                MessageBox.Show("Please enter valid numeric values for height, weight, age, and salary.");
                return;
            }

            //BMI Calculation
            double heightBMI = Height / 100.0;
            double bmi = Weight / (heightBMI * heightBMI);

            //BMR Calculation

            double bmr = (10 * Weight) + (6.25 * Height) - (5 * Age) + genderFactor;
            double tdee = bmr * 1.2; // sedentary multiplier


            //gives calories
            if (radioButton1.Checked)
            {
                goal = radioButton1.Text;
                targetCalories = tdee + 500;
            }
            else
            {
                goal = radioButton3.Text;
                targetCalories = tdee - 500;
            }


            double proteinGrams = Weight * 1.8;
            double proteinCals = proteinGrams * 4;
            double fatCals = targetCalories * 0.25;
            double fatGrams = fatCals / 9;
            double carbCals = targetCalories - (proteinCals + fatCals);
            double carbGrams = carbCals / 4;

            
                double salaryValue1 = salaryValue *0.05;
            

            //side panel showdetails
            f2 = new Showdetails(name, email, phone, Password, salary, height, weight, gender, goal, age, bmi, targetCalories, proteinGrams, carbGrams, fatGrams);
            //side panel showdetails
            // Make it a child and remove borders
            f2.TopLevel = false;
            f2.FormBorderStyle = FormBorderStyle.None;
            f2.Dock = DockStyle.Fill;

            // Add into right side panel
            panel1.Controls.Clear();  // remove previous content if any
            panel1.Controls.Add(f2);
            f2.Show();
            UpdateDetails();
            //reff diet c
            //d1 = new DietC(salaryValue1, targetCalories);
            UpdateDetails();
            // inside button1_Click after calculations
           
            d1 = new DietC(salaryValue1, targetCalories);


            // open DietC form with the calculated limits
            d1 = new DietC(salaryValue1, targetCalories);
            d1.Show();
            this.Hide(); // optional if you don’t want both open


            //sql connection
            string connectionString = @"data source=DESKTOP-T3I39VA\SQLEXPRESS; database=Food; integrated security=SSPI";
            string query = "INSERT INTO Hello (Nam,Email,PhoneNo,Pass,Salary,Height,Weight,Gender) VALUES (@name, @email, @phone, @Password,@salary,@height,@weight,@gender)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@phone", phone);
                command.Parameters.AddWithValue("@Password", Password);
                command.Parameters.AddWithValue("@salary", salary);
                command.Parameters.AddWithValue("@height", height);
                command.Parameters.AddWithValue("@weight", weight);
                command.Parameters.AddWithValue("@gender", gender);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Profile created successfully!", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    /* this.Hide();
                     Form1 f1 = new Form1();
                     f1.Show();*/
                }
                else
                {
                    MessageBox.Show("Failed to create the profile. Please try again.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void UpdateDetails()
        {
            if (f2 != null)
            {
                f2.UpdateDisplay(totalCalories, totalAmount, salaryValue);

            }


        }



        /*private void AddCalories_Click(object sender, EventArgs e)
        {
            double nextCalories = totalCalories + 400; // each click adds 400 calories
            double almostLimit = targetCalories * 0.9;

            if (nextCalories > targetCalories)
            {

                MessageBox.Show("You have reached your target calories! Cannot add more.");
                AddCalories.Enabled = false;
                return;
            }

            totalCalories = nextCalories;
            UpdateDetails();

            if (totalCalories >= targetCalories)
            {
                MessageBox.Show("You have reached your target calories!");
                AddCalories.Enabled = false;
            }
            else if (totalCalories >= almostLimit)
            {
                MessageBox.Show("You are getting close to your target calories!");
            }
            
        }




      

        

private void button2_Click(object sender, EventArgs e)
        {

            double salaryLimit = 0;
            if (double.TryParse(richTextBox5.Text, out double salary))
                salaryLimit = salary * 0.05;

            double nextAmount = totalAmount + 500;

            if (nextAmount > salaryLimit)
            {
                MessageBox.Show(" Cannot add more amount! Salary limit reached.");
                return;
            }

            totalAmount = nextAmount;
            UpdateDetails();
            
        }*/

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
