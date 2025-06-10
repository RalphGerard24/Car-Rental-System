namespace gumana_ka_be_pls
{
    partial class userRentConfirmed
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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(100, 196);
            button1.Name = "button1";
            button1.Size = new Size(131, 30);
            button1.TabIndex = 57;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Arial", 11.25F);
            textBox4.Location = new Point(160, 143);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(148, 25);
            textBox4.TabIndex = 56;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11.25F);
            label5.Location = new Point(38, 146);
            label5.Name = "label5";
            label5.Size = new Size(102, 17);
            label5.TabIndex = 55;
            label5.Text = "Transaction ID";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial", 11.25F);
            textBox2.Location = new Point(160, 110);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(148, 25);
            textBox2.TabIndex = 54;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F);
            label3.Location = new Point(38, 113);
            label3.Name = "label3";
            label3.Size = new Size(50, 17);
            label3.TabIndex = 53;
            label3.Text = "Car ID";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 11.25F);
            textBox1.Location = new Point(160, 77);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(148, 25);
            textBox1.TabIndex = 52;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F);
            label1.Location = new Point(37, 80);
            label1.Name = "label1";
            label1.Size = new Size(91, 17);
            label1.TabIndex = 51;
            label1.Text = "Customer ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F);
            label2.Location = new Point(38, 31);
            label2.Name = "label2";
            label2.Size = new Size(263, 34);
            label2.TabIndex = 50;
            label2.Text = "Car Rental successfully processed. \r\nPlease proceed to cashier for payment.\r\n";
            // 
            // userRentConfirmed
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 259);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "userRentConfirmed";
            Text = "Rent Confirmed - Car Rental System";
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
    }
}