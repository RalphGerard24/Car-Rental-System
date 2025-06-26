namespace Car_Rental_System.Forms
{
    partial class ManageCars
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
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            comboBox2 = new ComboBox();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            comboBox1 = new ComboBox();
            button6 = new Button();
            button4 = new Button();
            button2 = new Button();
            label1 = new Label();
            button3 = new Button();
            roundedPanel1 = new Car_Rental_System.Controls.RoundedPanel();
            button1 = new Button();
            roundedPanel2 = new Car_Rental_System.Controls.RoundedPanel();
            roundedPanel4 = new Car_Rental_System.Controls.RoundedPanel();
            roundedPanel3 = new Car_Rental_System.Controls.RoundedPanel();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            roundedPanel1.SuspendLayout();
            roundedPanel2.SuspendLayout();
            roundedPanel4.SuspendLayout();
            roundedPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.None;
            button7.BackColor = Color.FromArgb(154, 214, 212);
            button7.FlatStyle = FlatStyle.Popup;
            button7.Font = new Font("Poppins Medium", 12F, FontStyle.Bold);
            button7.ForeColor = Color.FromArgb(0, 76, 76);
            button7.Location = new Point(1128, 27);
            button7.Name = "button7";
            button7.Size = new Size(201, 63);
            button7.TabIndex = 14;
            button7.Text = "Log Out";
            button7.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            radioButton3.AccessibleName = "rentedRadioButton";
            radioButton3.Anchor = AnchorStyles.None;
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Poppins", 12F);
            radioButton3.ForeColor = Color.White;
            radioButton3.Location = new Point(629, 20);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(87, 32);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Rented";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AccessibleName = "availableRadioButton";
            radioButton2.Anchor = AnchorStyles.None;
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Poppins", 12F);
            radioButton2.ForeColor = Color.White;
            radioButton2.Location = new Point(501, 20);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(105, 32);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Available";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AccessibleName = "allRadioButton";
            radioButton1.Anchor = AnchorStyles.None;
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Poppins", 12F);
            radioButton1.ForeColor = Color.White;
            radioButton1.Location = new Point(419, 20);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(49, 32);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "All";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.AccessibleName = "yearComboBox";
            comboBox2.Anchor = AnchorStyles.None;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(240, 23);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 25);
            comboBox2.TabIndex = 26;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.FromArgb(154, 214, 212);
            dataGridView1.Location = new Point(7, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(967, 396);
            dataGridView1.TabIndex = 25;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(22, 23);
            label2.Name = "label2";
            label2.Size = new Size(74, 28);
            label2.TabIndex = 24;
            label2.Text = "Filter by";
            label2.Click += label2_Click;
            // 
            // comboBox1
            // 
            comboBox1.AccessibleName = "brandComboBox";
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(110, 23);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 25);
            comboBox1.TabIndex = 23;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.None;
            button6.BackColor = Color.FromArgb(154, 214, 212);
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Poppins Medium", 12F, FontStyle.Bold);
            button6.ForeColor = Color.FromArgb(0, 76, 76);
            button6.Location = new Point(773, 14);
            button6.Name = "button6";
            button6.Size = new Size(192, 45);
            button6.TabIndex = 22;
            button6.Text = "Add";
            button6.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.BackColor = Color.FromArgb(154, 214, 212);
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Poppins Medium", 12F, FontStyle.Bold);
            button4.ForeColor = Color.FromArgb(0, 76, 76);
            button4.Location = new Point(22, 313);
            button4.Name = "button4";
            button4.Size = new Size(187, 123);
            button4.TabIndex = 11;
            button4.Text = "Customers";
            button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.FromArgb(154, 214, 212);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Poppins Medium", 12F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(0, 76, 76);
            button2.Location = new Point(22, 169);
            button2.Name = "button2";
            button2.Size = new Size(187, 123);
            button2.TabIndex = 10;
            button2.Text = "Manage Cars";
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 36F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 110, 108);
            label1.Location = new Point(33, 27);
            label1.Name = "label1";
            label1.Size = new Size(295, 84);
            label1.TabIndex = 8;
            label1.Text = "Car Rental";
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.FromArgb(154, 214, 212);
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Poppins Medium", 12F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(0, 76, 76);
            button3.Location = new Point(22, 457);
            button3.Name = "button3";
            button3.Size = new Size(187, 123);
            button3.TabIndex = 15;
            button3.Text = "Rental Records";
            button3.UseVisualStyleBackColor = false;
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
            roundedPanel1.Location = new Point(42, 112);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(232, 599);
            roundedPanel1.TabIndex = 16;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(154, 214, 212);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Poppins Medium", 12F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(0, 76, 76);
            button1.Location = new Point(22, 21);
            button1.Name = "button1";
            button1.Size = new Size(187, 123);
            button1.TabIndex = 9;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = false;
            // 
            // roundedPanel2
            // 
            roundedPanel2.Anchor = AnchorStyles.None;
            roundedPanel2.BackColor = Color.FromArgb(154, 214, 212);
            roundedPanel2.Controls.Add(roundedPanel4);
            roundedPanel2.Controls.Add(roundedPanel3);
            roundedPanel2.Controls.Add(label3);
            roundedPanel2.CornerRadius = 20;
            roundedPanel2.Location = new Point(303, 112);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(1026, 599);
            roundedPanel2.TabIndex = 17;
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
            // roundedPanel3
            // 
            roundedPanel3.Anchor = AnchorStyles.None;
            roundedPanel3.BackColor = Color.FromArgb(0, 110, 108);
            roundedPanel3.Controls.Add(radioButton3);
            roundedPanel3.Controls.Add(radioButton2);
            roundedPanel3.Controls.Add(comboBox1);
            roundedPanel3.Controls.Add(radioButton1);
            roundedPanel3.Controls.Add(comboBox2);
            roundedPanel3.Controls.Add(button6);
            roundedPanel3.Controls.Add(label2);
            roundedPanel3.CornerRadius = 20;
            roundedPanel3.Location = new Point(17, 509);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(988, 71);
            roundedPanel3.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(17, 87, 99);
            label3.Location = new Point(23, 14);
            label3.Name = "label3";
            label3.Size = new Size(283, 65);
            label3.TabIndex = 2;
            label3.Text = "Manage Cars";
            // 
            // ManageCars
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1370, 749);
            Controls.Add(roundedPanel2);
            Controls.Add(roundedPanel1);
            Controls.Add(button7);
            Controls.Add(label1);
            Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximumSize = new Size(1386, 788);
            MinimumSize = new Size(1364, 766);
            Name = "ManageCars";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Cars - Car Rental System";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            roundedPanel1.ResumeLayout(false);
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            roundedPanel4.ResumeLayout(false);
            roundedPanel3.ResumeLayout(false);
            roundedPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button7;
        private Button button4;
        private Button button2;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Button button6;
        private DataGridView dataGridView1;
        private ComboBox comboBox2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButton3;
        private Button button3;
        private Controls.RoundedPanel roundedPanel1;
        private Button button1;
        private Controls.RoundedPanel roundedPanel2;
        private Label label3;
        private Controls.RoundedPanel roundedPanel4;
        private Controls.RoundedPanel roundedPanel3;
    }

    }