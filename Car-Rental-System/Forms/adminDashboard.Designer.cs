

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
            panel6 = new Panel();
            labelRevenue = new Label();
            label11 = new Label();
            labelCarsAvailable = new Label();
            label9 = new Label();
            labelCarsOnRent = new Label();
            label7 = new Label();
            labelCarCount = new Label();
            label5 = new Label();
            labelCustomerCount = new Label();
            label2 = new Label();
            button7 = new Button();
            button3 = new Button();
            roundedPanel1 = new Car_Rental_System.Controls.RoundedPanel();
            roundedPanel2 = new Car_Rental_System.Controls.RoundedPanel();
            roundedPanel3 = new Car_Rental_System.Controls.RoundedPanel();
            roundedPanel4 = new Car_Rental_System.Controls.RoundedPanel();
            label4 = new Label();
            roundedPanel5 = new Car_Rental_System.Controls.RoundedPanel();
            roundedPanel6 = new Car_Rental_System.Controls.RoundedPanel();
            roundedPanel7 = new Car_Rental_System.Controls.RoundedPanel();
            label3 = new Label();
            roundedPanel1.SuspendLayout();
            roundedPanel2.SuspendLayout();
            roundedPanel3.SuspendLayout();
            roundedPanel4.SuspendLayout();
            roundedPanel5.SuspendLayout();
            roundedPanel6.SuspendLayout();
            roundedPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 110, 108);
            label1.Location = new Point(45, 42);
            label1.Name = "label1";
            label1.Size = new Size(408, 55);
            label1.TabIndex = 0;
            label1.Text = "Car Rental";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(154, 214, 212);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(0, 76, 76);
            button1.Location = new Point(22, 21);
            button1.Name = "button1";
            button1.Size = new Size(187, 123);
            button1.TabIndex = 1;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.FromArgb(154, 214, 212);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(0, 76, 76);
            button2.Location = new Point(22, 169);
            button2.Name = "button2";
            button2.Size = new Size(187, 123);
            button2.TabIndex = 2;
            button2.Text = "Manage Cars";
            button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.BackColor = Color.FromArgb(154, 214, 212);
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button4.ForeColor = Color.FromArgb(0, 76, 76);
            button4.Location = new Point(22, 313);
            button4.Name = "button4";
            button4.Size = new Size(187, 123);
            button4.TabIndex = 3;
            button4.Text = "Customers";
            button4.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.None;
            panel6.ForeColor = Color.White;
            panel6.Location = new Point(26, 97);
            panel6.Name = "panel6";
            panel6.Size = new Size(383, 294);
            panel6.TabIndex = 0;
            // 
            // labelRevenue
            // 
            labelRevenue.Anchor = AnchorStyles.None;
            labelRevenue.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRevenue.ForeColor = Color.White;
            labelRevenue.Location = new Point(9, 47);
            labelRevenue.Name = "labelRevenue";
            labelRevenue.Size = new Size(458, 76);
            labelRevenue.TabIndex = 1;
            labelRevenue.Text = "000,000,000";
            //labelRevenue.Click += labelRevenue_Click;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label11.ForeColor = Color.White;
            label11.Location = new Point(20, 16);
            label11.Name = "label11";
            label11.Size = new Size(164, 38);
            label11.TabIndex = 0;
            label11.Text = "Revenue:";
            //label11.Click += label11_Click;
            // 
            // labelCarsAvailable
            // 
            labelCarsAvailable.Anchor = AnchorStyles.None;
            labelCarsAvailable.Font = new Font("Microsoft Sans Serif", 72F);
            labelCarsAvailable.ForeColor = Color.White;
            labelCarsAvailable.Location = new Point(338, 0);
            labelCarsAvailable.Name = "labelCarsAvailable";
            labelCarsAvailable.Size = new Size(204, 132);
            labelCarsAvailable.TabIndex = 1;
            labelCarsAvailable.Text = "00";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(27, 51);
            label9.Name = "label9";
            label9.Size = new Size(185, 31);
            label9.TabIndex = 0;
            label9.Text = "Car Available";
            // 
            // labelCarsOnRent
            // 
            labelCarsOnRent.Anchor = AnchorStyles.None;
            labelCarsOnRent.Font = new Font("Microsoft Sans Serif", 72F);
            labelCarsOnRent.ForeColor = Color.White;
            labelCarsOnRent.Location = new Point(348, 3);
            labelCarsOnRent.Name = "labelCarsOnRent";
            labelCarsOnRent.Size = new Size(194, 129);
            labelCarsOnRent.TabIndex = 1;
            labelCarsOnRent.Text = "00";
            //labelCarsOnRent.Click += labelCarsOnRent_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(27, 59);
            label7.Name = "label7";
            label7.Size = new Size(239, 51);
            label7.TabIndex = 0;
            label7.Text = "Cars on Rent";
            // 
            // labelCarCount
            // 
            labelCarCount.Anchor = AnchorStyles.None;
            labelCarCount.Font = new Font("Microsoft Sans Serif", 72F);
            labelCarCount.ForeColor = Color.White;
            labelCarCount.Location = new Point(343, 0);
            labelCarCount.Name = "labelCarCount";
            labelCarCount.Size = new Size(203, 123);
            labelCarCount.TabIndex = 1;
            labelCarCount.Text = "00";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(27, 58);
            label5.Name = "label5";
            label5.Size = new Size(239, 29);
            label5.TabIndex = 0;
            label5.Text = "Number of Cars:";
            // 
            // labelCustomerCount
            // 
            labelCustomerCount.Anchor = AnchorStyles.None;
            labelCustomerCount.Font = new Font("Microsoft Sans Serif", 72F);
            labelCustomerCount.ForeColor = Color.White;
            labelCustomerCount.Location = new Point(332, -2);
            labelCustomerCount.Name = "labelCustomerCount";
            labelCustomerCount.Size = new Size(214, 134);
            labelCustomerCount.TabIndex = 1;
            labelCustomerCount.Text = "00";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(27, 58);
            label2.Name = "label2";
            label2.Size = new Size(239, 32);
            label2.TabIndex = 0;
            label2.Text = "Number of Customers:";
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.None;
            button7.BackColor = Color.FromArgb(154, 214, 212);
            button7.FlatStyle = FlatStyle.Popup;
            button7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button7.ForeColor = Color.FromArgb(0, 76, 76);
            button7.Location = new Point(1140, 42);
            button7.Name = "button7";
            button7.Size = new Size(201, 63);
            button7.TabIndex = 7;
            button7.Text = "Log Out";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.FromArgb(154, 214, 212);
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(0, 76, 76);
            button3.Location = new Point(22, 457);
            button3.Name = "button3";
            button3.Size = new Size(187, 123);
            button3.TabIndex = 8;
            button3.Text = "Rental Records";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // roundedPanel1
            // 
            roundedPanel1.Anchor = AnchorStyles.None;
            roundedPanel1.BackColor = Color.FromArgb(0, 110, 108);
            roundedPanel1.Controls.Add(button3);
            roundedPanel1.Controls.Add(button1);
            roundedPanel1.Controls.Add(button2);
            roundedPanel1.Controls.Add(button4);
            roundedPanel1.CornerRadius = 20;
            roundedPanel1.Location = new Point(54, 127);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(232, 599);
            roundedPanel1.TabIndex = 9;
            // 
            // roundedPanel2
            // 
            roundedPanel2.Anchor = AnchorStyles.None;
            roundedPanel2.BackColor = Color.FromArgb(51, 153, 155);
            roundedPanel2.Controls.Add(labelCustomerCount);
            roundedPanel2.Controls.Add(label2);
            roundedPanel2.CornerRadius = 20;
            roundedPanel2.Location = new Point(792, 129);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(549, 132);
            roundedPanel2.TabIndex = 10;
            // 
            // roundedPanel3
            // 
            roundedPanel3.Anchor = AnchorStyles.None;
            roundedPanel3.BackColor = Color.FromArgb(51, 153, 155);
            roundedPanel3.Controls.Add(label5);
            roundedPanel3.Controls.Add(labelCarCount);
            roundedPanel3.CornerRadius = 20;
            roundedPanel3.Location = new Point(792, 284);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(549, 132);
            roundedPanel3.TabIndex = 11;
            // 
            // roundedPanel4
            // 
            roundedPanel4.Anchor = AnchorStyles.None;
            roundedPanel4.BackColor = Color.FromArgb(51, 153, 155);
            roundedPanel4.Controls.Add(labelCarsAvailable);
            roundedPanel4.Controls.Add(label4);
            roundedPanel4.Controls.Add(label9);
            roundedPanel4.CornerRadius = 20;
            roundedPanel4.Location = new Point(792, 594);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(549, 132);
            roundedPanel4.TabIndex = 12;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(-235, 23);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 0;
            label4.Text = "Cars on Rent";
            // 
            // roundedPanel5
            // 
            roundedPanel5.Anchor = AnchorStyles.None;
            roundedPanel5.BackColor = Color.FromArgb(51, 153, 155);
            roundedPanel5.Controls.Add(labelCarsOnRent);
            roundedPanel5.Controls.Add(label7);
            roundedPanel5.CornerRadius = 20;
            roundedPanel5.Location = new Point(792, 440);
            roundedPanel5.Name = "roundedPanel5";
            roundedPanel5.Size = new Size(549, 132);
            roundedPanel5.TabIndex = 13;
            // 
            // roundedPanel6
            // 
            roundedPanel6.Anchor = AnchorStyles.None;
            roundedPanel6.BackColor = Color.FromArgb(51, 153, 155);
            roundedPanel6.Controls.Add(labelRevenue);
            roundedPanel6.Controls.Add(label11);
            roundedPanel6.CornerRadius = 20;
            roundedPanel6.Location = new Point(319, 584);
            roundedPanel6.Name = "roundedPanel6";
            roundedPanel6.Size = new Size(436, 142);
            roundedPanel6.TabIndex = 14;
           // roundedPanel6.Paint += roundedPanel6_Paint;
            // 
            // roundedPanel7
            // 
            roundedPanel7.Anchor = AnchorStyles.None;
            roundedPanel7.BackColor = Color.FromArgb(154, 214, 212);
            roundedPanel7.Controls.Add(panel6);
            roundedPanel7.Controls.Add(label3);
            roundedPanel7.CornerRadius = 20;
            roundedPanel7.Location = new Point(319, 129);
            roundedPanel7.Name = "roundedPanel7";
            roundedPanel7.Size = new Size(436, 421);
            roundedPanel7.TabIndex = 15;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(17, 87, 99);
            label3.Location = new Point(20, 19);
            label3.Name = "label3";
            label3.Size = new Size(360, 59);
            label3.TabIndex = 1;
            label3.Text = "Weekly Rents";
            // 
            // AdminDashboard
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1370, 749);
            Controls.Add(roundedPanel7);
            Controls.Add(roundedPanel6);
            Controls.Add(roundedPanel5);
            Controls.Add(roundedPanel4);
            Controls.Add(roundedPanel3);
            Controls.Add(roundedPanel2);
            Controls.Add(button7);
            Controls.Add(label1);
            Controls.Add(roundedPanel1);
            Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximumSize = new Size(1388, 796);
            MinimumSize = new Size(1388, 796);
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard - Car Rental System";
            WindowState = FormWindowState.Maximized;
           // Load += AdminDashboard_Load;
            roundedPanel1.ResumeLayout(false);
            roundedPanel2.ResumeLayout(false);
            roundedPanel3.ResumeLayout(false);
            roundedPanel4.ResumeLayout(false);
            roundedPanel5.ResumeLayout(false);
            roundedPanel6.ResumeLayout(false);
            roundedPanel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button7;
        private Label label2;
        //private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private Label labelCustomerCount;
        private Label labelCarsOnRent;
        private Label label7;
        private Label labelCarCount;
        private Label label5;
        private Label labelRevenue;
        private Label label11;
        private Label labelCarsAvailable;
        private Label label9;
        private Button button3;
        private Panel panel6;
        private Controls.RoundedPanel roundedPanel1;
        private Controls.RoundedPanel roundedPanel2;
        private Controls.RoundedPanel roundedPanel3;
        private Controls.RoundedPanel roundedPanel4;
        private Controls.RoundedPanel roundedPanel5;
        private Controls.RoundedPanel roundedPanel6;
        private Controls.RoundedPanel roundedPanel7;
        private Label label3;
        private Label label4;
    }
}