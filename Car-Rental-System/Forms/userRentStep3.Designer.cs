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
            SuspendLayout();
            // 
            // button3
            // 
            button3.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(34, 160);
            button3.Name = "button3";
            button3.Size = new Size(131, 30);
            button3.TabIndex = 40;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F);
            label2.Location = new Point(35, 33);
            label2.Name = "label2";
            label2.Size = new Size(233, 17);
            label2.TabIndex = 41;
            label2.Text = "Are you sure you want to proceed?";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Arial", 11.25F);
            textBox4.Location = new Point(157, 128);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(148, 25);
            textBox4.TabIndex = 47;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11.25F);
            label5.Location = new Point(35, 131);
            label5.Name = "label5";
            label5.Size = new Size(100, 17);
            label5.TabIndex = 46;
            label5.Text = "Total Payment";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial", 11.25F);
            textBox2.Location = new Point(157, 95);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(148, 25);
            textBox2.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F);
            label3.Location = new Point(35, 98);
            label3.Name = "label3";
            label3.Size = new Size(50, 17);
            label3.TabIndex = 44;
            label3.Text = "Car ID";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 11.25F);
            textBox1.Location = new Point(157, 62);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(148, 25);
            textBox1.TabIndex = 43;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F);
            label1.Location = new Point(34, 65);
            label1.Name = "label1";
            label1.Size = new Size(91, 17);
            label1.TabIndex = 42;
            label1.Text = "Customer ID";
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(174, 160);
            button1.Name = "button1";
            button1.Size = new Size(131, 30);
            button1.TabIndex = 48;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            // 
            // userRentStep3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 232);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(button3);
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
    }
}