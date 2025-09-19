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
    public partial class Delivery : Form
    {
        public Form1 _mainForm;
        public Delivery()
        {
            InitializeComponent();

        }
        public Delivery(Form1 mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }
        private void OrderStatusForm_Load(object sender, EventArgs e)
        {
            RefreshOrders();
        }

        private void RefreshOrders()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = OrderStore.Orders
                .Select(o => new { o.Item, o.Quantity, o.Price, o.DeliveryStatus })
                .ToList();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int index = dataGridView1.CurrentRow.Index;
                OrderStore.Orders[index].DeliveryStatus = "Accepted";
                RefreshOrders();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int index = dataGridView1.CurrentRow.Index;
                OrderStore.Orders[index].DeliveryStatus = "Rejected";
                RefreshOrders();
            }
        }
        private void Delivery_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
