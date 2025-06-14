using Car_Rental_System.Forms;
using Car_Rental_System.Models;
using Car_Rental_System.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Car_Rental_System
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e) // Save Button
        {
            var result = MessageBox.Show("Are you sure you want to save? Please double-check your information.", "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using var db = new CarRentalDbContext();

                var newCustomer = new Customer
                {
                    FirstName = textBox4.Text,
                    LastName = textBox11.Text,
                    MiddleInnitial = textBox5.Text,
                    Age = textBox10.Text,
                    ContactNumber = textBox9.Text,
                    LicenseNumber = textBox7.Text,
                    Email = textBox8.Text,
                    City = textBox3.Text,
                    Barangay = textBox1.Text,
                    ZipCode = textBox2.Text,
                };

                CustomerService.AddCustomer(newCustomer);
                db.SaveChanges();

                MessageBox.Show("Customer added successfully!");
            }
            else
            {
                // User chose NO — simply do nothing.
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e) // Contact
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
