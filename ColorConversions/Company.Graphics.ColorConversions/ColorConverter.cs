using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Company.Graphics.ColorConversions
{
    public class ColorConverter
    {
        public static RGBColor ToRGB(HSVColor color)
        {
            return ColorConverterHelper.HSVToRGB(color);
        }

        public static RGBColor ToRGB(HSLColor color)
        {
            return ColorConverterHelper.HSLToRGB(color);
        }

        public static RGBColor ToRGB(HSIColor color)
        {
            return ColorConverterHelper.HSIToRGB(color);
        }

        public static RGBColor ToRGB(CMYKColor color)
        {
            return ColorConverterHelper.CMYKToRGB(color);
        }

        public static CMYKColor ToCMYK(RGBColor color)
        {
            return ColorConverterHelper.RGBToCMYK(color);
        }

        public static HSIColor ToHSI(RGBColor color)
        {
            return ColorConverterHelper.RGBToHSI(color);
        }

        public static HSVColor ToHSV(RGBColor color)
        {
            return ColorConverterHelper.RGBToHSV(color);
        }

        public static HSLColor ToHSL(RGBColor color)
        {
            return ColorConverterHelper.RGBToHSL(color);
        }

    }
}
