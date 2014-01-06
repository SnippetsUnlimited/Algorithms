using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Company.Graphics.ColorConversions
{
    public class ColorConverterHelper
    {
        public static CMYKColor RGBToCMYK(RGBColor color)
        {
            ValidateNormalization(new float[] { color.Red, color.Green, color.Blue });

            CMYKColor cmyk = new CMYKColor();

            float invR = 1 - color.Red;
            float invG = 1 - color.Green;
            float invB = 1 - color.Blue;

            float K = invR < invG ? (invR < invB ? invR : invB) : (invG < invB ? invG : invB);
            float invK = 1 - K;

            cmyk.Black = K;
            cmyk.Cyan = (invR - K) / invK;
            cmyk.Magenta = (invG - K) / invK;
            cmyk.Yellow = (invB - K) / invK;

            return cmyk;
        }

        public static RGBColor CMYKToRGB(CMYKColor color)
        {
            ValidateNormalization(new float[] { color.Cyan, color.Magenta, color.Yellow, color.Black });

            RGBColor rgb = new RGBColor();
            rgb.Alpha = 1;
            rgb.Red = (1 - color.Cyan) * (1 - color.Black);
            rgb.Green = (1 - color.Magenta) * (1 - color.Black);
            rgb.Blue = (1 - color.Yellow) * (1 - color.Black);

            return rgb;
        }

        public static RGBColor HSIToRGB(HSIColor color)
        {
            double H = color.Hue * 360d;
            double S = color.Saturation;
            double I = color.Intensity;
            double SI = S * I;
            double M = 0;

            RGBColor rgb = new RGBColor();
            rgb.Alpha = 1;

            if (H == 0)
            {
                rgb.Red = (float)(I + (2 * SI)) / 3f;
                rgb.Green = (float)(I - SI) / 3f;
                rgb.Blue = (float)(I - SI) / 3f;
            }
            else if ((0 < H) && (H < 120))
            {
                M = (Math.Cos((H * Math.PI) / 180) / Math.Cos(((60 - H) * Math.PI) / 180));
                rgb.Red = (float)(I + SI * M) / 3f;
                rgb.Green = (float)(I + SI * (1 - M)) / 3f;
                rgb.Blue = (float)(I - SI) / 3f;
            }
            else if (H == 120)
            {
                rgb.Red = (float)(I - SI) / 3f;
                rgb.Green = (float)(I + (2 * SI)) / 3f;
                rgb.Blue = (float)(I - SI) / 3f;
            }
            else if ((120 < H) && (H < 240))
            {
                M = (Math.Cos((H - 120) * Math.PI / 180) / Math.Cos((180 - H) * Math.PI / 180));
                rgb.Red = (float)(I - SI) / 3f;
                rgb.Green = (float)(I + SI * M) / 3f;
                rgb.Blue = (float)(I + SI * (1 - M)) / 3f;
            }
            else if (H == 240)
            {
                rgb.Red = (float)(I - SI) / 3f;
                rgb.Green = (float)(I - SI) / 3f;
                rgb.Blue = (float)(I + (2 * SI)) / 3f;
            }
            else if ((240 < H) && (H < 360))
            {
                M = (Math.Cos((H - 240) * Math.PI / 180) / Math.Cos((300 - H) * Math.PI / 180));
                rgb.Red = (float)(I + SI * (1 - M)) / 3f;
                rgb.Green = (float)(I - SI) / 3f;
                rgb.Blue = (float)(I + SI * M) / 3f;
            }

            return rgb;
        }


        public static HSIColor RGBToHSI(RGBColor color)
        {
            ValidateNormalization(new float[] { color.Red, color.Green, color.Blue });

            HSIColor hsi = new HSIColor();

            float R = color.Red;
            float G = color.Green;
            float B = color.Blue;
            float Min = R < G ? (R < B ? R : B) : (G < B ? G : B);

            float I = (R + G + B) / 3f;
            float S = 0;
            float H = 0;

            double D = 0;
            double h = 0;

            if (I > 0 && (R != G || R != B || G != B))
            {
                S = 1 - (Min / I);
                D = (R - 0.5 * (G + B)) / (float)(Math.Sqrt(R * R + G * G + B * B - R * G - R * B - B * G));

                h = Math.Acos(D);

                if (B > G)
                {
                    h = 2 * Math.PI - h;
                }
            }

            H = (float)(h / (2 * Math.PI));

            hsi.Hue = H;
            hsi.Saturation = S;
            hsi.Intensity = I;
            return hsi;
        }

        public static HSIColor RGBToHSV(RGBColor color)
        {
            ValidateNormalization(new float[] { color.Red, color.Green, color.Blue });

            HSVColor hsi = new HSVColor();







            return null;
        }













        private static void ValidateNormalization(float[] values)
        {
            if (values.Count(x => x < 0 || x > 1) > 0)
            {
                throw new Exception("Color values provided should be normalized");
            }
        }

    }
}
