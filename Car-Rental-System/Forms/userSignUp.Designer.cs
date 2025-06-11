namespace Car_Rental_System
{
    partial class userSignUp
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
            label4 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(128, 93);
            label4.Name = "label4";
            label4.Size = new Size(193, 15);
            label4.TabIndex = 15;
            label4.Text = "Sign up to explore car rental deals";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(92, 38);
            label3.Name = "label3";
            label3.Size = new Size(265, 55);
            label3.TabIndex = 14;
            label3.Text = "Car Rental";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(115, 194);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(298, 23);
            textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(115, 160);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(298, 23);
            textBox1.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 202);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 11;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(36, 163);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 10;
            label1.Text = "Username";
            // 
            // button2
            // 
            button2.Location = new Point(36, 229);
            button2.Name = "button2";
            button2.Size = new Size(179, 44);
            button2.TabIndex = 9;
            button2.Text = "Log In Instead";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(234, 229);
            button1.Name = "button1";
            button1.Size = new Size(179, 44);
            button1.TabIndex = 8;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = true;
            // 
            // userSignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 310);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "userSignUp";
            Text = "Car Rental System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button1;
    }
}