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
    
    public partial class Burger1 : UserControl
    {
        internal Action<object, object> ItemAdded;

        public Burger1()
        {
            InitializeComponent();
        }

        private void Burger1_Load(object sender, EventArgs e)
        {

        }
        private void Add1_Click_1(object sender, EventArgs e)
        {
            ItemAdded?.Invoke("Crispy King", 389);
        }

        private void Add2_Click_1(object sender, EventArgs e)
        {
            ItemAdded?.Invoke("Beef Burger", 389);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ItemAdded?.Invoke("BBQ Burger", 300);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ItemAdded?.Invoke("Chicken Burger", 250);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ItemAdded?.Invoke("Smoky Burger", 250);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ItemAdded?.Invoke("Classic Burger", 220);
        }
    }
}
