namespace WinFormsApp1
{
    partial class SignUp
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
            Regular = new Button();
            Diet = new Button();
            SuspendLayout();
            // 
            // Regular
            // 
            Regular.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Regular.Location = new Point(43, 159);
            Regular.Name = "Regular";
            Regular.Size = new Size(300, 90);
            Regular.TabIndex = 2;
            Regular.Text = "Regular";
            Regular.UseVisualStyleBackColor = true;
            Regular.Click += button1_Click;
            // 
            // Diet
            // 
            Diet.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Diet.Location = new Point(406, 159);
            Diet.Name = "Diet";
            Diet.Size = new Size(300, 90);
            Diet.TabIndex = 3;
            Diet.Text = "Diet";
            Diet.UseVisualStyleBackColor = true;
            Diet.Click += Diet_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 450);
            Controls.Add(Diet);
            Controls.Add(Regular);
            Name = "SignUp";
            Text = "SignUp";
            Load += SignUp_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Regular;
        private Button Diet;
    }
}