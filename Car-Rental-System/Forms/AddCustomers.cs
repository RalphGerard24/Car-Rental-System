using Car_Rental_System.Models;
using Car_Rental_System.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Car_Rental_System
{
    /// Form for adding new customers to the car rental system
    public partial class AddCustomers : Form
    {
        #region Constructor
        public AddCustomers()
        {
            InitializeComponent();
        }
        #endregion

        #region Button Click Events 
        /// Save button click handler - validates and saves new customer
        /// 

        private void button6_Click(object sender, EventArgs e)
        {
            // Perform comprehensive validation before saving
            if (!ValidateAllFields())
                return;

            // Confirm save operation with user
            var result = MessageBox.Show(
                "Are you sure you want to save? Please double-check your information.",
                "Confirm Save",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SaveCustomer();
            }
        }

        /// Close button click handler
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Private Helper Methods
 
        /// Validates all input fields for customer data
        /// <returns>True if all validations pass, false otherwise</returns>
        private bool ValidateAllFields()
        {
            // Check for required fields
            if (!ValidateRequiredFields())
                return false;

            // Validate text-only fields
            if (!ValidateTextFields())
                return false;

            // Validate middle initial if provided
            if (!ValidateMiddleInitial())
                return false;

            // Validate numeric fields
            if (!ValidateNumericFields())
                return false;

            // Validate email format
            if (!ValidateEmail())
                return false;

            if (!ValidateLicenseNumber()) 
                return false;


            return true;
        }

        /// Checks if all required fields are filled
        private bool ValidateRequiredFields()
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text) ||   // FirstName
                string.IsNullOrWhiteSpace(textBox11.Text) ||  // LastName
                string.IsNullOrWhiteSpace(textBox10.Text) ||  // Age
                string.IsNullOrWhiteSpace(textBox9.Text) ||   // Contact
                string.IsNullOrWhiteSpace(textBox8.Text) ||   // Email
                string.IsNullOrWhiteSpace(textBox7.Text) ||   // License #
                string.IsNullOrWhiteSpace(textBox3.Text) ||   // City
                string.IsNullOrWhiteSpace(textBox1.Text) ||   // Barangay
                string.IsNullOrWhiteSpace(textBox2.Text))     // Zipcode
            {
                MessageBox.Show("All fields except middle initial are required.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        /// Validates fields that should contain only letters
        private bool ValidateTextFields()
        {
            if (!IsOnlyLetters(textBox4.Text) ||   // FirstName
                !IsOnlyLetters(textBox11.Text) ||  // LastName
                !IsOnlyLetters(textBox3.Text) ||   // City
                !IsOnlyLetters(textBox1.Text))     // Barangay
            {
                MessageBox.Show("Name, City, and Barangay must contain letters only.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        /// Validates middle initial format if provided
        private bool ValidateMiddleInitial()
        {
            if (!string.IsNullOrWhiteSpace(textBox5.Text) &&
                (textBox5.Text.Length != 1 || !char.IsLetter(textBox5.Text[0])))
            {
                MessageBox.Show("Middle initial must be a single letter.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        /// Validates numeric fields (age, contact, zipcode)
        private bool ValidateNumericFields()
        {
            // Validate age
            if (!int.TryParse(textBox10.Text, out int age) || age < 18)
            {
                MessageBox.Show("Age must be a number and at least 18.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate contact number
            if (!IsDigits(textBox9.Text) || textBox9.Text.Length != 11)
            {
                MessageBox.Show("Contact number must be exactly 11 digits.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate zip code
            if (!IsDigits(textBox2.Text))
            {
                MessageBox.Show("Zip Code must be numeric.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool ValidateLicenseNumber()
        {
            string license = textBox7.Text.Trim().ToUpper();

            // Pattern: 1 letter + 2 digits, dash, 3 digits, dash, 6 digits
            if (!System.Text.RegularExpressions.Regex.IsMatch(license, @"^[A-Z]\d{2}-\d{3}-\d{6}$"))
            {
                MessageBox.Show("License Number format is invalid.\nExpected format: LDD-DDD-DDDDDD",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        /// Validates email format
        private bool ValidateEmail()
        {
            if (!textBox8.Text.Contains("@") || !textBox8.Text.Contains("."))
            {
                MessageBox.Show("Email format is invalid.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        /// Creates and saves the new customer object
        private void SaveCustomer()
        {
            try
            {
                var newCustomer = new Customer
                {
                    FirstName = textBox4.Text.Trim(),
                    LastName = textBox11.Text.Trim(),
                    MiddleInnitial = textBox5.Text.Trim(),
                    Age = textBox10.Text.Trim(),
                    ContactNumber = textBox9.Text.Trim(),
                    LicenseNumber = textBox7.Text.Trim(),
                    Email = textBox8.Text.Trim(),
                    City = textBox3.Text.Trim(),
                    Barangay = textBox1.Text.Trim(),
                    ZipCode = textBox2.Text.Trim()
                };

                CustomerService.AddCustomer(newCustomer);
                MessageBox.Show("Customer added successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving customer: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// Helper method to check if string contains only letters and spaces
        private bool IsOnlyLetters(string input) => input.All(c => char.IsLetter(c) || c == ' ');

        /// Helper method to check if string contains only digits

        private bool IsDigits(string input) => input.All(char.IsDigit);
        #endregion

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ApplyFont(this, FontManager.GlobalFont); // use the shared global font
        }

        private void ApplyFont(Control parent, Font font)
        {
            foreach (Control ctrl in parent.Controls)
            {
                // Keep size and style, only change font family
                ctrl.Font = new Font(font.FontFamily, ctrl.Font.Size, ctrl.Font.Style);

                if (ctrl.HasChildren)
                    ApplyFont(ctrl, font);
            }
        }

    }


}