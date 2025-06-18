namespace Car_Rental_System
{
    partial class userRentStep3
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
            button3 = new Button();
            label2 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            label4 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(40, 342);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(150, 40);
            button3.TabIndex = 40;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F);
            label2.Location = new Point(40, 44);
            label2.Name = "label2";
            label2.Size = new Size(303, 22);
            label2.TabIndex = 41;
            label2.Text = "Are you sure you want to proceed?";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Arial", 11.25F);
            textBox4.Location = new Point(179, 171);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(169, 29);
            textBox4.TabIndex = 47;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11.25F);
            label5.Location = new Point(37, 174);
            label5.Name = "label5";
            label5.Size = new Size(129, 22);
            label5.TabIndex = 46;
            label5.Text = "Total Payment";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial", 11.25F);
            textBox2.Location = new Point(179, 127);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(169, 29);
            textBox2.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F);
            label3.Location = new Point(40, 131);
            label3.Name = "label3";
            label3.Size = new Size(65, 22);
            label3.TabIndex = 44;
            label3.Text = "Car ID";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 11.25F);
            textBox1.Location = new Point(179, 83);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(169, 29);
            textBox1.TabIndex = 43;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F);
            label1.Location = new Point(39, 87);
            label1.Name = "label1";
            label1.Size = new Size(118, 22);
            label1.TabIndex = 42;
            label1.Text = "Customer ID";
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(198, 342);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(150, 40);
            button1.TabIndex = 48;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Control;
            textBox3.Font = new Font("Arial", 11.25F);
            textBox3.Location = new Point(179, 218);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(170, 29);
            textBox3.TabIndex = 49;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Control;
            textBox5.Font = new Font("Arial", 11.25F);
            textBox5.Location = new Point(179, 264);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(169, 29);
            textBox5.TabIndex = 50;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F);
            label4.Location = new Point(39, 223);
            label4.Name = "label4";
            label4.Size = new Size(92, 22);
            label4.TabIndex = 51;
            label4.Text = "Rent date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 11.25F);
            label6.Location = new Point(40, 269);
            label6.Name = "label6";
            label6.Size = new Size(111, 22);
            label6.TabIndex = 52;
            label6.Text = "Return Date";
            // 
            // userRentStep3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 455);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(button3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "userRentStep3";
            Text = "Confirm Rent - Car Rental System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Label label2;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox5;
        private Label label4;
        private Label label6;
    }
}