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
    public partial class Restaurant : Form
    {
        public Restaurant()
        {
            InitializeComponent();
        }

        private void Restaurant_Load(object sender, EventArgs e)
        {

        }

        private void BurgerKing_Click(object sender, EventArgs e)
        {

             KingBurger bk = new KingBurger();
              bk.Show();
        }

        private void PizzaBurg_Click(object sender, EventArgs e)
        {
            PizzaBurg pb = new PizzaBurg();
            pb.Show();
        }
    }
}
