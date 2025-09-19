namespace WinFormsApp1
{
    partial class RestaurantAccept
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
            dataGridView1 = new DataGridView();
            button3 = new Button();
            username = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            restaurantname = new DataGridViewTextBoxColumn();
            place = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Refresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = Color.Lavender;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Indigo;
            button4.Location = new Point(705, 406);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(166, 44);
            button4.TabIndex = 44;
            button4.Text = "reject";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { username, email, phone, restaurantname, place, date, Status });
            dataGridView1.GridColor = SystemColors.ControlLightLight;
            dataGridView1.Location = new Point(42, 98);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1098, 240);
            dataGridView1.TabIndex = 42;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button3
            // 
            button3.BackColor = Color.Lavender;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Indigo;
            button3.Location = new Point(294, 406);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(148, 44);
            button3.TabIndex = 45;
            button3.Text = "Accept";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // username
            // 
            username.HeaderText = "username";
            username.MinimumWidth = 8;
            username.Name = "username";
            username.ReadOnly = true;
            username.Width = 150;
            // 
            // email
            // 
            email.HeaderText = "email";
            email.MinimumWidth = 8;
            email.Name = "email";
            email.ReadOnly = true;
            email.Width = 150;
            // 
            // phone
            // 
            phone.HeaderText = "phone";
            phone.MinimumWidth = 8;
            phone.Name = "phone";
            phone.ReadOnly = true;
            phone.Width = 150;
            // 
            // restaurantname
            // 
            restaurantname.HeaderText = "restaurantname";
            restaurantname.MinimumWidth = 8;
            restaurantname.Name = "restaurantname";
            restaurantname.ReadOnly = true;
            restaurantname.Width = 150;
            // 
            // place
            // 
            place.HeaderText = "place";
            place.MinimumWidth = 8;
            place.Name = "place";
            place.ReadOnly = true;
            place.Width = 150;
            // 
            // date
            // 
            date.HeaderText = "date";
            date.MinimumWidth = 8;
            date.Name = "date";
            date.ReadOnly = true;
            date.Width = 150;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 8;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 150;
            // 
            // Refresh
            // 
            Refresh.Location = new Point(530, 502);
            Refresh.Margin = new Padding(4, 5, 4, 5);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(107, 38);
            Refresh.TabIndex = 47;
            Refresh.Text = "Refresh";
            Refresh.UseVisualStyleBackColor = true;
            // 
            // RestaurantAccept
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1337, 741);
            Controls.Add(Refresh);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Name = "RestaurantAccept";
            Text = "RestaurantAccept";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button4;
        private DataGridView dataGridView1;
        private Button button3;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn restaurantname;
        private DataGridViewTextBoxColumn place;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn Status;
        private Button Refresh;
    }
}