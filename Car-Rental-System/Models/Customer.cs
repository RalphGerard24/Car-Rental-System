using System;
using System.Runtime.CompilerServices;

namespace Car_Rental_System.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Contact { get; set; }

        public Customer() { }
        public Customer(int customerId, string customerName, string contact)
        {
            CustomerId = customerId;
            CustomerName = customerName;
            Contact = contact;
        }

        public static void CustomerTest()
        {
            Console.WriteLine("Customer.cs is used successfully!!!");
        }

        public void CustomerInfo()
        {
            Console.WriteLine($"CustomerId: {CustomerId}, Name: {CustomerName}, Contact: {Contact}");
        }
    }
}