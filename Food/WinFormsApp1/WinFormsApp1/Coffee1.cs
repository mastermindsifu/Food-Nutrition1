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
    public partial class Coffee1 : UserControl
    {
        public event Action<string, decimal>? ItemAdded;
        public Coffee1()
        {
            InitializeComponent();
        }





        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            ItemAdded?.Invoke(" Clod Coffe ", 200);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ItemAdded?.Invoke(" Hot Coffe ", 70);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            ItemAdded?.Invoke(" Lacchi ", 70);
        }
    }
}
