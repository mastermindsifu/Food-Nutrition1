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
    public partial class ShowRest : Form
    {

        private double salaryLimit;
        private double targetCalories;
        public ShowRest()
        {
            InitializeComponent();
            label1.Text = "Total Calories: " + salaryLimit;
        }
        public void UpdateDisplay(double calories, double amount, double targetCalories, double salaryLimit)
        {
            // Update totals
            labelTotalCalories.Text = "Total Calories: " + calories;
            labelTotalPrice.Text = "Total Amount: " + amount + " Taka";

            double almostCalorieLimit = targetCalories * 0.7;
            double almostSalaryLimit = salaryLimit * 0.7;

            // --- Calories warnings ---
            if (calories >= targetCalories)
            {
                labelCalorieWarning.Text = "❌ Cannot exceed target calories!";
                labelCalorieWarning.ForeColor = Color.Red;
            }
            else if (calories >= almostCalorieLimit)
            {
                labelCalorieWarning.Text = "⚠️ You are getting close to your target calories!";
                labelCalorieWarning.ForeColor = Color.Orange;
            }
            else
            {
                labelCalorieWarning.Text = "";
            }

            // --- Salary warnings ---
            if (amount >= salaryLimit)
            {
                labelSalaryWarning.Text = "❌ Cannot exceed salary limit!";
                labelSalaryWarning.ForeColor = Color.Red;
            }
            else if (amount >= almostSalaryLimit)
            {
                labelSalaryWarning.Text = "⚠️ You are almost at salary limit!";
                labelSalaryWarning.ForeColor = Color.Orange;
            }
            else
            {
                labelSalaryWarning.Text = "";
            }
        }

        private void ShowRest_Load(object sender, EventArgs e)
        {

        }

        private void labelCalorieWarning_Click(object sender, EventArgs e)
        {

        }
    }
}
