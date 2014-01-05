using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Graphics.ImageHistogram
{
    public interface INormalizer
    {
        float Normalize(int value);
    }
}
