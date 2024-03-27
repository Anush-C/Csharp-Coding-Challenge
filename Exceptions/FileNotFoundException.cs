using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Exceptions
{
    internal class FileNotFoundException : Exception
    {
        public FileNotFoundException(string message): base(message) { }

        public void FileNotFound(string filepath)
        {
            if(!File.Exists(filepath))
            {
                throw new FileNotFoundException($"Error: File {filepath} does not exist");
            }
        }
    }
}
