using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WinFormsApp1.KingBurger;

namespace WinFormsApp1
{
    public partial class PizzaBurg : Form
    {
        private List<CartItem> cart = new List<CartItem>();
        public PizzaBurg()
        {
            InitializeComponent();
        }

        public class CartItem
        {
            public string? Iteam { get; set; }
            public int Quantity { get; set; }
            public decimal Price { get; set; }
            public decimal TotalPrice => Quantity * Price;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }








        //Add to cart and update display


        private void AddToCart(string itemName, decimal price)
        {
            var item = cart.FirstOrDefault(i => i.Iteam == itemName);
            if (item != null)
                item.Quantity++;
            else
                cart.Add(new CartItem { Iteam = itemName, Quantity = 1, Price = price });
            UpdateCartDisplay();
        }
        private void UpdateCartDisplay()
        {
            cartdataGridView1.DataSource = null;
            cartdataGridView1.DataSource = cart.Select(i => new
            {
                Iteam = i.Iteam,
                Quantity = "x" + i.Quantity,
                Price = i.TotalPrice,


            }).ToList();
            decimal grandTotal = cart.Sum(i => i.TotalPrice);
            totallabel1.Text = grandTotal.ToString("F2") + "Tk";
        }

        public static string? ShowSizeSelectionDialog()
        {
            Form prompt = new Form()
            {
                Width = 200,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterScreen,
                Text = "Select Pizza Size"
            };

            ComboBox comboBox = new ComboBox() { Left = 20, Top = 20, Width = 140 };
            comboBox.Items.AddRange(new string[] { "Regular", "Small", "Medium", "Large" });
            comboBox.SelectedIndex = 0;

            Button confirmation = new Button() { Text = "Ok", Left = 50, Width = 70, Top = 60, DialogResult = DialogResult.OK };
            prompt.Controls.Add(comboBox);
            prompt.Controls.Add(confirmation);

            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? comboBox.SelectedItem?.ToString() : null;
        }




        public void select(string name, decimal a)
        {
            string? size = ShowSizeSelectionDialog();
            if (string.IsNullOrEmpty(size))
            {
                MessageBox.Show("No size selected.");
                return;
            }
            else if (size == "Regular")
            {

                MessageBox.Show("You selected a " + size + "Pizza ", "Pizza Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddToCart(name + " " + size, a);
            }
            else if (size == "Small")
            {
                MessageBox.Show("You selected a " + size + "Pizza ", "Pizza Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddToCart(name + " " + size, a + 100);
            }
            else if (size == "Medium")
            {
                MessageBox.Show("You selected a " + size + "Pizza ", "Pizza Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddToCart(name + " " + size, a + 150);
            }
            else if (size == "Large")
            {
                MessageBox.Show("You selected a " + size + "Pizza ", "Pizza Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddToCart(name + " " + size, a + 200);
            }
            else
            {
                MessageBox.Show("Invalid size selected.");
                return;

            }

        }






        private void button5_Click_1(object sender, EventArgs e)
        {
            select("Margarita", 250);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            select("Beef Pizza", 300);
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            select("Vegetable Pizza", 280);
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            select("BBQ Chicken Pizza", 290);
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            select("Classic Cheese Pizza", 200);
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            select("Regular Cheese Pizza", 270);
        }

        //Combo
        private void button12_Click_1(object sender, EventArgs e)
        {
            AddToCart("Combo", 780);
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            AddToCart("Combo 1", 200);
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            AddToCart("Combo 2", 199);
        }

        //Moctail
        private void button13_Click_1(object sender, EventArgs e)
        {
            AddToCart("Ice Tea", 150);
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            AddToCart("Blue Moctail", 100);
        }
        private void button22_Click_1(object sender, EventArgs e)
        {
            AddToCart("Lemon Mint", 70);
        }

        //Coffee

        private void button15_Click_1(object sender, EventArgs e)
        {
            AddToCart("Cold Coffee", 200);

        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            AddToCart("Hot Coffee", 70);
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            AddToCart("Lacchi", 700);
        }

        //Clear cart
        private void clearButton_Click(object sender, EventArgs e)
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

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            Restaurant restaurantForm = new Restaurant();
            restaurantForm.Show();
            this.Hide();
        }

        private void Pizza_b_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            Pizza1 pizza = new Pizza1();
            pizza.ItemAdded += (itemName, price) =>
            {
                AddToCart(itemName, price);
            };
            flowLayoutPanel1.Controls.Add(pizza);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clearButton_Click_1(object sender, EventArgs e)
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

        private void orderbutton_Click(object sender, EventArgs e)
        {
            if (cart.Count == 0)
            {
                MessageBox.Show("Your cart is empty!", "Order Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for (int i = 0; i < cart.Count; i++)
            {
                CartItem? c = cart[i];
                OrderStore.Orders.Add(new Order
                {
                    Item = c.Iteam,
                    Quantity = c.Quantity,
                    Price = c.TotalPrice,
                    Status = "Pending"
                });

            }
            cart.Clear();
            UpdateCartDisplay();

            MessageBox.Show("Your order has been sent to the restaurant!\nPlease wait for confirmation.");
        }

        private void cancelbutton_Click_1(object sender, EventArgs e)
        {
            Restaurant restaurant = new Restaurant();
            restaurant.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Check statusForm = new Check();
            statusForm.Show();
            this.Hide();
        }

        private void Pizza_b_Click_1(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            Pizza1 p1 = new Pizza1();


            p1.ItemAdded += (itemName, price) =>
            {
                AddToCart((string)itemName, (decimal)price);
            };

            flowLayoutPanel1.Controls.Add(p1);
        }

        private void Com_b_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            Combo2 com1 = new Combo2();


            com1.ItemAdded += (itemName, price) =>
            {
                AddToCart((string)itemName, (decimal)price);
            };

            flowLayoutPanel1.Controls.Add(com1);
        }

        private void Bev_b_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            Coffee1 co1 = new Coffee1();


            co1.ItemAdded += (itemName, price) =>
            {
                AddToCart((string)itemName, (decimal)price);
            };

            flowLayoutPanel1.Controls.Add(co1);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            Moctail1 m1 = new Moctail1();


            m1.ItemAdded += (itemName, price) =>
            {
                AddToCart((string)itemName, (decimal)price);
            };

            flowLayoutPanel1.Controls.Add(m1);
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
    }
}
