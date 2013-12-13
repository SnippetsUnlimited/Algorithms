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
        public frmConsole()
        {
            InitializeComponent();
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
                LoadImage(txtImagePath.Text);
            }
        }

        private void LoadImage(string path)
        {
            pbOriginal.Image = System.Drawing.Bitmap.FromFile(path);
            pbSampled.Image = System.Drawing.Bitmap.FromFile(path);
            lblPixelCount.Text = (pbOriginal.Image.Height * pbOriginal.Image.Width).ToString();

        }

        private void btnApplyToOriginal_Click(object sender, EventArgs e)
        {
            ApplySRM(pbOriginal.Image);
        }

        private void btnApplyAgain_Click(object sender, EventArgs e)
        {
            ApplySRM(pbSampled.Image);

        }

        private void ApplySRM(Image image)
        {
            try
            {
                int ExpectedRegionSize = this.GetInteger(txtExpectedRegionSize.Text, 0, 1000);
                int MinimumRegionSize = this.GetInteger(txtMinimumRegionSize.Text, 0, 1000);
                int LogDeltaFactor = this.GetInteger(txtLogDelta.Text, 0, 1000);
                int BorderThickness = this.GetInteger(txtBorderThickness.Text, 0, 10);
                int ApproxRegionCount = this.GetInteger(txtApproxRegionCount.Text, 0, 10);


                pbSampled.Image = ApplySampling(image,
                    ExpectedRegionSize, MinimumRegionSize, LogDeltaFactor, BorderThickness, ApproxRegionCount);
                pbSampled.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int GetInteger(string value, int minimumValue, int maximumValue)
        {
            int x = 0;
            if(!int.TryParse(value, out x))
            {
                throw new Exception("Invalid integer value: " + value);
            }
            return x;
        }

        public Image ApplySampling(Image sample,
            int expectedRegionSize, int minimumRegionSize, int logDeltaFactor, int borderThickness, int approxRegionCount)
        {
            if (sample != null)
            {
                SRM srm = new SRM();

                // Grab Pixel in the image to process
                PixelGrabber pg = new PixelGrabber(sample, 0, 0, -1, -1, true);

                int imageWidth = pg.Width;
                int imageHeight = pg.Height;

                // Get image aspect ratio
                double imageAspectRatio = (double)imageHeight / (double)imageWidth;

                // Get number of pixels in the image
                int NoOfPixels = imageWidth * imageHeight;

                // Get pixels in the image
                int[] raster = (int[])pg.GetPixels();
                int[] rastero = new int[NoOfPixels];

                //////srm.ExpectedRegionSize = 125; // range of color levels to be merged
                //////srm.MinimumRegionSize = (int)(minimumRegionPercentage * NoOfPixels); //(int)(0.001 * NoOfPixels); // smallest allowed regions are less than 0.1% of image pixels = (int)(0.001 * NoOfPixels)
                //////srm.LogDelta = deltaFactor * Math.Log(6.0 * NoOfPixels);//2.0 * Math.Log(6.0 * NoOfPixels); // Log Delta
                //////srm.BorderThickness = 0; // thickness of border drawn arround the regions 
                //////srm.ApproximateRegionCount = 32; // Number of approximate regions

                srm.ExpectedRegionSize = expectedRegionSize;
                srm.MinimumRegionSize = minimumRegionSize;
                srm.LogDeltaFactor = logDeltaFactor;
                srm.BorderThickness = borderThickness;
                srm.ApproximateRegionCount = approxRegionCount;

                srm.OneRound(NoOfPixels, raster, rastero, imageWidth, imageHeight);

                ImageProducer ip = new ImageProducer(pg.Width, pg.Height, rastero);
                return ip.CreateImage();

            }

            return null;
        }




    }
}
