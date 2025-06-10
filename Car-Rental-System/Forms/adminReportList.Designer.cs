namespace gumana_ka_be_pls
{
    partial class adminReportList
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
            label2 = new Label();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(23, 434);
            button3.Name = "button3";
            button3.Size = new Size(214, 87);
            button3.TabIndex = 33;
            button3.Text = "Reports";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(23, 323);
            button4.Name = "button4";
            button4.Size = new Size(214, 87);
            button4.TabIndex = 32;
            button4.Text = "Customers";
            button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(23, 211);
            button2.Name = "button2";
            button2.Size = new Size(214, 87);
            button2.TabIndex = 31;
            button2.Text = "Manage Cars";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(23, 100);
            button1.Name = "button1";
            button1.Size = new Size(214, 87);
            button1.TabIndex = 30;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(5, 23);
            label1.Name = "label1";
            label1.Size = new Size(265, 55);
            label1.TabIndex = 29;
            label1.Text = "Car Rental";
            // 
            // button7
            // 
            button7.Location = new Point(978, 23);
            button7.Name = "button7";
            button7.Size = new Size(75, 55);
            button7.TabIndex = 35;
            button7.Text = "Log Out";
            button7.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Location = new Point(254, 92);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(799, 429);
            groupBox2.TabIndex = 34;
            groupBox2.TabStop = false;
            groupBox2.Text = "Reports";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F);
            label2.Location = new Point(18, 394);
            label2.Name = "label2";
            label2.Size = new Size(59, 17);
            label2.TabIndex = 40;
            label2.Text = "Filter by";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Arial", 11.25F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(92, 391);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 25);
            comboBox1.TabIndex = 39;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(762, 351);
            dataGridView1.TabIndex = 41;
            // 
            // adminReportList
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
            Name = "adminReportList";
            Text = "Form1";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Label label2;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
    }
}