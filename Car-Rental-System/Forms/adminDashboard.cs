using Car_Rental_System.Models;
using System;
using System.Windows.Forms;

namespace Car_Rental_System.Forms
{
    public partial class AdminDashboard : Form
    {
        private readonly Admin _currentAdmin;

        public AdminDashboard(Admin admin)
        {
            InitializeComponent();
            _currentAdmin = admin;

            // Navigation buttons
            button1.Click += (s, e) => { };

            button2.Click += (s, e) =>
            {
                var ManageCarsForm = new ManageCars(_currentAdmin);
                ManageCarsForm.FormClosed += (_, __) => this.Close();
                this.Hide();
                ManageCarsForm.Show();
            };

            button4.Click += (s, e) =>
            {
                var ManageCustomerForm = new ManageCustomer(_currentAdmin);
                ManageCustomerForm.FormClosed += (_, __) => this.Close();
                this.Hide();
                ManageCustomerForm.Show();
            };

            button5.Click += (s, e) =>
            {
                string customerID = textBox1.Text;
                var detailsForm = new CustomerDetails(customerID);
                detailsForm.FormClosed += (_, __) => this.Show();
                detailsForm.Show();
                //this.Hide();
            };

            button6.Click += (s, e) =>
            {
                string customerID = textBox14.Text;
                var detailsForm = new CustomerDetails(customerID);
                detailsForm.FormClosed += (_, __) => this.Show();
                detailsForm.Show();
                //this.Hide();
            };
        }
    }
}