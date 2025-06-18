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
            groupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
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
            button1 = new Button();
            label1 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button7
            // 
            button7.Location = new Point(1084, 39);
            button7.Name = "button7";
            button7.Size = new Size(114, 62);
            button7.TabIndex = 14;
            button7.Text = "Log Out";
            button7.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox1);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(button6);
            groupBox2.Font = new Font("Arial", 11.25F);
            groupBox2.Location = new Point(305, 107);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(913, 486);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Manage Cars";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(351, 445);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(422, 35);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // radioButton3
            // 
            radioButton3.AccessibleName = "rentedRadioButton";
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(249, 0);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(93, 26);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Rented";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AccessibleName = "availableRadioButton";
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(115, 0);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(107, 26);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Available";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AccessibleName = "allRadioButton";
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(28, 1);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(52, 26);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "All";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += FilterAvailability_CheckedChanged;
            // 
            // comboBox2
            // 
            comboBox2.AccessibleName = "yearComboBox";
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(224, 445);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 30);
            comboBox2.TabIndex = 26;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(870, 396);
            dataGridView1.TabIndex = 25;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 448);
            label2.Name = "label2";
            label2.Size = new Size(77, 22);
            label2.TabIndex = 24;
            label2.Text = "Filter by";
            // 
            // comboBox1
            // 
            comboBox1.AccessibleName = "brandComboBox";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(97, 445);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 30);
            comboBox1.TabIndex = 23;
            // 
            // button6
            // 
            button6.Location = new Point(779, 445);
            button6.Name = "button6";
            button6.Size = new Size(114, 25);
            button6.TabIndex = 22;
            button6.Text = "Add";
            button6.UseVisualStyleBackColor = true;
            button6.Click += AddNewCarButton_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Arial", 11.25F);
            button4.Location = new Point(41, 368);
            button4.Name = "button4";
            button4.Size = new Size(245, 99);
            button4.TabIndex = 11;
            button4.Text = "Customers";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 11.25F);
            button2.Location = new Point(41, 241);
            button2.Name = "button2";
            button2.Size = new Size(245, 99);
            button2.TabIndex = 10;
            button2.Text = "Manage Cars";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 11.25F);
            button1.Location = new Point(41, 116);
            button1.Name = "button1";
            button1.Size = new Size(245, 99);
            button1.TabIndex = 9;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 28);
            label1.Name = "label1";
            label1.Size = new Size(328, 68);
            label1.TabIndex = 8;
            label1.Text = "Car Rental";
            // 
            // ManageCars
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 622);
            Controls.Add(button7);
            Controls.Add(groupBox2);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "ManageCars";
            Text = "Manage Cars - Car Rental System";
            Load += ManageCar_Loads;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button7;
        private GroupBox groupBox2;        
        private Button button4;
        private Button button2;
        private Button button1;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Button button6;
        private DataGridView dataGridView1;
        private ComboBox comboBox2;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButton3;
    }

    }