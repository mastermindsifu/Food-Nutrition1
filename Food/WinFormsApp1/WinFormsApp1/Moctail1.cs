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
    public partial class Moctail1 : UserControl
    {
        public event Action<string, decimal>? ItemAdded;
        public Moctail1()
        {
            InitializeComponent();
        }









        private void Moctail1_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            ItemAdded?.Invoke(" Ice Tea ", 150);

        }

        private void button14_Click(object sender, EventArgs e)
        {
            ItemAdded?.Invoke(" Blue Moctail ", 150);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            ItemAdded?.Invoke(" Lemon Mint ", 50);
        }
    }
}
