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
    public partial class Beverage1 : UserControl
    {

        public event Action<string, decimal>? ItemAdded;
        public Beverage1()
        {
            InitializeComponent();
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            ItemAdded?.Invoke("Drinks", 30);
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            ItemAdded?.Invoke("Lacchi", 70);
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            ItemAdded?.Invoke("Lemon Mint", 50);
        }


        private void Beverage1_Load(object sender, EventArgs e)
        {

        }


    }
}
