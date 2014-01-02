using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Company.Algorithms.Text.Base64
{
    public class Base64Encoder
    {

        private const string base64chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";

        public static string Encode(string data, bool linebreaks)
        {
            StringBuilder sb = new StringBuilder();

            int remainderCount = data.Length % 3;
            string prePadding = "";
            string postPadding = "";

            if (remainderCount > 0)
            {
                prePadding = "".PadLeft((3 - data.Length % 3), '\x0');
                postPadding = "".PadLeft((3 - data.Length % 3), '=');
            }

            data += prePadding;

            for (int x = 0; x < data.Length; x += 3)
            {
                if (linebreaks && x > 0 && (((x / 3) * 4) % 76) == 0)
                {
                    sb.Append("\r\n");
                }

                int comp = (data[x] << 16) + (data[x + 1] << 8) + (data[x + 2]);

                char[] segs = new char[]
                {
                    base64chars[(comp >> 18) & 63],
                    base64chars[(comp >> 12) & 63],
                    base64chars[(comp >> 6) & 63],
                    base64chars[comp & 63]
                };

                sb.Append(segs);
            }

            if (remainderCount > 0)
            {
                sb.Remove(sb.Length - postPadding.Length, postPadding.Length).Append(postPadding);
            }

            return sb.ToString();
        }

        public static string Decode(string data)
        {
            string data2 = Regex.Replace(data, "[^" + base64chars + "=]", "");

            if (data2.Length > 0 && data2.Length % 4 == 0)
            {
                StringBuilder sb = new StringBuilder();
                string padding = (data2[data2.Length - 1] != '=') ? "" : (data2[data2.Length - 2] != '=') ? "A" : "AA";

                if (padding.Length > 0)
                {
                    data2 = data2.Remove(data2.Length - padding.Length, padding.Length) + padding;
                }

                for (int x = 0; x < data2.Length; x += 4)
                {
                    int comp = (base64chars.IndexOf(data2[x]) << 18) + (base64chars.IndexOf(data2[x + 1]) << 12) + (base64chars.IndexOf(data2[x + 2]) << 6) + base64chars.IndexOf(data2[x + 3]);
                    sb.Append(Convert.ToChar((comp >> 16) & 255));
                    sb.Append(Convert.ToChar((comp >> 8) & 255));
                    sb.Append(Convert.ToChar(comp & 255));
                }

                if (padding.Length > 0)
                {
                    sb.Remove(sb.Length - padding.Length, padding.Length);
                }

                return sb.ToString();
            }

            return null;
        }

    }
}
