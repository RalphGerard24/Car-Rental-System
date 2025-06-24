

namespace Car_Rental_System.Forms
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart chartSales;

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
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            panel5 = new Panel();
            labelRevenue = new Label();
            label11 = new Label();
            panel4 = new Panel();
            labelCarsAvailable = new Label();
            label9 = new Label();
            panel3 = new Panel();
            labelCarsOnRent = new Label();
            label7 = new Label();
            panel2 = new Panel();
            labelCarCount = new Label();
            label5 = new Label();
            panel1 = new Panel();
            labelCustomerCount = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            //cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            button7 = new Button();
            button3 = new Button();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 23);
            label1.Name = "label1";
            label1.Size = new Size(328, 68);
            label1.TabIndex = 0;
            label1.Text = "Car Rental";
            // 
            // button1
            // 
            button1.Location = new Point(32, 100);
            button1.Name = "button1";
            button1.Size = new Size(214, 87);
            button1.TabIndex = 1;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(32, 211);
            button2.Name = "button2";
            button2.Size = new Size(214, 87);
            button2.TabIndex = 2;
            button2.Text = "Manage Cars";
            button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(32, 323);
            button4.Name = "button4";
            button4.Size = new Size(214, 87);
            button4.TabIndex = 3;
            button4.Text = "Customers";
            button4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(groupBox1);
            groupBox2.Location = new Point(263, 92);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(976, 542);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dashboard";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(panel5);
            groupBox3.Controls.Add(panel4);
            groupBox3.Controls.Add(panel3);
            groupBox3.Controls.Add(panel2);
            groupBox3.Controls.Add(panel1);
            groupBox3.Location = new Point(489, 46);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(442, 460);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(labelRevenue);
            panel5.Controls.Add(label11);
            panel5.Location = new Point(30, 364);
            panel5.Name = "panel5";
            panel5.Size = new Size(376, 74);
            panel5.TabIndex = 4;
            // 
            // labelRevenue
            // 
            labelRevenue.AutoSize = true;
            labelRevenue.Font = new Font("Arial", 35F);
            labelRevenue.Location = new Point(296, 6);
            labelRevenue.Name = "labelRevenue";
            labelRevenue.Size = new Size(61, 66);
            labelRevenue.TabIndex = 1;
            labelRevenue.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(28, 27);
            label11.Name = "label11";
            label11.Size = new Size(91, 22);
            label11.TabIndex = 0;
            label11.Text = "Revenue:";
            // 
            // panel4
            // 
            panel4.Controls.Add(labelCarsAvailable);
            panel4.Controls.Add(label9);
            panel4.Location = new Point(213, 214);
            panel4.Name = "panel4";
            panel4.Size = new Size(177, 135);
            panel4.TabIndex = 3;
            // 
            // labelCarsAvailable
            // 
            labelCarsAvailable.AutoSize = true;
            labelCarsAvailable.Font = new Font("Arial", 35F);
            labelCarsAvailable.Location = new Point(62, 47);
            labelCarsAvailable.Name = "labelCarsAvailable";
            labelCarsAvailable.Size = new Size(61, 66);
            labelCarsAvailable.TabIndex = 1;
            labelCarsAvailable.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(28, 15);
            label9.Name = "label9";
            label9.Size = new Size(120, 22);
            label9.TabIndex = 0;
            label9.Text = "Car Available";
            // 
            // panel3
            // 
            panel3.Controls.Add(labelCarsOnRent);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(30, 214);
            panel3.Name = "panel3";
            panel3.Size = new Size(177, 135);
            panel3.TabIndex = 2;
            // 
            // labelCarsOnRent
            // 
            labelCarsOnRent.AutoSize = true;
            labelCarsOnRent.Font = new Font("Arial", 35F);
            labelCarsOnRent.Location = new Point(62, 47);
            labelCarsOnRent.Name = "labelCarsOnRent";
            labelCarsOnRent.Size = new Size(61, 66);
            labelCarsOnRent.TabIndex = 1;
            labelCarsOnRent.Text = "0";
            labelCarsOnRent.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 15);
            label7.Name = "label7";
            label7.Size = new Size(121, 22);
            label7.TabIndex = 0;
            label7.Text = "Cars on Rent";
            // 
            // panel2
            // 
            panel2.Controls.Add(labelCarCount);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(30, 134);
            panel2.Name = "panel2";
            panel2.Size = new Size(376, 74);
            panel2.TabIndex = 1;
            // 
            // labelCarCount
            // 
            labelCarCount.AutoSize = true;
            labelCarCount.Font = new Font("Arial", 35F);
            labelCarCount.Location = new Point(296, 6);
            labelCarCount.Name = "labelCarCount";
            labelCarCount.Size = new Size(61, 66);
            labelCarCount.TabIndex = 1;
            labelCarCount.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 27);
            label5.Name = "label5";
            label5.Size = new Size(149, 22);
            label5.TabIndex = 0;
            label5.Text = "Number of Cars:";
            // 
            // panel1
            // 
            panel1.Controls.Add(labelCustomerCount);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(30, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(376, 74);
            panel1.TabIndex = 0;
            // 
            // labelCustomerCount
            // 
            labelCustomerCount.AutoSize = true;
            labelCustomerCount.Font = new Font("Arial", 35F);
            labelCustomerCount.Location = new Point(296, 6);
            labelCustomerCount.Name = "labelCustomerCount";
            labelCustomerCount.Size = new Size(61, 66);
            labelCustomerCount.TabIndex = 1;
            labelCustomerCount.Text = "0";
            labelCustomerCount.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 27);
            label2.Name = "label2";
            label2.Size = new Size(202, 22);
            label2.TabIndex = 0;
            label2.Text = "Number of Customers:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chartSales);
            groupBox1.Location = new Point(32, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(439, 466);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Weekly Sales";
            groupBox1.Controls.Add(chartSales);

            // 
            // cartesianChart1
            // 
            // 
            var chart = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            chart.Location = new Point(23, 40);
            chart.MatchAxesScreenDataRatio = false;
            chart.Name = "chartSales";
            chart.Size = new Size(390, 407);
            chart.TabIndex = 0;
            groupBox1.Controls.Add(chart);

            // Now assign it to the field so it's accessible elsewhere
            chartSales = chart;


            // 
            // button7
            // 
            button7.Location = new Point(1092, 23);
            button7.Name = "button7";
            button7.Size = new Size(147, 55);
            button7.TabIndex = 7;
            button7.Text = "Log Out";
            button7.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(32, 430);
            button3.Name = "button3";
            button3.Size = new Size(214, 87);
            button3.TabIndex = 8;
            button3.Text = "Rental Records";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 915);
            Controls.Add(button3);
            Controls.Add(button7);
            Controls.Add(groupBox2);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "AdminDashboard";
            Text = "Dashboard - Car Rental System";
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button4;
        private GroupBox groupBox2;
        private Button button7;
        private GroupBox groupBox3;
        private Panel panel1;
        private Label label2;
        private GroupBox groupBox1;
        //private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private Label labelCustomerCount;
        private Panel panel3;
        private Label labelCarsOnRent;
        private Label label7;
        private Panel panel2;
        private Label labelCarCount;
        private Label label5;
        private Panel panel5;
        private Label labelRevenue;
        private Label label11;
        private Panel panel4;
        private Label labelCarsAvailable;
        private Label label9;
        private Button button3;
    }
}