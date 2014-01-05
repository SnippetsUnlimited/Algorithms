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

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();
            fd.CheckFileExists = true;
            fd.Filter = "*.txt|*.txt";

            if (System.IO.File.Exists(fd.FileName))
            {
                txtDictionary.Text = fd.FileName;
            }
        }

        private void txtSearchWord_KeyUp(object sender, KeyEventArgs e)
        {
            List<string> result = new List<string>();
            DateTime then = DateTime.Now;

            foreach (string item in words)
            {
                if (Company.Algorithms.Text.LevenshteinDistance.LevenshteinDistance.GetDistance(txtSearchWord.Text, item, chkApplyDamerauDistance.Checked) <= numTolerance.Value)
                {
                    result.Add(item);
                }
            }

            DateTime now = DateTime.Now;
            lblProcessingTime.Text = now.Subtract(then).Ticks.ToString();

            lbResult.DataSource = result;
            lblResultCount.Text = result.Count + " words";
        }

        string[] words = null;

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                words = System.IO.File.ReadAllLines(txtDictionary.Text);
                MessageBox.Show("Dictionary successfully loaded.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void numTolerance_ValueChanged(object sender, EventArgs e)
        {
            txtSearchWord_KeyUp(sender, new KeyEventArgs(Keys.Cancel));
        }

        private void chkApplyDamerauDistance_CheckedChanged(object sender, EventArgs e)
        {
            txtSearchWord_KeyUp(sender, new KeyEventArgs(Keys.Cancel));
        }


    }
}
