using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Exceptions
{
    internal class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(string message): base(message) { }

        decimal min_amount= 10.00m;

        public void InsufficientFunds(decimal donationAmount , decimal min_amount)
        {
            if(donationAmount < min_amount)
            {
                throw new InsufficientFundsException($"Error: Donation amount must be atleast {min_amount:C}");
            }
        }


    }
}
