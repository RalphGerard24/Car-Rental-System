namespace Car_Rental_System
{
    partial class userReturnEmpty
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
            // button4
            // 
            button4.Location = new Point(29, 433);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(245, 116);
            button4.TabIndex = 32;
            button4.Text = "Customers";
            button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(29, 284);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(245, 116);
            button2.TabIndex = 31;
            button2.Text = "Manage Cars";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(29, 136);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(245, 116);
            button1.TabIndex = 30;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 33);
            label1.Name = "label1";
            label1.Size = new Size(328, 68);
            label1.TabIndex = 29;
            label1.Text = "Car Rental";
            // 
            // button7
            // 
            button7.Location = new Point(1120, 33);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(86, 73);
            button7.TabIndex = 35;
            button7.Text = "Log Out";
            button7.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Location = new Point(293, 125);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(913, 572);
            groupBox2.TabIndex = 34;
            groupBox2.TabStop = false;
            groupBox2.Text = "Return";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 11.25F);
            label9.Location = new Point(267, 268);
            label9.Name = "label9";
            label9.Size = new Size(416, 44);
            label9.TabIndex = 38;
            label9.Text = "You are currently not renting a car.\r\nThere is no car to be returned as of the moment.\r\n";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // userReturnEmpty
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 732);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(button7);
            Controls.Add(groupBox2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "userReturnEmpty";
            Text = "Form1";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button4;
        private Button button2;
        private Button button1;
        private Label label1;
        private Button button7;
        private GroupBox groupBox2;
        private Label label9;
    }
}