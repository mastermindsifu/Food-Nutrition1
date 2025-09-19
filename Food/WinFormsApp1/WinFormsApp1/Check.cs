using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WinFormsApp1.KingBurger;

namespace WinFormsApp1
{
    public partial class Check : Form
    {
        public Check()
        {
            InitializeComponent();
        }
        private void Check_Load(object sender, EventArgs e)
        {
            RefreshOrders();
        }
        private void RefreshOrders()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = OrderStore.Orders
                .Select(o => new { o.Item, o.Quantity, o.Price, o.Status })
                .ToList();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RefreshOrders();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            KingBurger kb = new KingBurger();
            kb.Show();
            this.Hide();
        }


    }
}
