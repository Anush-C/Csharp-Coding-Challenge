using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Models
{
    internal class Dogs : Pets
    {
        string dogbreed;

        public string Dogbreed {  get {  return dogbreed; } set {  dogbreed = value; } }    

        public Dogs() { }   

        public Dogs(int petID, string name,string species, int age, string breed,int available_status,string dogbreed): base(petID,name,species, age, breed, available_status) 
        {
            Dogbreed = dogbreed;
        }

        public override string ToString()
        {
            return $"{PetID} {Name} {Species} {Age} {Breed} {Available_status}{Dogbreed}";
        }
    }
}
