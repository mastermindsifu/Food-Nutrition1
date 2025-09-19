using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp1
{
    public partial class DietC : Form
    {
        private ShowRest s1;
        private double salaryLimit = 800;
        private double calorieLimit = 900;
        private double totalCalories = 0;
        private double totalAmount = 0;
        public DietC()
        {
            InitializeComponent();
        }
        public DietC(double salaryLimit, double calorieLImit)
        {
            InitializeComponent();
            this.salaryLimit = salaryLimit;
            this.calorieLimit = calorieLImit;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            DietCart d = new DietCart();
            d.Show();
            this.Hide();
        }


        
       

        private void button1_Click(object sender, EventArgs e)
        {
            DietCart.AddToCart("Protein Shake", 300, 110);
            MessageBox.Show("Item Added to Cart");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DietCart.AddToCart("Soup", 250, 90);
            MessageBox.Show("Item Added to Cart");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DietCart.AddToCart(" Fruits Salad", 280, 80);
            MessageBox.Show("Item Added to Cart");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DietCart.AddToCart("Grild chicken", 220, 150);
            MessageBox.Show("Item Added to Cart");

        }

        private void button11_Click(object sender, EventArgs e)
        {
            DietCart.AddToCart("Vegetable Sandwich", 150, 50);
            MessageBox.Show("Item Added to Cart");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DietCart.AddToCart("Club sandwich", 180, 40);
            MessageBox.Show("Item Added to Cart");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DietCart.AddToCart("Chicken sandwich", 200, 60);
            MessageBox.Show("Item Added to Cart");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            DietCart.AddToCart("Special Salad", 250, 70);
            MessageBox.Show("Item Added to Cart");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DietCart.AddToCart("Diet Special Salad ", 200, 150);
            MessageBox.Show("Item Added to Cart");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            DietCart.AddToCart("Chicken Salad", 260, 120);
            MessageBox.Show("Item Added to Cart");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            DietCart.AddToCart("Green  Salad", 200, 99);
            MessageBox.Show("Item Added to Cart");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            DietCart.AddToCart("Lemon Mint", 50, 20);
            MessageBox.Show("Item Added to Cart");
        }



        private void DietC_Load(object sender, EventArgs e)
        {

        }

        private void Add1_Click_1(object sender, EventArgs e)
        {



            totalCalories += 155;
            totalAmount += 200;

            s1 = new ShowRest();
            // Make it a child and remove borders
            s1.TopLevel = false;
            s1.FormBorderStyle = FormBorderStyle.None;
            s1.Dock = DockStyle.Fill;

            // Add into right side panel
            panel3.Controls.Clear();  // remove previous content if any
            panel3.Controls.Add(s1);
            s1.Show();
            s1.UpdateDisplay(totalCalories, totalAmount, calorieLimit, salaryLimit);


            if (totalCalories > calorieLimit)
            {

                MessageBox.Show("You have reached your target calories!");
                Add1.Enabled = false;
                return;

            }


            calorieLimit = totalCalories;
            UpdateDetails();

            if (totalAmount > salaryLimit)
            {

                MessageBox.Show("You have reached your target salary limit!");
                Add1.Enabled = false;

            }




            DietCart.AddToCart("Kaju Badam", 200, 155);

            MessageBox.Show("Item Added to Cart");
        }
        private void UpdateDetails()
        {
            if (s1 != null)
            {
                s1.UpdateDisplay(totalCalories, totalAmount, calorieLimit, salaryLimit);
            }
        }

        private void Add2_Click_1(object sender, EventArgs e)
        {
            DietCart.AddToCart("Dragon Fruits", 389, 55);
            MessageBox.Show("Item Added to Cart");
        }
    }
}
