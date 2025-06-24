using Car_Rental_System.Models;
using Car_Rental_System.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Car_Rental_System
{
    public partial class AddCustomers : Form
    {
        public AddCustomers()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool IsOnlyLetters(string input) => input.All(c => char.IsLetter(c) || c == ' ');
            bool IsDigits(string input) => input.All(char.IsDigit);

            // --- Validation ---
            if (string.IsNullOrWhiteSpace(textBox4.Text) ||  // FirstName
                string.IsNullOrWhiteSpace(textBox11.Text) || // LastName
                string.IsNullOrWhiteSpace(textBox10.Text) || // Age
                string.IsNullOrWhiteSpace(textBox9.Text) ||  // Contact
                string.IsNullOrWhiteSpace(textBox8.Text) ||  // Email
                string.IsNullOrWhiteSpace(textBox7.Text) ||  // License #
                string.IsNullOrWhiteSpace(textBox3.Text) ||  // City
                string.IsNullOrWhiteSpace(textBox1.Text) ||  // Barangay
                string.IsNullOrWhiteSpace(textBox2.Text))    // Zipcode
            {
                MessageBox.Show("All fields except middle initial are required.");
                return;
            }

            if (!IsOnlyLetters(textBox4.Text) || !IsOnlyLetters(textBox11.Text) ||
                !IsOnlyLetters(textBox3.Text) || !IsOnlyLetters(textBox1.Text))
            {
                MessageBox.Show("Name, City, and Barangay must contain letters only.");
                return;
            }

            if (!string.IsNullOrWhiteSpace(textBox5.Text) &&
                (textBox5.Text.Length != 1 || !char.IsLetter(textBox5.Text[0])))
            {
                MessageBox.Show("Middle initial must be a single letter.");
                return;
            }

            if (!int.TryParse(textBox10.Text, out int age) || age < 18)
            {
                MessageBox.Show("Age must be a number and at least 18.");
                return;
            }

            if (!IsDigits(textBox9.Text) || textBox9.Text.Length != 11)
            {
                MessageBox.Show("Contact number must be exactly 11 digits.");
                return;
            }

            if (!IsDigits(textBox2.Text))
            {
                MessageBox.Show("Zip Code must be numeric.");
                return;
            }

            if (!textBox8.Text.Contains("@") || !textBox8.Text.Contains("."))
            {
                MessageBox.Show("Email format is invalid.");
                return;
            }

            // --- Confirm Save ---
            var result = MessageBox.Show(
                "Are you sure you want to save? Please double-check your information.",
                "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
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
                    ZipCode = textBox2.Text
                };

                CustomerService.AddCustomer(newCustomer);
                MessageBox.Show("Customer added successfully!");
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void textBox5_TextChanged(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void textBox7_TextChanged(object sender, EventArgs e) { }
        private void label13_Click(object sender, EventArgs e) { }
        private void textBox8_TextChanged(object sender, EventArgs e) { }
        private void label16_Click(object sender, EventArgs e) { }
        private void label14_Click(object sender, EventArgs e) { }
        private void textBox11_TextChanged(object sender, EventArgs e) { }
        private void textBox9_TextChanged(object sender, EventArgs e) { }
        private void textBox10_TextChanged(object sender, EventArgs e) { }
    }

}
