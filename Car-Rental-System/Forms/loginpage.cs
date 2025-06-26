using Car_Rental_System.Models;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Car_Rental_System.Forms
{
    public partial class LoginPage : Form
    {
        // Constructor - Initializes the login form and sets up password masking
        public LoginPage()
        {
            InitializeComponent();

            textBox2.UseSystemPasswordChar = true;
            InitializeEventHandlers();
        }

        // Button Click Events
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            string hashedPassword = HashPassword(password);

            using (var db = new CarRentalDbContext())
            {
                var admin = db.Admins.FirstOrDefault(a => a.Username == username && a.PasswordHash == hashedPassword);

                if (admin != null)
                {
                    MessageBox.Show("Login successful!");

                    var dashboard = new AdminDashboard(admin);
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
        }

        // Private Helper Methods
        private void InitializeEventHandlers()
        {
            button1.Click += buttonLogin_Click;
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ApplyFont(this, FontManager.GlobalFont); // ← use the shared global font
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