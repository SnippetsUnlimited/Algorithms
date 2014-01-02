using Company.Graphics.ImageHistogram;
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
    public partial class frmHistogram : Form
    {

        public Histogram Histogram { get; set; }

        public decimal Scale { get; set; }

        private int LocationX = 50;
        private int LocationY = 300;


        public frmHistogram(Histogram histogram, decimal scale)
        {
            InitializeComponent();
            this.Histogram = histogram;
            this.Scale = scale;
        }

        private void frmHistogram_Load(object sender, EventArgs e)
        {
        }

        private void frmHistogram_Paint(object sender, PaintEventArgs e)
        {
            LocationY = this.Height - 50;

            for (int x = 0; x < Histogram.Levels.Length; x++)
            {
                int level = (int)(Histogram.Levels[x] / this.Scale);
                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), LocationX + x, LocationY, LocationX + x, LocationY - level);
            }
        }   
    }
}
