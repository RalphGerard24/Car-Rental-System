using Car_Rental_System.Models;
using Car_Rental_System.Services;
using System;
using System.Linq;
using System.Windows.Forms;



namespace Car_Rental_System
{
    public partial class userRentConfirmed : Form
    {
        private int _customerId;
        private int _carId;
        private string _transactionId;


        public userRentConfirmed(int customerId, int carId, string transactionId)
        {
            InitializeComponent();
            _customerId = customerId;
            _carId = carId;
            _transactionId = transactionId;
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
            this.Close();
        }

    }


}

