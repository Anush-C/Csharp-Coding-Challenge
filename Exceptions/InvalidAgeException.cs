using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Exceptions
{
    internal class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message): base(message) { }

        public void InvalidPetAge(int age)
        {
            if (age <= 0)
            {
                throw new InvalidAgeException("Age must be a positive integer");
            }
        }
    }
}
