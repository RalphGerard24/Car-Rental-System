using System;

namespace Car_Rental_System.Models
{
    public class Admin
    {
        public int AdminId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set;  }

        public Admin(int adminId, string username, string password, string role)
        {
            AdminId = adminId;
            Username = username;
            Password = password;
            Role = role;
        }

        public static void AdminTest()
        {
            Console.WriteLine("Admin.cs is used successfully!!!");
        }
    }
}