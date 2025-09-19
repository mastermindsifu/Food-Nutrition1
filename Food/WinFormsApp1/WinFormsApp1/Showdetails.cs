using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WinFormsApp1
{
    public partial class Showdetails : Form
    {
        private double salaryLimit;
        private double targetCalories; 

        public Showdetails(string name, string email, string phone, string password,
        string salary, string height, string weight, string gender, string goal, string age, double bmi, double targetCalories, double protein, double carbs, double fats)
        {
            InitializeComponent();
            label1.Text = "Name: " + name;
            label2.Text = "Email: " + email;
            label3.Text = "Phone: " + phone;
            label4.Text = "Password: " + password;
            label5.Text = "Salary: " + salary;
            label6.Text = "Height: " + height;
            label7.Text = "Weight: " + weight;
            label8.Text = "Gender: " + gender;
            label9.Text = "Goal: " + goal;
            label10.Text = "age: " + age;
            label11.Text = "Your Bmi: " + bmi;
            label12.Text = "Your Calories: " + targetCalories;
            label13.Text = "Your Protein: " + protein;
            label14.Text = "Your Carbs: " + carbs;
            label15.Text = "Your Fats: " + fats;

            double.TryParse(salary, out double sal);
            salaryLimit = sal * 0.05;


        }




        public void UpdateDisplay(double calories, double amount, double salary)
        {
            labelTotalCalories.Text = "Total Calories: " + calories;
            labelTotalPrice.Text = "Total Amount: " + amount + " Taka";

            double salaryLimit = salary * 0.05;
            double almostCalorieLimit = targetCalories * 0.7; // 70% warning

            // Calories warnings
            if (calories >= almostCalorieLimit && calories < targetCalories)
            {
                labelCalorieWarning.Text = "You are getting close to your target calories!";
                labelCalorieWarning.ForeColor = Color.Orange;
            }
            else if (calories >= targetCalories)
            {
                labelCalorieWarning.Text = "Cannot exceed target calories!";
                labelCalorieWarning.ForeColor = Color.Red;
            }
            else
            {
                labelCalorieWarning.Text = "";
            }

            // Salary warnings
            if (amount >= 0.9 * salaryLimit && amount < salaryLimit)
            {
                labelSalaryWarning.Text = "You are almost at salary limit!";
                labelSalaryWarning.ForeColor = Color.Orange;
            }
            else if (amount >= salaryLimit)
            {
                labelSalaryWarning.Text = "Cannot exceed 5% of Salary!";
                labelSalaryWarning.ForeColor = Color.Red;
            }
            else
            {
                labelSalaryWarning.Text = "";
            }
        }




        private void Showdetails_Load(object sender, EventArgs e)
        {

        }

        private void labelTotalCalories_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
