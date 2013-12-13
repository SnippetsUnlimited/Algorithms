using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Company.Graphics.StatisticalRegionMerging
{
    // http://www.cs.unm.edu/~rlpm/499/uf.html
    // http://research.cs.vt.edu/AVresearch/UF/
    // http://en.wikipedia.org/wiki/Disjoint-set_data_structure
    public class UnionFind
    {
        public int[] rank;
        public int[] parent;

        public UnionFind(int n)
        {

            parent = new int[n];
            rank = new int[n];

            for (int k = 0; k < n; k++)
            {
                parent[k] = k;
                rank[k] = 0;
            }
        }

        public int Find(int k)
        {
            return Find(k, false);
        }

        public int Find(int k, bool pathCompression)
        {
            if (pathCompression)
            {
                return FindWithPathCompression(k);
            }

            return FindWithoutPathCompression(k);
        }

        // Get index of the root pixel for the region without resetting the direct parent the path
        private int FindWithoutPathCompression(int k)
        {
            while (parent[k] != k) k = parent[k];
            return k;
        }

        // Get index of the root pixel for the region with resetting the direct parent the path
        private int FindWithPathCompression(int k)
        {
            int j = k;

            while (parent[j] != j)
            {
                j = parent[j];
            }

            if (parent[k] != j)
            {
                parent[k] = j;
            }

            return j;
        }

        // By default 
        public int UnionRoot(int x, int y)
        {
            // If both pixels index are the same return -1 as error.
            if (x == y) return -1;


            if (rank[x] > rank[y]) // If, rank of pixel x is greater than pixel y then make x the parent of y.
            {
                parent[y] = x;
                return x;
            }
            else if (rank[y] > rank[x]) // If, rank of pixel y is greater than pixel x then make y the parent of x.
            {
                parent[x] = y;
                return y;
            }
            else // else if rank of x and y are the same then choose y to be the parent of x and raise its rank. 
            {
                parent[x] = y;

                if (rank[y] == rank[x])
                {
                    rank[y]++;
                }

                return y;
            }
        }
    }
}
