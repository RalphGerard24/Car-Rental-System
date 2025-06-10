namespace gumana_ka_be_pls
{
    partial class userRentOnRent
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
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            button7 = new Button();
            groupBox2 = new GroupBox();
            label9 = new Label();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(25, 436);
            button3.Name = "button3";
            button3.Size = new Size(214, 87);
            button3.TabIndex = 19;
            button3.Text = "Reports";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(25, 325);
            button4.Name = "button4";
            button4.Size = new Size(214, 87);
            button4.TabIndex = 18;
            button4.Text = "Customers";
            button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(25, 213);
            button2.Name = "button2";
            button2.Size = new Size(214, 87);
            button2.TabIndex = 17;
            button2.Text = "Manage Cars";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(25, 102);
            button1.Name = "button1";
            button1.Size = new Size(214, 87);
            button1.TabIndex = 16;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(7, 25);
            label1.Name = "label1";
            label1.Size = new Size(265, 55);
            label1.TabIndex = 15;
            label1.Text = "Car Rental";
            // 
            // button7
            // 
            button7.Location = new Point(980, 25);
            button7.Name = "button7";
            button7.Size = new Size(75, 55);
            button7.TabIndex = 21;
            button7.Text = "Log Out";
            button7.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Location = new Point(256, 94);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(799, 429);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Rent";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 11.25F);
            label9.Location = new Point(132, 203);
            label9.Name = "label9";
            label9.Size = new Size(530, 17);
            label9.TabIndex = 37;
            label9.Text = "You have an ongoing rent on a car. Please try again after returning the rented car.";
            // 
            // userRent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 549);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(button7);
            Controls.Add(groupBox2);
            Name = "userRent";
            Text = "Rent - Car Rental System";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button4;
        private Button button2;
        private Button button1;
        private Label label1;
        private Button button7;
        private GroupBox groupBox2;
        private Label label9;
    }
}