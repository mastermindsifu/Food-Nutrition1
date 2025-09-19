namespace WinFormsApp1
{
    partial class ShowRest
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
            labelTotalCalories = new Label();
            labelTotalPrice = new Label();
            labelCalorieWarning = new Label();
            labelSalaryWarning = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // labelTotalCalories
            // 
            labelTotalCalories.AutoSize = true;
            labelTotalCalories.Location = new Point(60, 32);
            labelTotalCalories.Name = "labelTotalCalories";
            labelTotalCalories.Size = new Size(148, 25);
            labelTotalCalories.TabIndex = 0;
            labelTotalCalories.Text = "labelTotalCalories";
            // 
            // labelTotalPrice
            // 
            labelTotalPrice.AutoSize = true;
            labelTotalPrice.Location = new Point(60, 106);
            labelTotalPrice.Name = "labelTotalPrice";
            labelTotalPrice.Size = new Size(123, 25);
            labelTotalPrice.TabIndex = 1;
            labelTotalPrice.Text = "labelTotalPrice";
            // 
            // labelCalorieWarning
            // 
            labelCalorieWarning.AutoSize = true;
            labelCalorieWarning.Location = new Point(60, 180);
            labelCalorieWarning.Name = "labelCalorieWarning";
            labelCalorieWarning.Size = new Size(169, 25);
            labelCalorieWarning.TabIndex = 2;
            labelCalorieWarning.Text = "labelCalorieWarning";
            labelCalorieWarning.Click += labelCalorieWarning_Click;
            // 
            // labelSalaryWarning
            // 
            labelSalaryWarning.AutoSize = true;
            labelSalaryWarning.Location = new Point(60, 259);
            labelSalaryWarning.Name = "labelSalaryWarning";
            labelSalaryWarning.Size = new Size(162, 25);
            labelSalaryWarning.TabIndex = 3;
            labelSalaryWarning.Text = "labelSalaryWarning";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 338);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // ShowRest
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(labelSalaryWarning);
            Controls.Add(labelCalorieWarning);
            Controls.Add(labelTotalPrice);
            Controls.Add(labelTotalCalories);
            Name = "ShowRest";
            Text = "ShowRest";
            Load += ShowRest_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTotalCalories;
        private Label labelTotalPrice;
        private Label labelCalorieWarning;
        private Label labelSalaryWarning;
        private Label label1;
    }
}