namespace Car_Rental_System.Forms
{
    partial class RentalRecords
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
            button7 = new Button();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            roundedPanel1 = new Car_Rental_System.Controls.RoundedPanel();
            roundedPanel2 = new Car_Rental_System.Controls.RoundedPanel();
            roundedPanel4 = new Car_Rental_System.Controls.RoundedPanel();
            roundedPanel3 = new Car_Rental_System.Controls.RoundedPanel();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            roundedPanel1.SuspendLayout();
            roundedPanel2.SuspendLayout();
            roundedPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.FromArgb(154, 214, 212);
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(0, 76, 76);
            button3.Location = new Point(25, 609);
            button3.Name = "button3";
            button3.Size = new Size(214, 164);
            button3.TabIndex = 29;
            button3.Text = "Rental Records";
            button3.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.None;
            button7.BackColor = Color.FromArgb(154, 214, 212);
            button7.FlatStyle = FlatStyle.Popup;
            button7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button7.ForeColor = Color.FromArgb(0, 76, 76);
            button7.Location = new Point(1297, 47);
            button7.Name = "button7";
            button7.Size = new Size(230, 84);
            button7.TabIndex = 28;
            button7.Text = "Log Out";
            button7.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1388, 790);
            dataGridView1.TabIndex = 25;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.BackColor = Color.FromArgb(154, 214, 212);
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button4.ForeColor = Color.FromArgb(0, 76, 76);
            button4.Location = new Point(25, 417);
            button4.Name = "button4";
            button4.Size = new Size(214, 164);
            button4.TabIndex = 26;
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
            button2.Location = new Point(25, 225);
            button2.Name = "button2";
            button2.Size = new Size(214, 164);
            button2.TabIndex = 25;
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
            button1.Location = new Point(25, 28);
            button1.Name = "button1";
            button1.Size = new Size(214, 164);
            button1.TabIndex = 24;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 110, 108);
            label1.Location = new Point(24, 33);
            label1.Name = "label1";
            label1.Size = new Size(324, 69);
            label1.TabIndex = 23;
            label1.Text = "Car Rental";
            // 
            // roundedPanel1
            // 
            roundedPanel1.Anchor = AnchorStyles.None;
            roundedPanel1.BackColor = Color.FromArgb(0, 110, 108);
            roundedPanel1.Controls.Add(button1);
            roundedPanel1.Controls.Add(button3);
            roundedPanel1.Controls.Add(button4);
            roundedPanel1.Controls.Add(button2);
            roundedPanel1.CornerRadius = 20;
            roundedPanel1.Location = new Point(51, 157);
            roundedPanel1.Margin = new Padding(3, 4, 3, 4);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(265, 799);
            roundedPanel1.TabIndex = 30;
            // 
            // roundedPanel2
            // 
            roundedPanel2.Anchor = AnchorStyles.None;
            roundedPanel2.BackColor = Color.FromArgb(154, 214, 212);
            roundedPanel2.Controls.Add(roundedPanel4);
            roundedPanel2.Controls.Add(roundedPanel3);
            roundedPanel2.Controls.Add(label4);
            roundedPanel2.CornerRadius = 20;
            roundedPanel2.Location = new Point(349, 157);
            roundedPanel2.Margin = new Padding(3, 4, 3, 4);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(1173, 799);
            roundedPanel2.TabIndex = 31;
            // 
            // roundedPanel4
            // 
            roundedPanel4.Anchor = AnchorStyles.None;
            roundedPanel4.BackColor = Color.White;
            roundedPanel4.Controls.Add(dataGridView1);
            roundedPanel4.CornerRadius = 20;
            roundedPanel4.Location = new Point(26, 107);
            roundedPanel4.Margin = new Padding(3, 4, 3, 4);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(1122, 544);
            roundedPanel4.TabIndex = 4;
            // 
            // roundedPanel3
            // 
            roundedPanel3.Anchor = AnchorStyles.None;
            roundedPanel3.BackColor = Color.FromArgb(0, 110, 108);
            roundedPanel3.CornerRadius = 20;
            roundedPanel3.Location = new Point(19, 679);
            roundedPanel3.Margin = new Padding(3, 4, 3, 4);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(1129, 95);
            roundedPanel3.TabIndex = 3;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(17, 87, 99);
            label4.Location = new Point(26, 19);
            label4.Name = "label4";
            label4.Size = new Size(360, 54);
            label4.TabIndex = 2;
            label4.Text = "Rental Records";
            // 
            // RentalRecords
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1582, 1003);
            Controls.Add(roundedPanel2);
            Controls.Add(roundedPanel1);
            Controls.Add(button7);
            Controls.Add(label1);
            Name = "RentalRecords";
            StartPosition = FormStartPosition.Manual;
            Text = "Rental Records - Car Rental System";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            roundedPanel1.ResumeLayout(false);
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            roundedPanel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button7;
        private DataGridView dataGridView1;
        private Button button4;
        private Button button2;
        private Button button1;
        private Label label1;
        private Controls.RoundedPanel roundedPanel1;
        private Controls.RoundedPanel roundedPanel2;
        private Controls.RoundedPanel roundedPanel4;
        private Controls.RoundedPanel roundedPanel3;
        private Label label4;
    }
}