namespace Car_Rental_System.Forms
{
    partial class ManageCustomer
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
            button7 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            label1 = new Label();
            roundedPanel1 = new Car_Rental_System.Controls.RoundedPanel();
            label4 = new Label();
            roundedPanel3 = new Car_Rental_System.Controls.RoundedPanel();
            button5 = new Button();
            roundedPanel4 = new Car_Rental_System.Controls.RoundedPanel();
            dataGridView1 = new DataGridView();
            roundedPanel2 = new Car_Rental_System.Controls.RoundedPanel();
            roundedPanel1.SuspendLayout();
            roundedPanel3.SuspendLayout();
            roundedPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            roundedPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.None;
            button7.BackColor = Color.FromArgb(154, 214, 212);
            button7.FlatStyle = FlatStyle.Popup;
            button7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button7.ForeColor = Color.FromArgb(0, 76, 76);
            button7.Location = new Point(1132, 29);
            button7.Name = "button7";
            button7.Size = new Size(201, 63);
            button7.TabIndex = 21;
            button7.Text = "Log Out";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
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
            button4.TabIndex = 18;
            button4.Text = "Customers";
            button4.UseVisualStyleBackColor = false;
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
            button2.TabIndex = 17;
            button2.Text = "Manage Cars";
            button2.UseVisualStyleBackColor = false;
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
            button1.TabIndex = 16;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = false;
           // button1.Click += button1_Click;
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
            button3.TabIndex = 22;
            button3.Text = "Rental Records";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 110, 108);
            label1.Location = new Point(20, 29);
            label1.Name = "label1";
            label1.Size = new Size(324, 69);
            label1.TabIndex = 15;
            label1.Text = "Car Rental";
            // 
            // roundedPanel1
            // 
            roundedPanel1.Anchor = AnchorStyles.None;
            roundedPanel1.BackColor = Color.FromArgb(0, 110, 108);
            roundedPanel1.Controls.Add(button3);
            roundedPanel1.Controls.Add(button4);
            roundedPanel1.Controls.Add(button2);
            roundedPanel1.Controls.Add(button1);
            roundedPanel1.CornerRadius = 20;
            roundedPanel1.Location = new Point(42, 112);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(232, 599);
            roundedPanel1.TabIndex = 23;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(17, 87, 99);
            label4.Location = new Point(23, 14);
            label4.Name = "label4";
            label4.Size = new Size(260, 54);
            label4.TabIndex = 2;
            label4.Text = "Customers";
            // 
            // roundedPanel3
            // 
            roundedPanel3.Anchor = AnchorStyles.None;
            roundedPanel3.BackColor = Color.FromArgb(0, 110, 108);
            roundedPanel3.Controls.Add(button5);
            roundedPanel3.CornerRadius = 20;
            roundedPanel3.Location = new Point(17, 509);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(988, 71);
            roundedPanel3.TabIndex = 3;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.BackColor = Color.FromArgb(154, 214, 212);
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button5.ForeColor = Color.FromArgb(0, 76, 76);
            button5.Location = new Point(774, 15);
            button5.Name = "button5";
            button5.Size = new Size(192, 45);
            button5.TabIndex = 26;
            button5.Text = "Add Customer";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // roundedPanel4
            // 
            roundedPanel4.Anchor = AnchorStyles.None;
            roundedPanel4.BackColor = Color.White;
            roundedPanel4.Controls.Add(dataGridView1);
            roundedPanel4.CornerRadius = 20;
            roundedPanel4.Location = new Point(23, 80);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(982, 408);
            roundedPanel4.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(5, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(971, 396);
            dataGridView1.TabIndex = 25;
          //  dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // roundedPanel2
            // 
            roundedPanel2.Anchor = AnchorStyles.None;
            roundedPanel2.BackColor = Color.FromArgb(154, 214, 212);
            roundedPanel2.Controls.Add(roundedPanel4);
            roundedPanel2.Controls.Add(roundedPanel3);
            roundedPanel2.Controls.Add(label4);
            roundedPanel2.CornerRadius = 20;
            roundedPanel2.Location = new Point(303, 112);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(1026, 599);
            roundedPanel2.TabIndex = 24;
            // 
            // ManageCustomer
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1368, 741);
            Controls.Add(roundedPanel2);
            Controls.Add(roundedPanel1);
            Controls.Add(button7);
            Controls.Add(label1);
            Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximumSize = new Size(1386, 788);
            MinimumSize = new Size(1364, 766);
            Name = "ManageCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customers - Car Rental System";
            WindowState = FormWindowState.Maximized;
            //Load += ManageCustomer_Load;
            roundedPanel1.ResumeLayout(false);
            roundedPanel3.ResumeLayout(false);
            roundedPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button7;
        private Button button4;
        private Button button2;
        private Button button1;
        private Button button3;
        private Label label1;
        private Controls.RoundedPanel roundedPanel1;
        private Label label4;
        private Controls.RoundedPanel roundedPanel3;
        private Button button5;
        private Controls.RoundedPanel roundedPanel4;
        private DataGridView dataGridView1;
        private Controls.RoundedPanel roundedPanel2;
    }
}