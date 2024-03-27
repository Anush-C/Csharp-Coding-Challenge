using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Models
{
    internal class Cats : Pets
    {
        string catcolor;

        public string Catcolor { get {  return catcolor; } set {  catcolor = value; } } 

        public Cats() { }   

        public Cats(int petID,string name,string species, int age, string breed,int available_status, string catcolor) : base(petID,name,species, age, breed,available_status)
        {
            Catcolor = catcolor;
        }

        public override string ToString()
        {
            return $"{PetID},{Name},{Species},{Age},{Breed},{Available_status},{Catcolor}";
        }
    }
}
