using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Math.Algorithms.BurrowsWheelerTransform
{
    public class BurrowsWheelerTransformer
    {
        public static string Transform(string data)
        {
            string[] rotations = new string[data.Length + 1];

            rotations[0] = data + '\xff';

            for (int x = 1; x < rotations.Length; x++)
            {
                rotations[x] = rotations[x - 1][data.Length] + rotations[x - 1].Substring(0, data.Length);
            }

            Dictionary<int, string> ht = new Dictionary<int, string>();

            for (int x = 0; x < rotations.Length; x++)
            {
                ht.Add(x, rotations[x]);
            }

            var sorted = ht.OrderBy(x => x.Value, new LexographicStringComparer()).ToArray();

            string final = "";

            for (int x = 0; x < sorted.Count(); x++)
            {
                final += rotations[sorted[x].Key][data.Length];
            }

            return final;
        }

        public static string Inverse(string data)
        {
            string[] rotations = new string[data.Length];

            for (int x = 0; x < rotations.Length; x++)
            {
                for (int y = 0; y < rotations.Length; y++)
                {
                    rotations[y] = data[y] + rotations[y];
                }

                rotations = rotations.OrderBy(s => s, new LexographicStringComparer()).ToArray();
            }

            for (int x = 0; x < rotations.Length; x++)
            {
                if (rotations[x][rotations.Length - 1] == '\xff')
                {
                    return rotations[x].Substring(0, rotations[x].Length - 1);
                }
            }

            return null;

        }

        public class LexographicStringComparer : IComparer<string>
        {
            private static string CharacterOrder = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            private int CharacterComparer(char left, char right)
            {
                int indexL = CharacterOrder.IndexOf(left);
                int indexR = CharacterOrder.IndexOf(right);

                if (indexL > -1 && indexR > -1)
                {
                    return indexL.CompareTo(indexR);
                }
                else if (indexL > -1)
                {
                    return -1;
                }
                else if (indexR > -1)
                {
                    return 1;
                }

                return left.CompareTo(right);
            }

            public int Compare(string left, string right)
            {
                int length = (left.Length.CompareTo(right.Length) <= 0) ? left.Length : right.Length;

                for (int x = 0; x < length; x++)
                {
                    var result = CharacterComparer(left[x], right[x]);

                    if (result != 0) return result;
                }

                return 0;
            }
        }

    }
}
