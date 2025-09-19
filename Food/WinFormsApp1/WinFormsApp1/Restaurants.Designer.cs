namespace WinFormsApp1
{
    partial class Restaurants
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
            richTextBox1 = new RichTextBox();
            panel2 = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Location = new Point(167, 242);
            button1.Name = "button1";
            button1.Size = new Size(108, 106);
            button1.TabIndex = 10;
            button1.Text = "Show Infos";
            button1.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.HighlightText;
            richTextBox1.Location = new Point(270, 167);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1133, 637);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Location = new Point(64, 22);
            panel2.Name = "panel2";
            panel2.Size = new Size(112, 788);
            panel2.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 64, 0);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(64, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(1340, 139);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gray;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(134, 46);
            label1.Name = "label1";
            label1.Size = new Size(184, 45);
            label1.TabIndex = 0;
            label1.Text = "Restaurants";
            // 
            // Restaurants
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1469, 832);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Restaurants";
            Text = "Restaurants";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private RichTextBox richTextBox1;
        private Panel panel2;
        private Panel panel1;
        private Label label1;
    }
}