using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static WinFormsApp1.DietCart;

namespace WinFormsApp1
{
    public partial class KingBurger : Form
    {
        private List<CartItem> cart = new List<CartItem>();
        //public event Action<string, decimal>? ItemAdded;
        public KingBurger()
        {
            InitializeComponent();
        }


        public class Order
        {
            public string? Item { get; set; }
            public int Quantity { get; set; }
            public decimal Price { get; set; }
            public string DeliveryStatus { get; set; } = "Pending"; // default
            public string Status { get; set; } = "Pending"; // default
        }


        public static class OrderStore
        {
            public static List<Order> Orders = new List<Order>();
        }








        public class CartItem
        {
            public string? Iteam { get; set; }
            public int Quantity { get; set; }
            public decimal Price { get; set; }
            public decimal TotalPrice => Quantity * Price;

        }





        //Burger ADD Button
        private void Add1_Click(object sender, EventArgs e)
        {
            AddToCart("Crispy King", 389);


        }

        private void Add2_Click_1(object sender, EventArgs e)
        {
            AddToCart("Beef Burger", 389);

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            AddToCart("BBQ Burger", 300);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AddToCart("Chiken Burger", 250);

        }
        private void button3_Click(object sender, EventArgs e)
        {
            AddToCart("Smoky Burger", 250);

        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            AddToCart("Classic Burger", 220);
        }

        //Pizza with size selector
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

        //Sandwich ADD Button

        private void button11_Click_1(object sender, EventArgs e)
        {
            AddToCart("Vegetable Sandwich", 150);

        }
        private void button12_Click_1(object sender, EventArgs e)
        {
            AddToCart("Club Sandwich", 180);

        }
        private void button13_Click_1(object sender, EventArgs e)
        {
            AddToCart("Chicken Sandwich", 200);
        }

        //Salad ADD Button

        private void button14_Click_1(object sender, EventArgs e)
        {
            AddToCart("Special Salad", 250);
        }
        private void button15_Click_1(object sender, EventArgs e)
        {
            AddToCart("Diet Special Salad", 200);
        }
        private void button16_Click_1(object sender, EventArgs e)
        {
            AddToCart("Chicken Salad", 260);

        }
        private void button17_Click_1(object sender, EventArgs e)
        {
            AddToCart("Green Salad", 200);

        }

        //Combo ADD Button

        private void button18_Click_1(object sender, EventArgs e)
        {
            AddToCart(" Combo 1", 200);

        }
        private void button19_Click_1(object sender, EventArgs e)
        {
            AddToCart(" Combo 2", 199);

        }

        //Beverage ADD Button

        private void button20_Click_1(object sender, EventArgs e)
        {
            AddToCart("Drinks", 30);

        }
        private void button21_Click_1(object sender, EventArgs e)
        {
            AddToCart("Lacchi", 70);

        }
        private void button22_Click_1(object sender, EventArgs e)
        {
            AddToCart("Lemon Mint", 50);

        }






        //Pizza with size selector Function
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

        private void cartdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        //Clear, Order, Cancel, Exit Button


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

        private void orderbutton_Click_1(object sender, EventArgs e)
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
            MessageBox.Show("Order Canceled!", "Cancellation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            Restaurant res = new Restaurant();
            res.Show();
        }

        private void exitbutton_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            MessageBox.Show("Thank you for visiting us!", "Goodbye", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }


        //for SizeSelectorPizza

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

        private void button23_Click_1(object sender, EventArgs e)
        {
            Check statusForm = new Check();
            statusForm.Show();
            this.Hide();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            // OwnerForm ownerForm = new OwnerForm();
            //ownerForm.Show();
        }

        private void KingBurger_Load(object sender, EventArgs e)
        {

        }

        private void Burger_b_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            Burger1 burgerUC = new Burger1();


            burgerUC.ItemAdded += (itemName, price) =>
            {
                AddToCart((string)itemName, (decimal)price);
            };

            flowLayoutPanel1.Controls.Add(burgerUC);
        }

        private void Pizza_b_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            Pizza1 p1 = new Pizza1();


            p1.ItemAdded += (itemName, price) =>
            {
                AddToCart((string)itemName, (decimal)price);
            };

            flowLayoutPanel1.Controls.Add(p1);

        }

        private void San_b_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            Sandwich1 s1 = new Sandwich1();


            s1.ItemAdded += (itemName, price) =>
            {
                AddToCart((string)itemName, (decimal)price);
            };

            flowLayoutPanel1.Controls.Add(s1);

        }

        private void Sal_b_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            Salad1 s2 = new Salad1();


            s2.ItemAdded += (itemName, price) =>
            {
                AddToCart((string)itemName, (decimal)price);
            };

            flowLayoutPanel1.Controls.Add(s2);

        }

        private void Com_b_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            Combo1 c2 = new Combo1();


            c2.ItemAdded += (itemName, price) =>
            {
                AddToCart((string)itemName, (decimal)price);
            };

            flowLayoutPanel1.Controls.Add(c2);
        }

        private void Bev_b_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            Beverage1 b2 = new Beverage1();


            b2.ItemAdded += (itemName, price) =>
            {
                AddToCart((string)itemName, (decimal)price);
            };

            flowLayoutPanel1.Controls.Add(b2);
        }

        private void button24_Click_1(object sender, EventArgs e)
        {
            Delivery d = new Delivery();
            d.Show();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Worker w=new Worker();
            w.Show();
        }
    }
}
