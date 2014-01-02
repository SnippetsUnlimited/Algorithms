﻿using Company.Graphics.StatisticalRegionMerging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestConsoleApplication
{
    public partial class frmConsole : Form
    {
        public frmConsole()
        {
            InitializeComponent();
        }

        private void Generate_Histogram_Click(object sender, EventArgs e)
        {

            PixelGrabber pg = new PixelGrabber(pbImage.Image, 0, 0, -1, -1, true);

            int imageWidth = pg.Width;
            int imageHeight = pg.Height;

            // Get image aspect ratio
            double imageAspectRatio = (double)imageHeight / (double)imageWidth;

            // Get number of pixels in the image
            int NoOfPixels = imageWidth * imageHeight;

            // Get pixels in the image
            int[] raster = (int[])pg.GetPixels();

            var histG = new Company.Graphics.ImageHistogram.HistogramGenerator(new Company.Graphics.ImageHistogram.LuminosityNormalizer());

            var histogram = histG.GenerateHistogram(raster, 255);

            frmHistogram frm = new frmHistogram(histogram, numScale.Value);
            frm.ShowDialog();

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();
            fd.CheckFileExists = true;
            fd.Filter = "*.bmp|*.bmp";

            if (System.IO.File.Exists(fd.FileName))
            {
                txtImagePath.Text = fd.FileName;
                pbImage.Image = System.Drawing.Bitmap.FromFile(txtImagePath.Text);
            }
        }
    }
}
