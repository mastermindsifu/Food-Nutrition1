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
    public partial class Combo1 : UserControl
    {
        public event Action<string, decimal>? ItemAdded;
        public Combo1()
        {
            InitializeComponent();
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            ItemAdded?.Invoke(" Combo 1", 200);

        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            ItemAdded?.Invoke(" Combo 2", 199);
        }

        private void Combo1_Load(object sender, EventArgs e)
        {

        }


    }
}
