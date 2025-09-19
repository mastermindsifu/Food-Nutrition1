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
    public partial class Sandwich1 : UserControl
    {
        public event Action<string, decimal>? ItemAdded;
        public Sandwich1()
        {
            InitializeComponent();
        }

        private void Sandwich1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            ItemAdded?.Invoke("Vegetable Sandwich", 150);
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            ItemAdded?.Invoke("Club Sandwich", 180);
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            ItemAdded?.Invoke("Chicken Sandwich", 200);
        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
