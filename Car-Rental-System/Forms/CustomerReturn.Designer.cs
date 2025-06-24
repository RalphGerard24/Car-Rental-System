namespace Car_Rental_System
{
    partial class CustomerReturn
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
            buttonConfirmReturn = new Button();
            label12 = new Label();
            textBox7 = new TextBox();
            label8 = new Label();
            textBox8 = new TextBox();
            label9 = new Label();
            textBox9 = new TextBox();
            label10 = new Label();
            textBox10 = new TextBox();
            label11 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            CarIDTextBox = new TextBox();
            label5 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            CustomerIDTextBox = new TextBox();
            label2 = new Label();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(36, 541);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(306, 145);
            button4.TabIndex = 25;
            button4.Text = "Customers";
            button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(36, 355);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(306, 145);
            button2.TabIndex = 24;
            button2.Text = "Manage Cars";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(36, 170);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(306, 145);
            button1.TabIndex = 23;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 41);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(395, 82);
            label1.TabIndex = 22;
            label1.Text = "Car Rental";
            // 
            // button7
            // 
            button7.Location = new Point(1400, 41);
            button7.Margin = new Padding(4, 5, 4, 5);
            button7.Name = "button7";
            button7.Size = new Size(108, 91);
            button7.TabIndex = 28;
            button7.Text = "Log Out";
            button7.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonConfirmReturn);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(textBox8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(textBox9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(textBox10);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(CarIDTextBox);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(CustomerIDTextBox);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(366, 156);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(1141, 715);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "Return";
            // 
            // buttonConfirmReturn
            // 
            buttonConfirmReturn.Location = new Point(756, 536);
            buttonConfirmReturn.Name = "buttonConfirmReturn";
            buttonConfirmReturn.Size = new Size(240, 54);
            buttonConfirmReturn.TabIndex = 41;
            buttonConfirmReturn.Text = "Confirm Return";
            buttonConfirmReturn.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(30, 646);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(768, 21);
            label12.TabIndex = 40;
            label12.Text = "*A penalty fee of {Amount} will be charged for each day the car is not returned past its due date.";
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Arial", 11.25F);
            textBox7.Location = new Point(772, 186);
            textBox7.Margin = new Padding(4, 5, 4, 5);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(332, 33);
            textBox7.TabIndex = 39;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 11.25F);
            label8.Location = new Point(584, 191);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(140, 26);
            label8.TabIndex = 38;
            label8.Text = "Total Amount";
            // 
            // textBox8
            // 
            textBox8.Font = new Font("Arial", 11.25F);
            textBox8.Location = new Point(772, 404);
            textBox8.Margin = new Padding(4, 5, 4, 5);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(332, 33);
            textBox8.TabIndex = 37;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 11.25F);
            label9.Location = new Point(586, 409);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(132, 26);
            label9.TabIndex = 36;
            label9.Text = "Penalty Fee";
            // 
            // textBox9
            // 
            textBox9.Font = new Font("Arial", 11.25F);
            textBox9.Location = new Point(772, 121);
            textBox9.Margin = new Padding(4, 5, 4, 5);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(332, 33);
            textBox9.TabIndex = 35;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 11.25F);
            label10.Location = new Point(586, 126);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(47, 26);
            label10.TabIndex = 34;
            label10.Text = "Tax";
            // 
            // textBox10
            // 
            textBox10.Font = new Font("Arial", 11.25F);
            textBox10.Location = new Point(772, 50);
            textBox10.Margin = new Padding(4, 5, 4, 5);
            textBox10.Name = "textBox10";
            textBox10.ReadOnly = true;
            textBox10.Size = new Size(332, 33);
            textBox10.TabIndex = 33;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 11.25F);
            label11.Location = new Point(584, 55);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(106, 26);
            label11.TabIndex = 32;
            label11.Text = "Rent Fee";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Arial", 11.25F);
            textBox3.Location = new Point(218, 399);
            textBox3.Margin = new Padding(4, 5, 4, 5);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(332, 33);
            textBox3.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F);
            label4.Location = new Point(29, 404);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(109, 26);
            label4.TabIndex = 30;
            label4.Text = "Due Date";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Arial", 11.25F);
            textBox5.Location = new Point(218, 330);
            textBox5.Margin = new Padding(4, 5, 4, 5);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(332, 33);
            textBox5.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 11.25F);
            label6.Location = new Point(30, 335);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(132, 26);
            label6.TabIndex = 28;
            label6.Text = "Day Rented";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Arial", 11.25F);
            textBox6.Location = new Point(218, 259);
            textBox6.Margin = new Padding(4, 5, 4, 5);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(332, 33);
            textBox6.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 11.25F);
            label7.Location = new Point(29, 264);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(105, 26);
            label7.TabIndex = 26;
            label7.Text = "Plate No.";
            // 
            // CarIDTextBox
            // 
            CarIDTextBox.Font = new Font("Arial", 11.25F);
            CarIDTextBox.Location = new Point(218, 190);
            CarIDTextBox.Margin = new Padding(4, 5, 4, 5);
            CarIDTextBox.Name = "CarIDTextBox";
            CarIDTextBox.ReadOnly = true;
            CarIDTextBox.Size = new Size(332, 33);
            CarIDTextBox.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11.25F);
            label5.Location = new Point(30, 195);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(79, 26);
            label5.TabIndex = 24;
            label5.Text = "Car ID";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial", 11.25F);
            textBox2.Location = new Point(218, 121);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(332, 33);
            textBox2.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F);
            label3.Location = new Point(30, 126);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(178, 26);
            label3.TabIndex = 22;
            label3.Text = "Customer Name";
            // 
            // CustomerIDTextBox
            // 
            CustomerIDTextBox.Font = new Font("Arial", 11.25F);
            CustomerIDTextBox.Location = new Point(218, 50);
            CustomerIDTextBox.Margin = new Padding(4, 5, 4, 5);
            CustomerIDTextBox.Name = "CustomerIDTextBox";
            CustomerIDTextBox.ReadOnly = true;
            CustomerIDTextBox.Size = new Size(332, 33);
            CustomerIDTextBox.TabIndex = 21;
            //CustomerIDTextBox.TextChanged += CustomerIDTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F);
            label2.Location = new Point(29, 55);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(140, 26);
            label2.TabIndex = 20;
            label2.Text = "Customer ID";
            // 
            // CustomerReturn
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1542, 915);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(button7);
            Controls.Add(groupBox2);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CustomerReturn";
            Text = "Return - Car Rental System";
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
        private Label label12;
        private TextBox textBox7;
        private Label label8;
        private TextBox textBox8;
        private Label label9;
        private TextBox textBox9;
        private Label label10;
        private TextBox textBox10;
        private Label label11;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox6;
        private Label label7;
        private TextBox CarIDTextBox;
        private Label label5;
        private TextBox textBox2;
        private Label label3;
        private TextBox CustomerIDTextBox;
        private Label label2;
        private Button buttonConfirmReturn;
    }
}