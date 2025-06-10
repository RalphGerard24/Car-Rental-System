namespace Car_Rental_System.Forms
{
    partial class customers
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
            dataGridView1 = new DataGridView();
            label2 = new Label();
            comboBox1 = new ComboBox();
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button7
            // 
            button7.Location = new Point(1132, 29);
            button7.Name = "button7";
            button7.Size = new Size(86, 62);
            button7.TabIndex = 21;
            button7.Text = "Log Out";
            button7.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Font = new Font("Arial", 11.25F);
            groupBox2.Location = new Point(304, 108);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(913, 486);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Customers";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(870, 396);
            dataGridView1.TabIndex = 25;
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
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(97, 445);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 30);
            comboBox1.TabIndex = 23;
            // 
            // button3
            // 
            button3.Font = new Font("Arial", 11.25F);
            button3.Location = new Point(40, 495);
            button3.Name = "button3";
            button3.Size = new Size(245, 99);
            button3.TabIndex = 19;
            button3.Text = "Reports";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Arial", 11.25F);
            button4.Location = new Point(40, 369);
            button4.Name = "button4";
            button4.Size = new Size(245, 99);
            button4.TabIndex = 18;
            button4.Text = "Customers";
            button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 11.25F);
            button2.Location = new Point(40, 242);
            button2.Name = "button2";
            button2.Size = new Size(245, 99);
            button2.TabIndex = 17;
            button2.Text = "Manage Cars";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 11.25F);
            button1.Location = new Point(40, 117);
            button1.Name = "button1";
            button1.Size = new Size(245, 99);
            button1.TabIndex = 16;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 29);
            label1.Name = "label1";
            label1.Size = new Size(328, 68);
            label1.TabIndex = 15;
            label1.Text = "Car Rental";
            // 
            // customers
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 614);
            Controls.Add(button7);
            Controls.Add(groupBox2);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "customers";
            Text = "Form1";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button7;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Label label2;
        private ComboBox comboBox1;
        private Button button3;
        private Button button4;
        private Button button2;
        private Button button1;
        private Label label1;
    }
}