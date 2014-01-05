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

        private void txtSearchWord_KeyUp(object sender, KeyEventArgs e)
        {
            DateTime then = DateTime.Now;
            var result = trie.GetMatches(txtSearchWord.Text);
            DateTime now = DateTime.Now;
            lblProcessingTime.Text = now.Subtract(then).Ticks.ToString();
            lbResult.DataSource = result;
            lblResultCount.Text = result.Count + " words";
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

        Company.Algorithms.Text.Trie.Trie trie = new Company.Algorithms.Text.Trie.Trie();

        private void btnLoad_Click(object sender, EventArgs e)
        {
            trie.Reset();
            string[] words = System.IO.File.ReadAllLines(txtDictionary.Text);

            foreach (var item in words)
            {
                trie.AddWord(item);
            }
        }
    }
}
