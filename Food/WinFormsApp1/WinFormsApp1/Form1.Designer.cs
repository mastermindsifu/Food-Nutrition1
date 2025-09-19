namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            mainpanel = new Panel();
            button4 = new Button();
            button3 = new Button();
            pictureBox3 = new PictureBox();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            panelContainer = new Panel();
            button5 = new Button();
            mainpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // mainpanel
            // 
            mainpanel.BackColor = Color.FromArgb(51, 51, 76);
            mainpanel.Controls.Add(button5);
            mainpanel.Controls.Add(button4);
            mainpanel.Controls.Add(button3);
            mainpanel.Controls.Add(pictureBox3);
            mainpanel.Controls.Add(button2);
            mainpanel.Controls.Add(pictureBox2);
            mainpanel.Controls.Add(button1);
            mainpanel.Controls.Add(pictureBox1);
            mainpanel.Dock = DockStyle.Left;
            mainpanel.Location = new Point(0, 129);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(300, 837);
            mainpanel.TabIndex = 0;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ActiveCaption;
            button4.Location = new Point(111, 526);
            button4.Name = "button4";
            button4.Size = new Size(183, 69);
            button4.TabIndex = 6;
            button4.Text = "DeliveryReg";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ActiveCaption;
            button3.Location = new Point(111, 405);
            button3.Name = "button3";
            button3.Size = new Size(183, 69);
            button3.TabIndex = 5;
            button3.Text = "Open Resturant";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 405);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(133, 68);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ActiveCaption;
            button2.Location = new Point(117, 276);
            button2.Name = "button2";
            button2.Size = new Size(183, 69);
            button2.TabIndex = 3;
            button2.Text = "Sign Up";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 276);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(133, 68);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaption;
            button1.Location = new Point(111, 141);
            button1.Name = "button1";
            button1.Size = new Size(183, 69);
            button1.TabIndex = 1;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 141);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(39, 39, 58);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1657, 129);
            panel1.TabIndex = 0;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(35, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(126, 102);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveBorder;
            label1.Location = new Point(167, 41);
            label1.Name = "label1";
            label1.Size = new Size(461, 35);
            label1.TabIndex = 0;
            label1.Text = "Welcome To Food Nutrition";
            // 
            // panelContainer
            // 
            panelContainer.BackColor = SystemColors.ActiveBorder;
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(300, 129);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1357, 837);
            panelContainer.TabIndex = 1;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ActiveCaption;
            button5.Location = new Point(111, 648);
            button5.Name = "button5";
            button5.Size = new Size(183, 69);
            button5.TabIndex = 7;
            button5.Text = "WorkerReg";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1657, 966);
            Controls.Add(panelContainer);
            Controls.Add(mainpanel);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            mainpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainpanel;
        private Button button1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button3;
        private PictureBox pictureBox3;
        private Button button2;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox4;
        private Panel panelContainer;
        private Button button4;
        private Button button5;
    }
}
