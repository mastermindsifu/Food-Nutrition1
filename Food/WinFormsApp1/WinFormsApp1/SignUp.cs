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

    public partial class SignUp : Form
    {

        public Form1 _mainForm;
        public SignUp(Form1 mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }
     


        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _mainForm.OpenFormInPanel(new Form2());
        }

        private void Diet_Click(object sender, EventArgs e)
        {
            _mainForm.OpenFormInPanel(new diet());

        }
    }
}
