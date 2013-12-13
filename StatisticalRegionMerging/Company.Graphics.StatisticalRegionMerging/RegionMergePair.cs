using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Company.Graphics.StatisticalRegionMerging
{
    public class RegionMergePair
    {
        public int r1, r2;
        public int diff;

        public RegionMergePair()
        {
            r1 = 0;
            r2 = 0;
            diff = 0;
        }

    }
}
