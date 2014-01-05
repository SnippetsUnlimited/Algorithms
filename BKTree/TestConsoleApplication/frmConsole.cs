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
            fd.Filter = "*.txt|*.txt";

            if (System.IO.File.Exists(fd.FileName))
            {
                txtDictionary.Text = fd.FileName;
            }
        }

        Company.Algorithms.Text.BKTree.BKTree bkTree = new Company.Algorithms.Text.BKTree.BKTree();

        private void btnLoad_Click(object sender, EventArgs e)
        {

            try
            {
                var words = System.IO.File.ReadAllLines(txtDictionary.Text);
                bkTree.Reset();

                foreach (var item in words)
                {
                    bkTree.AddWord(item);
                }

                MessageBox.Show("Dictionary successfully loaded.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearchWord_KeyUp(object sender, KeyEventArgs e)
        {
            DateTime then = DateTime.Now;
            bkTree.Tolerance = 1;
            var result = bkTree.GetSuggestions(txtSearchWord.Text);

            DateTime now = DateTime.Now;
            lblProcessingTime.Text = now.Subtract(then).Ticks.ToString();

            lbResult.DataSource = result;
            lblResultCount.Text = result.Count + " words";
        }

        private void numTolerance_ValueChanged(object sender, EventArgs e)
        {
            txtSearchWord_KeyUp(sender, new KeyEventArgs(Keys.Cancel));
        }

    }
}
