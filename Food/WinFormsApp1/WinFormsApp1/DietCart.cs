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
    public partial class DietCart : Form
    {
        public static List<CartItem> cart = new List<CartItem>();
        public DietCart()
        {
            InitializeComponent();
        }

        public class CartItem
        {
            public string? Iteam { get; set; }
            public int Quantity { get; set; }
            public decimal Price { get; set; }
            public decimal Cal { get; set; }
            public decimal TotalPrice => Quantity * Price;

            public decimal totalCal => Quantity * Cal;

        }

        public static void AddToCart(string itemName, decimal price, decimal cal)
        {
            var item = cart.FirstOrDefault(i => i.Iteam == itemName);
            if (item != null)
                item.Quantity++;
            else
                cart.Add(new CartItem { Iteam = itemName, Quantity = 1, Price = price, Cal = cal });

        }
        private void UpdateCartDisplay()
        {
            cartdataGridView1.DataSource = null;
            cartdataGridView1.DataSource = cart.Select(i => new
            {
                Iteam = i.Iteam,
                Quantity = "x" + i.Quantity,
                Price = i.TotalPrice,
                Cal = i.totalCal


            }).ToList();
            decimal grandTotal = cart.Sum(i => i.TotalPrice);
            totallabel1.Text = grandTotal.ToString("F2") + "Tk";
            decimal totalCal = cart.Sum(i => i.totalCal);
            label1.Text = totalCal.ToString("F3") + "Cal";
        }








        private void DietCart_Load(object sender, EventArgs e)
        {

            UpdateCartDisplay();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (cart.Count == 0)
            {
                MessageBox.Show("Your cart is already empty!", "Cancellation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                cart.Clear();
                UpdateCartDisplay();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DietC d = new DietC();
            d.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            MessageBox.Show("Thank you for visiting us!", "Goodbye", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }

       
    }

