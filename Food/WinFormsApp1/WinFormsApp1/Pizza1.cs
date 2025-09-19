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
    public partial class Pizza1 : UserControl
    {
        public event Action<string, decimal>? ItemAdded;
        public Pizza1()
        {


            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button5_Click_1(object sender, EventArgs e)
        {

            select("Margherita", 250);
        }


        //Size selector







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


        //Size selector


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
                ItemAdded?.Invoke(name + " " + size, a);
            }
            else if (size == "Small")
            {
                MessageBox.Show("You selected a " + size + "Pizza ", "Pizza Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ItemAdded?.Invoke(name + " " + size, a + 100);
            }
            else if (size == "Medium")
            {
                MessageBox.Show("You selected a " + size + "Pizza ", "Pizza Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ItemAdded?.Invoke(name + " " + size, a + 150);
            }
            else if (size == "Large")
            {
                MessageBox.Show("You selected a " + size + "Pizza ", "Pizza Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ItemAdded?.Invoke(name + " " + size, a + 200);
            }
            else
            {
                MessageBox.Show("Invalid size selected.");
                return;

            }

        }




        //Select size dialog

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


    }
}
