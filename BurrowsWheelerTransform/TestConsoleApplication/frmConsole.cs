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

        private void frmConsole_Load(object sender, EventArgs e)
        {

        }

        private void btnTransform_Click(object sender, EventArgs e)
        {
            txtTransform.Text = Company.Algorithms.Compression.BurrowsWheelerTransform.BurrowsWheelerTransformer.Transform(txtInverse.Text);
        }

        private void btnInverse_Click(object sender, EventArgs e)
        {
            txtInverse.Text = Company.Algorithms.Compression.BurrowsWheelerTransform.BurrowsWheelerTransformer.Inverse(txtTransform.Text);
        }

    }
}
