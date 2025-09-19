namespace WinFormsApp1
{
    partial class Login
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
            UserId = new Label();
            richTextBox1 = new RichTextBox();
            password = new Label();
            richTextBox2 = new RichTextBox();
            Submit = new Button();
            SuspendLayout();
            // 
            // UserId
            // 
            UserId.AutoSize = true;
            UserId.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserId.ForeColor = SystemColors.ControlText;
            UserId.Location = new Point(75, 101);
            UserId.Name = "UserId";
            UserId.Size = new Size(149, 30);
            UserId.TabIndex = 0;
            UserId.Text = "User Name";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(233, 85);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(246, 67);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            password.ForeColor = SystemColors.ActiveCaptionText;
            password.Location = new Point(75, 230);
            password.Name = "password";
            password.Size = new Size(151, 30);
            password.TabIndex = 2;
            password.Text = "Password";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(233, 208);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(246, 65);
            richTextBox2.TabIndex = 3;
            richTextBox2.Text = "";
            // 
            // Submit
            // 
            Submit.BackColor = SystemColors.ActiveCaption;
            Submit.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Submit.ForeColor = SystemColors.ActiveCaptionText;
            Submit.Location = new Point(267, 325);
            Submit.Name = "Submit";
            Submit.Size = new Size(145, 45);
            Submit.TabIndex = 4;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = false;
            Submit.Click += Submit_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(Submit);
            Controls.Add(richTextBox2);
            Controls.Add(password);
            Controls.Add(richTextBox1);
            Controls.Add(UserId);
            ForeColor = SystemColors.ActiveCaption;
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UserId;
        private RichTextBox richTextBox1;
        private Label password;
        private RichTextBox richTextBox2;
        private Button Submit;
    }
}