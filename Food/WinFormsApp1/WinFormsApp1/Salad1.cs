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
    public partial class Salad1 : UserControl
    {
        public event Action<string, decimal>? ItemAdded;
        public Salad1()
        {
            InitializeComponent();
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            ItemAdded?.Invoke("Special Salad", 250);
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            ItemAdded?.Invoke("Diet Special Salad", 200);
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            ItemAdded?.Invoke("Chicken Salad", 260);
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            ItemAdded?.Invoke("Green  Salad", 200);
        }


        private void Salad1_Load(object sender, EventArgs e)
        {

        }


    }
}
