using Car_Rental_System.Forms;
using Car_Rental_System.Models;
using Car_Rental_System.Services;
using System;
using System.Linq;
using System.Windows.Forms;



namespace Car_Rental_System
{
    public partial class CustomerRentConfirmed : Form
    {
        private int _customerId;
        private int _carId;
        private string _transactionId;
        private Admin _admin;

        public CustomerRentConfirmed(int customerId, int carId, string transactionId, Admin admin)
        {
            InitializeComponent();
            _customerId = customerId;
            _carId = carId;
            _transactionId = transactionId;
            _admin = admin;
            LoadRentData();
        }

        private void LoadRentData()
        {
            textBox1.Text = _customerId.ToString();
            textBox2.Text = _carId.ToString();
            textBox4.Text = _transactionId;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You successfully rented the car.");
            var dashboard = new AdminDashboard(_admin);
            dashboard.Show();
            this.Close();
        }

    }


}

