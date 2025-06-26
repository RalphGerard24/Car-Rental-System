

namespace Car_Rental_System.Forms
{
    partial class LoginPage
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            roundedPanel1 = new Car_Rental_System.Controls.RoundedPanel();
            label3 = new Label();
            roundedPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(154, 214, 212);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(0, 76, 76);
            button1.Location = new Point(240, 304);
            button1.Name = "button1";
            button1.Size = new Size(298, 44);
            button1.TabIndex = 0;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 110, 108);
            label1.Font = new Font("Poppins", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(120, 212);
            label1.Name = "label1";
            label1.Size = new Size(94, 28);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 110, 108);
            label2.Font = new Font("Poppins", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(120, 256);
            label2.Name = "label2";
            label2.Size = new Size(88, 28);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(240, 213);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(240, 258);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(300, 23);
            textBox2.TabIndex = 5;
            textBox2.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 110, 108);
            label4.Location = new Point(237, 381);
            label4.Name = "label4";
            label4.Size = new Size(154, 34);
            label4.TabIndex = 7;
            label4.Text = "Log in to begin";
            // 
            // roundedPanel1
            // 
            roundedPanel1.Anchor = AnchorStyles.None;
            roundedPanel1.BackColor = Color.FromArgb(0, 110, 108);
            roundedPanel1.Controls.Add(label2);
            roundedPanel1.Controls.Add(button1);
            roundedPanel1.Controls.Add(label1);
            roundedPanel1.Controls.Add(textBox1);
            roundedPanel1.Controls.Add(textBox2);
            roundedPanel1.CornerRadius = 20;
            roundedPanel1.Location = new Point(646, 93);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(664, 574);
            roundedPanel1.TabIndex = 8;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Poppins", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 110, 108);
            label3.Location = new Point(131, 294);
            label3.Name = "label3";
            label3.Size = new Size(393, 113);
            label3.TabIndex = 6;
            label3.Text = "Car Rental";
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1370, 749);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(roundedPanel1);
            MaximumSize = new Size(1386, 788);
            MinimumSize = new Size(1364, 766);
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log In - Car Rental System";
            WindowState = FormWindowState.Maximized;
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Controls.RoundedPanel roundedPanel1;
        private Label label3;
    }
}