using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Company.Algorithms.Text.Trie
{

    public class TrieNode : Dictionary<char, TrieNode>
    {
        public string Word { get; set; }
    }

    public class Trie
    {

        private TrieNode root = new TrieNode();

        public void AddWord(string word)
        {
            if (root == null)
            {
                root = new TrieNode();
            }


            var node = root;

            for (int x = 0; x < word.Length; x++)
            {
                if (!node.ContainsKey(word[x]))
                {
                    var child = new TrieNode();
                    node.Add(word[x], child);
                    node = child;
                }
                else
                {
                    node = node[word[x]];
                }
            }

            if (node.Word == null)
            {
                node.Word = word;
            }
        }

        public void Reset()
        {
            root = null;
        }

        public List<string> GetMatches(string word)
        {
            List<string> result = new List<string>();

            var node = root;

            for (int x = 0; x < word.Length; x++)
            {
                if (node.ContainsKey(word[x]))
                {
                    node = node[word[x]];
                }
                else
                {
                    node = null;
                    break;
                }
            }

            if (node != null)
            {
                result.Add(node.Word);
                GetMatchesRecursive(node, result);
            }

            return result;
        }

        public void GetMatchesRecursive(TrieNode node, List<string> result)
        {
            foreach (var item in node.Values)
            {
                if (item.Word != null)
                {
                    result.Add(item.Word);
                }

                GetMatchesRecursive(item, result);
            }
        }

    }

}
