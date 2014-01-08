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

            if (invK == 0f)
            {
                cmyk.Black = K;
                cmyk.Cyan = (invR - K) / invK;
                cmyk.Magenta = (invG - K) / invK;
                cmyk.Yellow = (invB - K) / invK;
            }

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

        public static HSVColor RGBToHSV(RGBColor color)
        {
            ValidateNormalization(new float[] { color.Red, color.Green, color.Blue });

            float R = color.Red;
            float G = color.Green;
            float B = color.Blue;

            float min, max, delta;

            min = R < G ? (R < B ? R : B) : (G < B ? G : B);
            max = R > G ? (R > B ? R : B) : (G > B ? G : B);

            delta = max - min;

            float H = 0;
            float S = 0;
            float V = 0;

            V = max;

            if (max > 0f)
            {
                S = delta / max;

                if (R == max)
                    H = (1 / 6f) * ((G - B)) / delta;        // between yellow & magenta
                else if (G == max)
                    H = (1 / 6f) * (2 + ((B - R) / delta));    // between cyan & yellow
                else
                    H = (1 / 6f) * (4 + ((R - G) / delta));    // between magenta & cyan

                if (H < 0)
                {
                    H = H + 1;
                }
            }

            HSVColor hsv = new HSVColor();
            hsv.Hue = H;
            hsv.Saturation = S;
            hsv.Value = V;

            return hsv;

        }

        public static RGBColor HSVToRGB(HSVColor hsv)
        {
            float H = hsv.Hue;
            float h = H * 360;
            float S = hsv.Saturation;
            float V = hsv.Value;

            float C = S * V;
            float X = C * (1 - Math.Abs(((H * 6) % 2 - 1)));
            float m = V - C;

            float R = 0;
            float G = 0;
            float B = 0;

            if (h >= 0 && h < 60)
            {
                R = C + m;
                G = X + m;
                B = m;
            }
            else if (h >= 60 && h < 120)
            {
                R = X + m;
                G = C + m;
                B = m;
            }
            else if (h >= 120 && h < 180)
            {
                R = m;
                G = C + m;
                B = X + m;
            }
            else if (h >= 180 && h < 240)
            {
                R = m;
                G = X + m;
                B = C + m;
            }
            else if (h >= 240 && h < 300)
            {
                R = X + m;
                G = m;
                B = C + m;
            }
            else if (h >= 300 && h < 360)
            {
                R = C + m;
                G = m;
                B = X + m;
            }

            RGBColor rgb = new RGBColor();
            rgb.Red = R;
            rgb.Green = G;
            rgb.Blue = B;


            return rgb;
        }


        public static HSLColor RGBToHSL(RGBColor color)
        {
            float R = color.Red;
            float G = color.Green;
            float B = color.Blue;

            float H = 0;
            float S = 0;
            float L = 0;

            float min, max, delta;

            min = R < G ? (R < B ? R : B) : (G < B ? G : B);
            max = R > G ? (R > B ? R : B) : (G > B ? G : B);

            L = (max + min) / 2f;

            if (max > min)
            {
                delta = max - min;

                S = L > 0.5 ? delta / (2 - (max + min)) : delta / (max + min);

                if (R == max)
                    H = (1 / 6f) * ((G - B)) / delta;        // between yellow & magenta
                else if (G == max)
                    H = (1 / 6f) * (2 + ((B - R) / delta));    // between cyan & yellow
                else
                    H = (1 / 6f) * (4 + ((R - G) / delta));    // between magenta & cyan

                if (H < 0)
                {
                    H = H + 1;
                }

            }

            HSLColor hsl = new HSLColor();
            hsl.Hue = H;
            hsl.Saturation = S;
            hsl.Luminosity = L;

            return hsl;
        }

        public static RGBColor HSLToRGB(HSLColor color)
        {
            float H = color.Hue;
            float S = color.Saturation;
            float L = color.Luminosity;

            float R = 0;
            float G = 0;
            float B = 0;

            float C = S * (1 - Math.Abs(2 * L - 1));
            float X = C * (1 - Math.Abs(((H * 6) % 2 - 1)));
            float m = L - (C / 2f);

            float h = H * 360;

            if (h >= 0 && h < 60)
            {
                R = C + m;
                G = X + m;
                B = m;
            }
            else if (h >= 60 && h < 120)
            {
                R = X + m;
                G = C + m;
                B = m;
            }
            else if (h >= 120 && h < 180)
            {
                R = m;
                G = C + m;
                B = X + m;
            }
            else if (h >= 180 && h < 240)
            {
                R = m;
                G = X + m;
                B = C + m;
            }
            else if (h >= 240 && h < 300)
            {
                R = X + m;
                G = m;
                B = C + m;
            }
            else if (h >= 300 && h < 360)
            {
                R = C + m;
                G = m;
                B = X + m;
            }

            RGBColor rgb = new RGBColor();
            rgb.Red = R;
            rgb.Green = G;
            rgb.Blue = B;


            return rgb;


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
