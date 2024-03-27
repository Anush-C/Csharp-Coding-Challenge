using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Models
{
    public class Pets
    {
        int petID;
        string pet_name;
        string species;
        int age;
        string breed;
        int available_status;

        public int PetID { get { return petID; }set { petID = value; } }
        public string Name { get { return pet_name; } set { pet_name = value; } }

        public string Species { get { return species; } set { species = value; } }  

        public int Age { get { return age; } set { age = value; } }
        public string Breed { get {  return breed; } set {  breed = value; } }

        public int Available_status { get { return available_status; } set { available_status = value; } }

        public Pets() { }

        public Pets(int petID,string name,string species, int age, string breed, int available_status)
        {
            PetID=petID;
            Name = name;
            Species =species;
            Age = age;
            Breed = breed;
            Available_status = available_status;
        }

        public override string ToString()
        {
            return $"{PetID} {Name} {Species} {Age} {Breed} {Available_status} ) ";
        }
    }
}
