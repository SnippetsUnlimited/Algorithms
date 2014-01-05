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

        private TrieNode root = null;

        public void Reset()
        {
            root = null;
        }

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
                    TrieNode child = new TrieNode();
                    node.Add(word[x], child);
                }
                node = node[word[x]];
            }

            if (node.Word == null)
            {
                node.Word = word;
            }
        }

        public List<string> GetMatches(string word)
        {
            List<string> result = new List<string>();

            if (!string.IsNullOrEmpty(word) && root != null)
            {
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
                    GetMatchesRecursive(node, result);
                }
            }

            return result;
        }

        private void GetMatchesRecursive(TrieNode node, List<string> result)
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
