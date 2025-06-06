using System;
using System.Runtime.CompilerServices;

namespace Car_Rental_System.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? MiddleInnitial { get; set; }
        public string ContactNumber { get; set; }
        public string LicenseNumber { get; set; }
        public string Email { get; set; }

        public string ZipCode { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string Barangay { get; set; }

        public Customer(int customerId, string firstName, string lastName, string middleInnitial, string contactNumber, string licenseNumber, string email, string zipCode, string region, string city, string barangay)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            MiddleInnitial = middleInnitial;
            ContactNumber = contactNumber;
            LicenseNumber = licenseNumber;
            Email = email;

            ZipCode = zipCode;
            Region = region;
            City = city;
            Barangay = barangay;

        }

        public static void CustomerTest()
        {
            Console.WriteLine("Customer.cs is used successfully!!!");
        }

        //public void CustomerInfo()
        //{
        //    Console.WriteLine($"CustomerId: {CustomerId}, Name: {CustomerName}, Contact: {Contact}");
        //}
    }
}