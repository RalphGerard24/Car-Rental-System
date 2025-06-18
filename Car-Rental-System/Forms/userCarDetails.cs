using Car_Rental_System.Services;
using Car_Rental_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_System
{
    public partial class userCarDetails : Form
    {
        private Customer _currentCustomer;
        private Car selectedCar;
        

        public userCarDetails(Car car, Customer customer)
        {
            InitializeComponent();
            selectedCar = car;
            _currentCustomer = customer;
            LoadCarData();
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            userRentStep1 rentForm = new userRentStep1(_currentCustomer);
            rentForm.Show();
            this.Hide();
        }

        private void LoadCarData()
        {
            textBox1.Text = selectedCar.CarId.ToString();
            textBox2.Text = selectedCar.Model;
            textBox5.Text = selectedCar.PriceRate.ToString();
            textBox6.Text = selectedCar.Color;
            textBox4.Text = selectedCar.PlateNumber;
            textBox3.Text = selectedCar.DateRegistered.ToShortDateString();
            textBox7.Text = selectedCar.Brand;
            pictureBox1.Image = Image.FromFile(selectedCar.ImagePath);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
