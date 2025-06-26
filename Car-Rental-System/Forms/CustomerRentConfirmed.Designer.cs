namespace Car_Rental_System
{
    partial class CustomerRentConfirmed
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
            textBox4 = new TextBox();
            label5 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            roundedPanel1 = new Car_Rental_System.Controls.RoundedPanel();
            roundedPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(154, 214, 212);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Poppins Medium", 9F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(0, 76, 76);
            button1.Location = new Point(81, 259);
            button1.Name = "button1";
            button1.Size = new Size(298, 44);
            button1.TabIndex = 57;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.BackColor = Color.FromArgb(0, 110, 108);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Poppins Medium", 12F, FontStyle.Bold);
            textBox4.ForeColor = Color.White;
            textBox4.Location = new Point(208, 97);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.RightToLeft = RightToLeft.Yes;
            textBox4.Size = new Size(184, 24);
            textBox4.TabIndex = 56;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 12F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(29, 97);
            label5.Name = "label5";
            label5.Size = new Size(154, 28);
            label5.TabIndex = 55;
            label5.Text = "Transaction Code";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.BackColor = Color.FromArgb(0, 110, 108);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Poppins Medium", 12F, FontStyle.Bold);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(208, 64);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.RightToLeft = RightToLeft.Yes;
            textBox2.Size = new Size(184, 24);
            textBox2.TabIndex = 54;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(29, 64);
            label3.Name = "label3";
            label3.Size = new Size(60, 28);
            label3.TabIndex = 53;
            label3.Text = "Car ID";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BackColor = Color.FromArgb(0, 110, 108);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Poppins Medium", 12F, FontStyle.Bold);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(208, 31);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.RightToLeft = RightToLeft.Yes;
            textBox1.Size = new Size(184, 24);
            textBox1.TabIndex = 52;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(28, 31);
            label1.Name = "label1";
            label1.Size = new Size(109, 28);
            label1.TabIndex = 51;
            label1.Text = "Customer ID";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 12F);
            label2.Location = new Point(67, 21);
            label2.Name = "label2";
            label2.Size = new Size(324, 56);
            label2.TabIndex = 50;
            label2.Text = "Car Rental successfully processed. \r\nPlease proceed to cashier for payment.\r\n";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // roundedPanel1
            // 
            roundedPanel1.Anchor = AnchorStyles.None;
            roundedPanel1.BackColor = Color.FromArgb(0, 110, 108);
            roundedPanel1.Controls.Add(label1);
            roundedPanel1.Controls.Add(textBox4);
            roundedPanel1.Controls.Add(textBox1);
            roundedPanel1.Controls.Add(label5);
            roundedPanel1.Controls.Add(label3);
            roundedPanel1.Controls.Add(textBox2);
            roundedPanel1.CornerRadius = 20;
            roundedPanel1.Location = new Point(25, 90);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(409, 151);
            roundedPanel1.TabIndex = 58;
            // 
            // CustomerRentConfirmed
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(461, 327);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(roundedPanel1);
            MaximumSize = new Size(477, 366);
            MinimumSize = new Size(477, 366);
            Name = "CustomerRentConfirmed";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rent Confirmed - Car Rental System";
            Load += CustomerRentConfirmed_Load;
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Controls.RoundedPanel roundedPanel1;
    }
}