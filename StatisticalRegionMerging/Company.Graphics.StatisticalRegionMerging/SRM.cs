using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Company.Graphics.StatisticalRegionMerging
{
    public class SRM
    {

        double _MergeColorRange = 256.0; // number of levels in a color channel

        public double ExpectedRegionSize
        {
            get { return _MergeColorRange; }
            set { _MergeColorRange = value; }
        }

        int _MinumumRegionSize = -1;

        // small regions are less than 0.1% of image pixels
        // = (int)(0.001 * NoOfPixels)
        public int MinimumRegionSize
        {
            get { return _MinumumRegionSize; }
            set { _MinumumRegionSize = value; }
        }

        int _LogDeltaFactor = 0;

        // Log Delta
        // = 2.0 * Math.Log(6.0 * NoOfPixels)
        public int LogDeltaFactor
        {
            get { return _LogDeltaFactor; }
            set { _LogDeltaFactor = value; }
        }

        int _BorderThickness = 0;

        // border thickness of regions
        // = 0
        public int BorderThickness
        {
            get { return _BorderThickness; }
            set { _BorderThickness = value; }
        }

        double _RegionCount = 10;

        // Number of approximate regions
        // = 32
        public double ApproximateRegionCount
        {
            get { return _RegionCount; }
            set { _RegionCount = value; }
        }

        // Auxilliary buffers for union-find operations
        UnionFind UF;

        double[] Red;
        double[] Green;
        double[] Blue;

        int[] Weight;
        int[] C; // the class number

        public SRM()
        {
        }

        public void OneRound(int n, int[] raster, int[] rasterSrm, int w, int h)
        {
            if (this.MinimumRegionSize < 0)
            {
                throw new Exception("Small Region must be set.");
            }

            if (this.LogDeltaFactor <= 0)
            {
                throw new Exception("Log Delta Factor must be set.");
            }


            UF = new UnionFind(n);
            Red = new double[n];
            Green = new double[n];
            Blue = new double[n];
            Weight = new int[n];
            C = new int[n];

            // Convert raster array into  Red, Green, Blue color channels and N, C variables using raster array.
            InitializeSegmentation(raster, w, h);

            // Create neighbouring pixel pairs for regional mergin and their calculate difference
            // Sort the pixel pairs based on the color channel difference
            // merge predicates.
            Segmentation(raster, w, h);

            // Merge smallest regions together.
            MergeSmallRegions(w, h, true);

            // Merge small regions together before final output.
            MergeSmallRegions(w, h);

            // Convert Red, Green Blue color channels back to raster array.
            OutputSegmentation(rasterSrm, w, h);

            // Draw border arround discovered regions.
            DrawBorder(rasterSrm, w, h);

        }

        private void InitializeSegmentation(int[] raster, int w, int h)
        {
            int x, y, red, green, blue, index;
            for (y = 0; y < h; y++)
            {
                for (x = 0; x < w; x++)
                {
                    index = y * w + x;

                    red = (raster[index] & 0xFF);
                    green = ((raster[index] & 0xFF00) >> 8);
                    blue = ((raster[index] & 0xFF0000) >> 16);

                    Red[index] = red;
                    Green[index] = green;
                    Blue[index] = blue;
                    Weight[index] = 1;
                    C[index] = index;
                }
            }
        }

        private void Segmentation(int[] raster, int w, int h)
        {
            int i, j, index;
            int reg1, reg2;
            RegionMergePair[] order;
            int npair;
            int cpair = 0;
            int C1, C2;
            int r1, g1, b1;
            int r2, g2, b2;

            // Consider C4-connectivity here
            npair = 2 * (w - 1) * (h - 1) + (h - 1) + (w - 1);
            order = new RegionMergePair[npair];

            // Creating pairs of pixels. Each iteration creates 2*(w-1) pairs. 1 for self-right and 2nd self-bottom.
            for (i = 0; i < h - 1; i++)
            {
                for (j = 0; j < w - 1; j++)
                {
                    index = i * w + j;

                    // C4  left
                    order[cpair] = new RegionMergePair();
                    order[cpair].r1 = index;
                    order[cpair].r2 = index + 1;


                    r1 = raster[index] & 0xFF;
                    g1 = ((raster[index] & 0xFF00) >> 8);
                    b1 = ((raster[index] & 0xFF0000) >> 16);

                    r2 = raster[index + 1] & 0xFF;
                    g2 = ((raster[index + 1] & 0xFF00) >> 8);
                    b2 = ((raster[index + 1] & 0xFF0000) >> 16);

                    // formula to calculate difference - can be modified to get best results
                    // TODO: understand this ->
                    order[cpair].diff = CalculateDifference(r1, r2, g1, g2, b1, b2);
                    cpair++;


                    // C4 below
                    order[cpair] = new RegionMergePair();
                    order[cpair].r1 = index;
                    order[cpair].r2 = index + w;

                    r2 = raster[index + w] & 0xFF;
                    g2 = ((raster[index + w] & 0xFF00) >> 8);
                    b2 = ((raster[index + w] & 0xFF0000) >> 16);

                    // formula to calculate effective color difference - can be modified to get best results
                    order[cpair].diff = CalculateDifference(r1, r2, g1, g2, b1, b2);
                    cpair++;
                }
            }

            //
            // The two border lines
            //
            for (i = 0; i < h - 1; i++)
            {
                index = i * w + w - 1;
                order[cpair] = new RegionMergePair();
                order[cpair].r1 = index;
                order[cpair].r2 = index + w;

                r1 = raster[index] & 0xFF;
                g1 = ((raster[index] & 0xFF00) >> 8);
                b1 = ((raster[index] & 0xFF0000) >> 16);
                r2 = raster[index + w] & 0xFF;
                g2 = ((raster[index + w] & 0xFF00) >> 8);
                b2 = ((raster[index + w] & 0xFF0000) >> 16);
                order[cpair].diff = CalculateDifference(r1, r2, g1, g2, b1, b2);
                cpair++;
            }

            for (j = 0; j < w - 1; j++)
            {
                index = (h - 1) * w + j;

                order[cpair] = new RegionMergePair();
                order[cpair].r1 = index;
                order[cpair].r2 = index + 1;

                r1 = raster[index] & 0xFF;
                g1 = ((raster[index] & 0xFF00) >> 8);
                b1 = ((raster[index] & 0xFF0000) >> 16);
                r2 = raster[index + 1] & 0xFF;
                g2 = ((raster[index + 1] & 0xFF00) >> 8);
                b2 = ((raster[index + 1] & 0xFF0000) >> 16);
                order[cpair].diff = CalculateDifference(r1, r2, g1, g2, b1, b2);

                cpair++;
            }

            //
            // Sort the edges based on color channel difference
            //
            order = BucketSort(order, npair);

            for (i = 0; i < npair; i++)
            {
                // Get pixel 1
                reg1 = order[i].r1;

                // Get Root pixel for 1
                C1 = UF.Find(reg1);

                // Get pixel 2
                reg2 = order[i].r2;

                // Get root for pixel 2
                C2 = UF.Find(reg2);

                // if both pixels do not lie in the same region and predicate XYZ then merge the regions
                if ((C1 != C2) && (MergePredicate(C1, C2))) MergeRegions(C1, C2);
            }

        }

        private int CalculateDifference(int r1, int r2, int g1, int g2, int b1, int b2)
        {
            return (int)MaximumOf(Math.Abs(r2 - r1), Math.Abs(g2 - g1), Math.Abs(b2 - b1));
        }

        private bool MergePredicate(int C1, int C2)
        {
            double dR, dG, dB;
            double multiplierDev1, multiplierDev2;
            double dev1, dev2, dev;

            dR = (Red[C1] - Red[C2]);
            dR *= dR;

            dG = (Green[C1] - Green[C2]);
            dG *= dG;

            dB = (Blue[C1] - Blue[C2]);
            dB *= dB;

            // Effect of weight is reduced and used by Weight[C1]*Log(1.0 + Weight[C1]). Log(1.0 + Weight[C1]) gives a parabolic shape.
            // Weight[C1]*Log(1.0 + Weight[C1]) gives a straight line.
            // The reduced effect is multiplied with 'Expected region size' if the weight is great than 'expected region size'.
            // this means that the logreg1 increases quite rapidly/linearly from 0 to 'expected region size' and
            // after reaching 'expected region size' slows down dramatically.
            // this is a multiplier and is used to raise/control the effect calculated value based on the expected region sizes.
            // LogDelta is used to adjust the effect of the multiplier linearly.
            multiplierDev1 = MinimumOf(this.ExpectedRegionSize, Weight[C1]) * Math.Log(1.0 + Weight[C1]) + Math.Log(6.0D * LogDeltaFactor);
            multiplierDev2 = MinimumOf(this.ExpectedRegionSize, Weight[C2]) * Math.Log(1.0 + Weight[C2]) + Math.Log(6.0D * LogDeltaFactor);

            // dev1 is maximum allowed deviation for C1
            // dev2 is maximum allowed deviation for C2
            // dev1 + dev2 is maximum allowed deviation.
            // if any color is less than that then the should be merged else they are totally different class of colors and must not be merged.
            // 
            dev1 = (multiplierDev1) * (this.ExpectedRegionSize * this.ExpectedRegionSize) / (2.0 * this.ApproximateRegionCount * Weight[C1]);
            dev2 = (multiplierDev2) * (this.ExpectedRegionSize * this.ExpectedRegionSize) / (2.0 * this.ApproximateRegionCount * Weight[C2]);

            dev = dev1 + dev2;

            return ((dR < dev) && (dG < dev) && (dB < dev));
        }


        private void MergeRegions(int C1, int C2)
        {
            int reg, noofmergedpixels;
            double ravg, gavg, bavg;

            // Initially N[0 .. n] = 1 for all.
            noofmergedpixels = Weight[C1] + Weight[C2];

            // Take averages of the colors. Weight decides the parts of each samples to be merged.
            // 1*100 + 1*102 / 1+1 = 101 .. 
            ravg = (Weight[C1] * Red[C1] + Weight[C2] * Red[C2]) / noofmergedpixels;
            gavg = (Weight[C1] * Green[C1] + Weight[C2] * Green[C2]) / noofmergedpixels;
            bavg = (Weight[C1] * Blue[C1] + Weight[C2] * Blue[C2]) / noofmergedpixels;

            // Join C1 and C2 together under one region
            // get root pixel index
            reg = UF.UnionRoot(C1, C2);

            Weight[reg] = noofmergedpixels;
            Red[reg] = ravg;
            Green[reg] = gavg;
            Blue[reg] = bavg;
        }

        // Sort All pairs based on cumulative histogram
        private RegionMergePair[] BucketSort(RegionMergePair[] a, int n)
        {
            int i;
            int[] nbe;
            int[] cnbe;
            RegionMergePair[] b;

            //Example a[12] = {0,1,2,3,0,1,0,0,0,0,2,3}, nbe = [4] (for 4 different pixels)

            nbe = new int[256];
            cnbe = new int[256];

            b = new RegionMergePair[n];

            // Reset array to 0
            for (i = 0; i < 256; i++)
            {
                nbe[i] = 0;
            }

            // Create historgram
            // Example nbe = {6,2,2,2} for 6 .. 0's, 2 .. 1's, 2 .. 2's, 2, .. 3's 
            for (i = 0; i < n; i++)
            {
                // Increase rank for same difference
                nbe[a[i].diff]++;
            }

            // Create cumulative histogram
            // Example cnbe = {0, (0+6) .. 6, (6+2) .. 8, (8+2) .. 10 } = {0, 6, 8, 10}
            cnbe[0] = 0;
            for (i = 1; i < 256; i++)
            {
                cnbe[i] = cnbe[i - 1] + nbe[i - 1]; // index of first element of category i
            }

            // Order array by difference in assending order
            // Example a[0] -> b[(0++)], a[1] -> b[(6++)]
            for (i = 0; i < n; i++)
            {
                b[cnbe[a[i].diff]++] = a[i];
            }

            return b;
        }

        // Draw white borders delimiting perceptual regions
        private void DrawBorder(int[] rasterSrm, int w, int h)
        {
            int i, j, k, l, C1, C2, index;

            for (i = 1; i < h; i++) // for each row
                for (j = 1; j < w; j++) // for each column
                {
                    // Get index of the pixel
                    index = i * w + j;

                    // Get Parent of pixel at Index
                    C1 = UF.Find(index);

                    // Get Parent of pixel at top left of Index
                    C2 = UF.Find(index - 1 - w);

                    // If both do not have the same parent
                    if (C2 != C1)
                    {
                        for (k = -this.BorderThickness; k < this.BorderThickness; k++)
                            for (l = -this.BorderThickness; l < this.BorderThickness; l++)
                            {
                                index = (i + k) * w + (j + l);
                                if ((index >= 0) && (index < w * h))
                                {
                                    rasterSrm[index] = (255 << 24 | 255 << 16 | 255 << 8 | 255);
                                }
                            }
                    }
                }
        }

        private void MergeSmallRegions(int w, int h)
        {
            int i, j, C1, C2, index;

            index = 0;

            for (i = 0; i < h; i++) // for each row
                for (j = 1; j < w; j++) // for each column
                {
                    index = i * w + j;

                    // find roots of pixel at [index] and [index + 1]
                    C1 = UF.Find(index);
                    C2 = UF.Find(index - 1);

                    // if both pixel do not lie in the same region and ..
                    // if weight of the root pixel of a region is less than minimum region size then that region is smaller than the minimum size and merge it.   
                    if (C2 != C1) { if ((Weight[C2] < this.MinimumRegionSize) || (Weight[C1] < this.MinimumRegionSize)) MergeRegions(C1, C2); }
                }
        }

        private void MergeSmallRegions(int w, int h, bool useAverage)
        {

            if (!useAverage)
            {
                MergeSmallRegions(w, h);
            }
            else
            {
                int i, j, C1, C2, index;

                index = 0;

                for (i = 0; i < h; i++) // for each row
                    for (j = 1; j < w; j++) // for each column
                    {
                        index = i * w + j;

                        // find roots of pixel at [index] and [index + 1]
                        C1 = UF.Find(index);
                        C2 = UF.Find(index - 1);

                        if (this.MinimumRegionSize > Weight[C1] && MinimumRegionSize > Weight[C2])
                        {
                            // if both pixel do not lie in the same region and ..
                            // if weight of the root pixel of a region is less than minimum region size then that region is smaller than the minimum size and merge it.   
                            if (C2 != C1) { if ((Weight[C2] < this.MinimumRegionSize) || (Weight[C1] < this.MinimumRegionSize)) MergeRegions(C1, C2); }
                        }
                    }
            }
        }

        private void OutputSegmentation(int[] rasterSrm, int w, int h)
        {
            int i, j, index, indexb;
            int r, g, b, a, rgba;

            index = 0;
            a = 0X000000FF;

            // Uptill here the pixels in a region are linked together in the form of a tree with one pixel as the root pixel.

            for (i = 0; i < h; i++) // for each row
                for (j = 0; j < w; j++) // for each column
                {
                    // Get index of a Pixel. This pixel is part of a region and color of all the pixels in that region must be same.
                    index = i * w + j;

                    // Find Root pixel of the region within which the pixel locates.
                    indexb = UF.Find(index); // Get the root index 

                    // average color of the root pixel
                    r = (int)Red[indexb];
                    g = (int)Green[indexb];
                    b = (int)Blue[indexb];

                    rgba = (a << 24 | b << 16 | g << 8 | r);

                    // set new color of the root pixel 
                    rasterSrm[index] = rgba;
                }
        }

        private double MinimumOf(double a, double b)
        {
            if (a < b) return a; else return b;
        }

        private double MaximumOf(double a, double b)
        {
            if (a > b) return a; else return b;
        }

        private double MaximumOf(double a, double b, double c)
        {
            return MaximumOf(a, MaximumOf(b, c));
        }

    }
}
