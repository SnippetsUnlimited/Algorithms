using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Company.Algorithms.Text.BloomFilter
{
    public class CustomHashFunction01 : IHashFunction
    {
        public string Name { get { return "APHash"; } }
        
        public Int64 GetHashCode(string text)
        {
            return HashFunctions.APHash(text);
        }
    }
}
