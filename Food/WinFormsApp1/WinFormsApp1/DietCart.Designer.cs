namespace WinFormsApp1
{
    partial class DietCart
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
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            totallabel1 = new Label();
            textBox2 = new TextBox();
            cartdataGridView1 = new DataGridView();
            Iteam = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Cal = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)cartdataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = Color.LightGray;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(287, 784);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(151, 55);
            button4.TabIndex = 17;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.RosyBrown;
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(474, 784);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(154, 55);
            button3.TabIndex = 16;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleGreen;
            button2.Font = new Font("Rockwell", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(653, 784);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(169, 50);
            button2.TabIndex = 15;
            button2.Text = "Order";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(714, -2);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(107, 55);
            button1.TabIndex = 14;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonShadow;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(741, 678);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 32);
            label1.TabIndex = 13;
            label1.Text = "00 Cal";
            // 
            // totallabel1
            // 
            totallabel1.AutoSize = true;
            totallabel1.BackColor = SystemColors.AppWorkspace;
            totallabel1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totallabel1.Location = new Point(583, 679);
            totallabel1.Margin = new Padding(4, 0, 4, 0);
            totallabel1.Name = "totallabel1";
            totallabel1.Size = new Size(74, 31);
            totallabel1.TabIndex = 12;
            totallabel1.Text = "00 TK";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.DarkSalmon;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(474, 673);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(78, 39);
            textBox2.TabIndex = 11;
            textBox2.Text = "Total  =";
            // 
            // cartdataGridView1
            // 
            cartdataGridView1.BackgroundColor = Color.PeachPuff;
            cartdataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cartdataGridView1.Columns.AddRange(new DataGridViewColumn[] { Iteam, Quantity, Price, Cal });
            cartdataGridView1.Location = new Point(187, 61);
            cartdataGridView1.Margin = new Padding(4, 5, 4, 5);
            cartdataGridView1.Name = "cartdataGridView1";
            cartdataGridView1.RowHeadersWidth = 62;
            cartdataGridView1.Size = new Size(634, 593);
            cartdataGridView1.TabIndex = 10;
            // 
            // Iteam
            // 
            Iteam.DataPropertyName = "Iteam";
            Iteam.HeaderText = "Iteam";
            Iteam.MinimumWidth = 8;
            Iteam.Name = "Iteam";
            Iteam.ReadOnly = true;
            Iteam.Width = 150;
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 8;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.Width = 150;
            // 
            // Price
            // 
            Price.DataPropertyName = "Price";
            Price.HeaderText = "Price";
            Price.MinimumWidth = 8;
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Width = 150;
            // 
            // Cal
            // 
            Cal.DataPropertyName = "Cal";
            Cal.HeaderText = "Cal";
            Cal.MinimumWidth = 8;
            Cal.Name = "Cal";
            Cal.ReadOnly = true;
            Cal.Width = 150;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DarkSalmon;
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(321, -4);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(305, 45);
            textBox1.TabIndex = 9;
            textBox1.Text = "Your Cart";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // DietCart
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 899);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(totallabel1);
            Controls.Add(textBox2);
            Controls.Add(cartdataGridView1);
            Controls.Add(textBox1);
            Name = "DietCart";
            Text = "DietCart";
            Load += DietCart_Load;
            ((System.ComponentModel.ISupportInitialize)cartdataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private Label totallabel1;
        private TextBox textBox2;
        private DataGridView cartdataGridView1;
        private DataGridViewTextBoxColumn Iteam;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Cal;
        private TextBox textBox1;
    }
}