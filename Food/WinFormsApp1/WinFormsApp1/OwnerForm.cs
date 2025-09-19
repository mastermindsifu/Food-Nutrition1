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
    public partial class OwnerForm : Form
    {
        public OwnerForm()
        {
            InitializeComponent();
        }


        private void OrderStatusForm_Load(object sender, EventArgs e)
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
            if (dataGridView1.CurrentRow != null)
            {
                int index = dataGridView1.CurrentRow.Index;
                OrderStore.Orders[index].Status = "Accepted";
                RefreshOrders();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int index = dataGridView1.CurrentRow.Index;
                OrderStore.Orders[index].Status = "Rejected";
                RefreshOrders();

            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            RefreshOrders();
        }


        private void OwnerForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Worker worker = new Worker();
            worker.Show();
            Delivery d = new Delivery();
            d.Show();



        }

        private void Refresh_Click(object sender, EventArgs e)
        {

        }
    }
}
