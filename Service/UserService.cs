using System;
using CodingChallenge.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Service
{
    internal class UserService
    {
        public List<Users> usersList = new List<Users>();


        public void Register(Users user)
        {
            if (!UserExists(user.Username))
            {
                usersList.Add(user);
            }
            else
            {
                Console.WriteLine("UserName already exists.. Try Again !!!!");
            }
        }

        public bool Login(string username, string password)
        {
            Users user = FindUserByUsername(username);
            if (user != null && user.Password == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UserExists(string username)
        {
            foreach (Users user in usersList)
            {
                if (user.Username.Equals(username))
                {
                    return true;
                }
            }
            return false;
        }

        public Users FindUserByUsername(string username)
        {
            foreach (Users user in usersList)
            {
                if (user.Username.Equals(username))
                {
                    return user;
                }
            }
            return null;
        }


    }
}
