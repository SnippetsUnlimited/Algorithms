using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Graphics.ImageHistogram
{
    public class HistogramGenerator
    {

        public INormalizer Normalizer { get; protected set; }

        public HistogramGenerator(INormalizer normalizer)
        {
            this.Normalizer = normalizer;
        }

        public Histogram GenerateHistogram(int[] data, int size)
        {
            Histogram hist = new Histogram();
            hist.Maximum = 0;
            hist.Minimum = int.MaxValue;

            int[] levels = new int[size + 1];
            
            for (int x = 0, index = 0; x < data.Length; x++)
            {
                float normalizedValue = Normalizer.Normalize(data[x]);
                index = Convert.ToInt32(Math.Round(normalizedValue * size, 0));
                levels[index]++;

                if (levels[index] > hist.Maximum)
                {
                    hist.Maximum = levels[index];
                }
                if (levels[index] < hist.Minimum)
                {
                    hist.Minimum = levels[index];
                }
            }

            hist.Levels = levels;

            return hist;
        }



    }
}
