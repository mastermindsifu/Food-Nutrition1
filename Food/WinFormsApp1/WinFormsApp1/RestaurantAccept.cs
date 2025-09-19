using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static WinFormsApp1.KingBurger;

namespace WinFormsApp1
{
    public partial class RestaurantAccept : Form
    {
        public Form1 _mainForm;
        string connectionString = @"data source=DESKTOP-T3I39VA\SQLEXPRESS; database=Food; integrated security=SSPI";
        public RestaurantAccept()
        {
            InitializeComponent();
        }
        public RestaurantAccept(Form1 mainForm)
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



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM ResReg";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                dataGridView1.Rows.Clear();

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(
                        reader["username"],
                        reader["phone"],
                        reader["resturantname"],
                        reader["place"],
                        reader["date"],
                        reader["email"]
                    );
                }
            }
        }
    }
}
