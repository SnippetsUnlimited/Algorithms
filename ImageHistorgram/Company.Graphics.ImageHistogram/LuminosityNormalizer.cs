using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Graphics.ImageHistogram
{
    public class LuminosityNormalizer : INormalizer
    {

        public decimal Normalize(int value)
        {
            decimal R = ((value >> 16) & 0xFF)/ 255m;
            decimal G = ((value >> 8) & 0xFF)/ 255m;
            decimal B = ((value >> 0) & 0xFF)/ 255m;

            // Return normalized value of Lumonisity of HSL
            return (
                0.5m *
                (
                    (R > G ? (R > B ? R : B) : (G > B ? G : B)) +
                    (R < G ? (R < B ? R : B) : (G < B ? G : B))
                ));

        }
    }
}
