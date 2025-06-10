namespace Car_Rental_System.Forms
{
    partial class reportContent
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
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            label19 = new Label();
            textBox18 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(395, 82);
            label1.TabIndex = 10;
            label1.Text = "Car Rental";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(37, 273);
            richTextBox1.Margin = new Padding(4, 5, 4, 5);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(861, 556);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Arial", 11.25F);
            label19.Location = new Point(37, 155);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(140, 26);
            label19.TabIndex = 12;
            label19.Text = "Customer ID";
            // 
            // textBox18
            // 
            textBox18.Font = new Font("Arial", 11.25F);
            textBox18.Location = new Point(193, 150);
            textBox18.Margin = new Padding(4, 5, 4, 5);
            textBox18.Name = "textBox18";
            textBox18.ReadOnly = true;
            textBox18.Size = new Size(260, 33);
            textBox18.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 11.25F);
            textBox1.Location = new Point(193, 210);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(260, 33);
            textBox1.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F);
            label2.Location = new Point(37, 215);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(156, 26);
            label2.TabIndex = 14;
            label2.Text = "Email Address";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial", 11.25F);
            textBox2.Location = new Point(639, 210);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(260, 33);
            textBox2.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F);
            label3.Location = new Point(483, 215);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(133, 26);
            label3.TabIndex = 18;
            label3.Text = "Contact No.";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Arial", 11.25F);
            textBox3.Location = new Point(639, 150);
            textBox3.Margin = new Padding(4, 5, 4, 5);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(260, 33);
            textBox3.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F);
            label4.Location = new Point(483, 155);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(79, 26);
            label4.TabIndex = 16;
            label4.Text = "Car ID";
            // 
            // button1
            // 
            button1.Location = new Point(737, 850);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(163, 42);
            button1.TabIndex = 27;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            // 
            // reportContent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 925);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(textBox18);
            Controls.Add(label19);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "reportContent";
            Text = "Report - Car Rental System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox richTextBox1;
        private Label label19;
        private TextBox textBox18;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private Button button1;
    }
}