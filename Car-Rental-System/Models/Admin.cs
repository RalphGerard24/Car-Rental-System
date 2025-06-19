using System;

namespace Car_Rental_System.Models
{
    public class Admin
    {
        public int AdminId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set;  }

        public Admin(int adminId, string username, string passwordHash, string role)
        {
            AdminId = adminId;
            Username = username;
            PasswordHash = passwordHash;
            Role = role;
        }
    }
}