using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Company.Graphics.StatisticalRegionMerging
{
    public class ImageProducer
    {
        System.Drawing.Bitmap _Bmp = null;

        private int[] _Pixels = null;
        private int _Width = 0;
        private int _Height = 0;


        public ImageProducer(int x, int y, int[] pixels)
        {
            _Width = x;
            _Height = y;
            _Pixels = pixels;
            _Bmp = new System.Drawing.Bitmap(_Width, _Height);
        }

        public System.Drawing.Image CreateImage()
        {
            System.Drawing.Imaging.BitmapData bmpData = _Bmp.LockBits(new System.Drawing.Rectangle(0, 0, _Width, _Height), System.Drawing.Imaging.ImageLockMode.ReadWrite, _Bmp.PixelFormat);
            System.Runtime.InteropServices.Marshal.Copy(_Pixels, 0, bmpData.Scan0, _Pixels.Length);
            _Bmp.UnlockBits(bmpData);
            return _Bmp;
        }
    }
}
