using CodingChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Exceptions
{
    internal class AdoptionException : Exception
    {
        public AdoptionException(string message): base(message) { }

        public void AdoptPet(Pets pet)
        {
            if (pet == null)
            {
                throw new AdoptionException($"Error: Pet {pet.Name} is not available for adoption");
            }
        }
    }
}
