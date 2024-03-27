using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Exceptions
{
    internal class NullReferenceExceptions : Exception
    {
        public NullReferenceExceptions(string message): base(message) { }

        public void NullReferencePet(string name, int? age)
        {
            if(name==null || age== null)
            {
                throw new NullReferenceException("Error: Pet Info is missing..");
            }
        }

    }
}
