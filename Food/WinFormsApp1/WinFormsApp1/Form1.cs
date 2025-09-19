using System.Security.Cryptography.Xml;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {




        public Form1()
        {
            InitializeComponent();
        }
        public void OpenFormInPanel(Form formToOpen)
        {
            // Clear previous controls
            panelContainer.Controls.Clear();

            // Make the form behave like a control
            formToOpen.TopLevel = false;
            formToOpen.FormBorderStyle = FormBorderStyle.None;
            formToOpen.Dock = DockStyle.Fill;

            // Add it into the panel
            panelContainer.Controls.Add(formToOpen);
            formToOpen.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFormInPanel(new Login());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegisterRowner registerRowner = new RegisterRowner();
            registerRowner.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new SignUp(this));

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new DeliveryReg(this));

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new WorkerRegcs(this));
            

        }
    }
}
