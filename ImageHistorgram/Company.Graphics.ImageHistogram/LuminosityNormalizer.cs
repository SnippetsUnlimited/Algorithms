using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Graphics.ImageHistogram
{
    public class LuminosityNormalizer : INormalizer
    {

        public float Normalize(int value)
        {
            float R = ((value >> 16) & 0xFF) / 255f;
            float G = ((value >> 8) & 0xFF) / 255f;
            float B = ((value >> 0) & 0xFF) / 255f;

            // Return normalized value of Lumonisity of HSL
            return (
                0.5f *
                (
                (R > G ? (R > B ? R : B) : (G > B ? G : B)) +
                (R < G ? (R < B ? R : B) : (G < B ? G : B))
                ));

        }
    }
}
