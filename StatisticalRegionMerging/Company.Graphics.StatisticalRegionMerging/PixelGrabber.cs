using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Company.Graphics.StatisticalRegionMerging
{
    public class PixelGrabber
    {
        private System.Drawing.Bitmap bmp = null;

        private int _Left = 0;
        private int _Top = 0;
        private int _Width = 0;
        private int _Height = 0;

        public PixelGrabber(System.Drawing.Image image, int left, int top, int width, int height, bool yes)
        {
            _Left = left;
            _Top = top;
            _Width = (width < 0) ? image.Width : width;
            _Height = (height < 0) ? image.Height : height;

            bmp = new System.Drawing.Bitmap(_Width, _Height);
            System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(bmp);
            g.DrawImage(image, _Left, _Top, _Width, _Height);
        }

        public int[] GetPixels()
        {
            return this.GetPixel(this._Width, this._Height);
        }

        private int[] GetPixel(int width, int height)
        {
            int[] pixels = new int[width * height];
            System.Drawing.Imaging.BitmapData bmpData = bmp.LockBits(new System.Drawing.Rectangle(_Left, _Top, width, height), System.Drawing.Imaging.ImageLockMode.ReadWrite, bmp.PixelFormat);
            System.Runtime.InteropServices.Marshal.Copy(bmpData.Scan0, pixels, 0, pixels.Length);
            bmp.UnlockBits(bmpData);

            return pixels;
        }

        public int Width
        {
            get { return _Width; }
        }

        public int Height
        {
            get { return _Height; }
        }

    }
}
