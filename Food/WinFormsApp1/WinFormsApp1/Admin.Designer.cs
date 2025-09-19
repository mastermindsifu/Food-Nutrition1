namespace WinFormsApp1
{
    partial class Admin
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
            button1 = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label3 = new Label();
            panel2 = new Panel();
            button5 = new Button();
            button3 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(64, 64, 64);
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(1021, 556);
            button4.Name = "button4";
            button4.Size = new Size(348, 158);
            button4.TabIndex = 6;
            button4.Text = "Deliveryman infos";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(396, 567);
            button1.Name = "button1";
            button1.Size = new Size(377, 147);
            button1.TabIndex = 7;
            button1.Text = "Restaurant Requests";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(255, 128, 0);
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Location = new Point(1021, 207);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(339, 150);
            flowLayoutPanel2.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(188, 40);
            label2.TabIndex = 0;
            label2.Text = "Name: Admin";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(128, 255, 128);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Location = new Point(396, 198);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(364, 150);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(361, 150);
            label3.TabIndex = 1;
            label3.Text = "Customer infos";
            label3.Click += label3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 133);
            panel2.Name = "panel2";
            panel2.Size = new Size(289, 777);
            panel2.TabIndex = 5;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(64, 64, 64);
            button5.BackgroundImageLayout = ImageLayout.None;
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(75, 358);
            button5.Name = "button5";
            button5.Size = new Size(191, 57);
            button5.TabIndex = 3;
            button5.Text = "About";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(64, 64, 64);
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(75, 225);
            button3.Name = "button3";
            button3.Size = new Size(191, 57);
            button3.TabIndex = 1;
            button3.Text = "Restaurants";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(64, 64, 64);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(75, 74);
            button2.Name = "button2";
            button2.Size = new Size(191, 66);
            button2.TabIndex = 0;
            button2.Text = "Dashboard";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1589, 133);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 41);
            label1.Name = "label1";
            label1.Size = new Size(290, 46);
            label1.TabIndex = 0;
            label1.Text = "Admin Dashboard";
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1589, 910);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Admin";
            Text = "Admin";
            Load += Admin_Load;
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button4;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label3;
        private Panel panel2;
        private Button button5;
        private Button button3;
        private Button button2;
        private Panel panel1;
        private Label label1;
    }
}