using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Car_Rental_System.Models;
using System.Security.Cryptography;

namespace Car_Rental_System.Forms
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);

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
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text;
            string hashedPassword = HashPassword(password);

            using (var db = new CarRentalDbContext())
            {
                var admin = db.Admins.FirstOrDefault(a => a.Username == username && a.PasswordHash == hashedPassword);

                if (admin != null)
                {
                    MessageBox.Show("Login successful!");

                    AdminDashboard dashboard = new AdminDashboard(admin);
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
        }


    }
}
