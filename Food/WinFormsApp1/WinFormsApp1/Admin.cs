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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Deliveryman D = new Deliveryman();
            D.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Customerinfo customerinfo = new Customerinfo();
            customerinfo.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            RestaurantInfos R = new RestaurantInfos();
            R.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RestaurantAccept r=new RestaurantAccept();
            r.Show();
        }
    }
}

       
    

