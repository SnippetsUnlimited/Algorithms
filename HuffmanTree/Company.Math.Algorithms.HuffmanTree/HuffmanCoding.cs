using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Math.Algorithms.HuffmanTree
{
    public class HuffmanCoding
    {
        public HuffmanFrequencyTable BuildFrequencyTable(string data)
        {
            HuffmanFrequencyTable table = new HuffmanFrequencyTable();

            var hash = new Dictionary<char, int>();

            foreach (char c in data)
            {
                if (hash.ContainsKey(c))
                {
                    hash[c] += 1;
                }
                else
                {
                    hash.Add(c, 1);
                }
            }

            table.Characters = hash.Keys.ToArray();
            table.Frequencies = hash.Values.ToArray();

            // Sample table.
            // table.Characters = ("ABCDEFGHIJKLMNOPQRSTUVWXYZ ").ToCharArray();
            // table.Frequencies = new int[] { 81, 15, 28, 43, 128, 23, 20, 61, 71, 2, 1, 40, 24, 69, 76, 20, 1, 61, 64, 91, 28, 10, 24, 1, 20, 1, 130 };
            return table;
        }

        public HuffmanTree BuildHuffmanTree(HuffmanFrequencyTable table)
        {
            if (table.Characters.Length <= 1)
            {
                throw new Exception("there should be at the minimum 2 characters for compression");
            }

            char[] chars = table.Characters;
            int[] weights = table.Frequencies;
            int count = chars.Length;

            HuffmanNode[] nodeList = new HuffmanNode[count];

            for (int x = 0; x < count; x++)
                nodeList[x] = new HuffmanNode() { Char = chars[x], Weight = weights[x] };

            int treeCount = count;

            // handling the case with only single character string.
            HuffmanNode parentNode = null;

            while (treeCount > 1)
            {
                int leftIndex = GetLeastWeightedNodeIndex(nodeList);
                int rightIndex = GetLeastWeightedNodeIndex(nodeList, leftIndex);

                parentNode = new HuffmanNode() { Left = nodeList[leftIndex], Right = nodeList[rightIndex], Weight = nodeList[leftIndex].Weight + nodeList[rightIndex].Weight };

                nodeList[leftIndex] = parentNode;
                nodeList[rightIndex] = null;

                treeCount--;
            }

            HuffmanTree root = new HuffmanTree() { Left = parentNode.Left, Right = parentNode.Right, Weight = parentNode.Weight };
            return root;
        }

        private int GetLeastWeightedNodeIndex(HuffmanNode[] nodeList, int excludeIndex = -1)
        {
            int index = 0;

            while (nodeList[index] == null || excludeIndex == index)
                index++;

            for (int x = 0; x < nodeList.Length; x++)
            {
                if (nodeList[x] != null)
                    if (nodeList[x].Weight < nodeList[index].Weight && excludeIndex != x)
                        index = x;
            }

            return index;
        }

        public Dictionary<char, string> Traverse(HuffmanTree tree)
        {
            var ht = new Dictionary<char, string>();
            Traverse((HuffmanNode)tree, string.Empty, ht);
            return ht;
        }

        public void Traverse(HuffmanNode node, string code, Dictionary<char, string> ht)
        {
            if (node.Char != 0)
                ht.Add(node.Char, code);
            else
            {
                Traverse(node.Left, code + "1", ht);
                
                if (node.Right != null)
                {
                    Traverse(node.Right, code + "0", ht);
                }
            }
        }

        public Dictionary<char, string> Canonicalize(Dictionary<char, string> ht)
        {
            var list = ht.ToList();

            list.Sort(delegate(KeyValuePair<char, string> left, KeyValuePair<char, string> right)
            {
                if (left.Value.Length > right.Value.Length)
                    return 1;
                else if (left.Value.Length < right.Value.Length)
                    return -1;
                else
                {
                    return left.Value.CompareTo(right.Value);
                }
            });

            int counter = 0;
            string prev = "";

            for (int x = 0; x < list.Count; x++)
            {
                string bstring = Convert.ToString(counter, 2).PadLeft(prev.Length, '0');

                if (list[x].Value.Length > prev.Length)
                {
                    bstring = bstring.PadRight(list[x].Value.Length, '0');
                    prev = list[x].Value;
                    counter = Convert.ToInt32(bstring, 2);
                }

                list[x] = new KeyValuePair<char, string>(list[x].Key, bstring);

                counter++;
            }

            var ht2 = list.ToDictionary(x => x.Key, y => y.Value);

            return ht2;
        }

        public string EncodeData(HuffmanTree tree, string dataString)
        {
            var ht = Traverse(tree);

            StringBuilder sb = new StringBuilder();

            foreach (char c in dataString)
            {
                sb.Append(ht[c]);
            }

            return sb.ToString();
        }


        private int position = 0;
        private string dataString = "";

        public string Decode(HuffmanTree tree, string data)
        {
            position = 0;
            dataString = data;

            StringBuilder sb = new StringBuilder();
            HuffmanNode parentNode = tree;

            while (dataString.Length > position)
            {
                if (dataString[position] == '1')
                {
                    parentNode = parentNode.Left;
                }
                else if (dataString[position] == '0')
                {
                    parentNode = parentNode.Right;
                }

                if (parentNode.Char != 0)
                {
                    sb.Append(parentNode.Char);
                    parentNode = tree;
                }
                position++;
            }

            return sb.ToString();
        }

        public string EncodeTree(HuffmanTree tree)
        {
            return EncodeTree(tree as HuffmanNode);
        }

        private string EncodeTree(HuffmanNode node)
        {
            string result = string.Empty;

            if (node.Char != 0)
            {
                result = "1" + Convert.ToString(node.Char, 2).PadLeft(8, '0');
            }
            else
            {
                result = "0" + EncodeTree(node.Left);

                if (node.Right != null)
                {
                    result += EncodeTree(node.Right);
                }
            }

            return result;
        }

        public HuffmanTree DecodeTree(string data)
        {
            position = 0;
            dataString = data;
            var res = DecodeTreeData();
            return new HuffmanTree() { Left = res.Left, Right = res.Right, Weight = res.Weight };
        }

         private HuffmanNode DecodeTreeData()
        {
            if (dataString.Substring(position, 1) == "0")
            {
                var nonleaf = new HuffmanNode();
                position += 1;
                nonleaf.Left = DecodeTreeData();
                if (dataString.Length - position > 0)
                {
                    nonleaf.Right = DecodeTreeData();
                }
                return nonleaf;
            }
            else
            {
                var leaf = new HuffmanNode();
                leaf.Char = Convert.ToChar(Convert.ToInt32(dataString.Substring(position + 1, 8), 2));
                position += 9;
                return leaf;
            }
        }


    }

}
