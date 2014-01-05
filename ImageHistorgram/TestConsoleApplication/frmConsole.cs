using Company.Graphics.ImageHistogram;
using Company.Graphics.StatisticalRegionMerging;
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

        public Histogram Histogram { get; set; }

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

            Histogram = histG.GenerateHistogram(raster, (int)numSampleCount.Value);
            this.Invalidate();
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

        private void frmConsole_Paint(object sender, PaintEventArgs e)
        {
            var LocationX = 280;
            var LocationY = this.Height - 70;
            var BoxHeight = 200;

            e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.Black)), LocationX, LocationY - BoxHeight, (int)numSampleCount.Value, BoxHeight);

            if (Histogram != null)
            {
                for (int x = 0; x < Histogram.Levels.Length; x++)
                {
                    int level = (int)(Histogram.Levels[x] / (int)numScale.Value);
                    e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), LocationX + x, LocationY, LocationX + x, LocationY - level);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmConsole_Resize(object sender, EventArgs e)
        {
        }

        private void frmConsole_ResizeEnd(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
