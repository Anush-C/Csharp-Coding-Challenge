using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Models
{
    public class Users
    {
        // Properties
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public string Password {  get; set; }

        // Default Constructor
        public Users()
        {
        }

        // Parameterized Constructor
        public Users(int userID, string username, string email, string fullName, string address, string phoneNumber, string password)
        {
            UserID = userID;
            Username = username;
            Email = email;
            FullName = fullName;
            Address = address;
            PhoneNumber = phoneNumber;
            Password = password;
        }

        // ToString method
        public override string ToString()
        {
            return $"UserID: {UserID}, Username: {Username}, Email: {Email}, FullName: {FullName}, Address: {Address}, PhoneNumber: {PhoneNumber} {Password}";
        }
    }

}
