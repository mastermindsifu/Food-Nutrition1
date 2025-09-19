namespace WinFormsApp1
{
    partial class Restaurant
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            exitbutton = new Button();
            PizzaBurg = new Button();
            BurgerKing = new Button();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Chocolate;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(375, 752);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(191, 58);
            button1.TabIndex = 29;
            button1.Text = "back";
            button1.UseVisualStyleBackColor = false;
            // 
            // exitbutton
            // 
            exitbutton.BackColor = Color.Chocolate;
            exitbutton.Cursor = Cursors.Hand;
            exitbutton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitbutton.Location = new Point(918, 752);
            exitbutton.Margin = new Padding(4, 5, 4, 5);
            exitbutton.Name = "exitbutton";
            exitbutton.Size = new Size(191, 58);
            exitbutton.TabIndex = 28;
            exitbutton.Text = "Exit";
            exitbutton.UseVisualStyleBackColor = false;
            // 
            // PizzaBurg
            // 
            PizzaBurg.BackColor = Color.Transparent;
            PizzaBurg.Cursor = Cursors.Hand;
            PizzaBurg.Location = new Point(676, 484);
            PizzaBurg.Margin = new Padding(4, 5, 4, 5);
            PizzaBurg.Name = "PizzaBurg";
            PizzaBurg.Size = new Size(283, 38);
            PizzaBurg.TabIndex = 23;
            PizzaBurg.Text = "PizzaBurg";
            PizzaBurg.UseVisualStyleBackColor = false;
            PizzaBurg.Click += PizzaBurg_Click;
            // 
            // BurgerKing
            // 
            BurgerKing.BackColor = Color.Transparent;
            BurgerKing.Cursor = Cursors.Hand;
            BurgerKing.Location = new Point(281, 484);
            BurgerKing.Margin = new Padding(4, 5, 4, 5);
            BurgerKing.Name = "BurgerKing";
            BurgerKing.Size = new Size(274, 38);
            BurgerKing.TabIndex = 22;
            BurgerKing.Text = "BurgerKing";
            BurgerKing.UseVisualStyleBackColor = false;
            BurgerKing.Click += BurgerKing_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.WindowFrame;
            textBox1.ForeColor = SystemColors.InactiveBorder;
            textBox1.Location = new Point(192, 3);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(855, 36);
            textBox1.TabIndex = 21;
            textBox1.Text = "Choose Your Favorite Restaurant";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.pizza_3007395__480;
            pictureBox2.Location = new Point(676, 197);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(283, 203);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.The_Smokey_Burger;
            pictureBox1.Location = new Point(281, 197);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(274, 203);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // Restaurant
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 833);
            Controls.Add(button1);
            Controls.Add(exitbutton);
            Controls.Add(PizzaBurg);
            Controls.Add(BurgerKing);
            Controls.Add(textBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Restaurant";
            Text = "Restaurant";
            Load += Restaurant_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button exitbutton;
        private Button PizzaBurg;
        private Button BurgerKing;
        private TextBox textBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}