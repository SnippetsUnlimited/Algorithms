using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Company.Algorithms.Text.BloomFilter
{
    public class BloomFilter
    {
        private Dictionary<IHashFunction, HashSet<Int64>> index = new Dictionary<IHashFunction, HashSet<Int64>>();
        private bool IsInitialized = false;

        public void AddHashFunction(IHashFunction hashFunctions)
        {
            if (IsInitialized)
            {
                throw new Exception("Filter has been initizlized. More functions cannot be added.");
            }

            index.Add(hashFunctions, new HashSet<Int64>());
        }

        public void AddWord(string word)
        {
            if (!IsInitialized)
            {
                throw new Exception("Filter needs to be intialized before words are added.");
            }

            foreach (var item in index)
            {
                Int64 hashCode = item.Key.GetHashCode(word);
                item.Value.Add(hashCode);
            }
        }

        public void Initialize()
        {
            if (!IsInitialized)
            {
                IsInitialized = true;
            }
        }


        public Dictionary<string, bool> GetAnalysis(string word)
        {
            Dictionary<string, bool> result = new Dictionary<string, bool>();

            foreach (var item in index)
            {
                Int64 hashCode = item.Key.GetHashCode(word);
                bool exists = item.Value.Contains(hashCode);

                result.Add(item.Key.Name, exists);
            }

            return result;
        }

        public bool MayContain(string word)
        {
            var result = GetAnalysis(word);
            return (result.Count == result.Count(x => x.Value == true));
        }

    }


    public interface IHashFunction
    {
        string Name { get; }
        Int64 GetHashCode(string text);
    }

}