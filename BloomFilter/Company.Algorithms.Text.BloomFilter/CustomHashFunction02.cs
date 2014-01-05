using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Company.Algorithms.Text.BloomFilter
{
    public class CustomHashFunction02 : IHashFunction
    {
        public string Name { get { return "ELFHash"; } }

        public Int64 GetHashCode(string text)
        {
            return HashFunctions.ELFHash(text);
        }
    }
}
