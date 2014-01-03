using Company.Algorithms.Compression.HuffmanTree;
using System;
using System.Collections;
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

        private void btnEncode_Click(object sender, EventArgs e)
        {
            var en = new HuffmanCoding();
            var ft = en.BuildFrequencyTable(txtBinaryData.Text);
            var tr = en.BuildHuffmanTree(ft);

            txtEncodedTree.Text = en.EncodeTree(tr);
            txtResult.Text = en.EncodeData(tr, txtBinaryData.Text);

            lblOriginalLength.Text = txtBinaryData.Text.Length.ToString();
            lblCompressedLength.Text = (txtResult.Text.Length / 8).ToString();
            lblCompressionPercentage.Text = (((txtResult.Text.Length / 8m) * 100) / txtBinaryData.Text.Length).ToString("##.##") + "%";

            var ht = en.Traverse(tr);
            this.PrintTree(ht);
        }

        private void txtBinaryData_KeyDown(object sender, KeyEventArgs e)
        {
            lblOriginalLength.Text = "0";
            lblCompressedLength.Text = "0";
            lblCompressionPercentage.Text = "0%";
        }

        private void btncanonicalize_Click(object sender, EventArgs e)
        {
            var en = new HuffmanCoding();
            var ft = en.BuildFrequencyTable(txtBinaryData.Text);
            var tr = en.BuildHuffmanTree(ft);
            var ht = en.Traverse(tr);
            var htc = en.Canonicalize(ht);
            this.PrintTree(htc);
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            var en = new HuffmanCoding();
            var tr = en.DecodeTree(txtEncodedTree.Text);
            txtResult.Text = en.Decode(tr, txtBinaryData.Text);
        }

        private void PrintTree(Dictionary<char, string> ht)
        {
            txtTree.Text = string.Empty;

            foreach (char c in ht.Keys)
            {
                txtTree.Text += (c + " -> " + ht[c].ToString() + Environment.NewLine);
            }
        }

        private void btnCopyToInput_Click(object sender, EventArgs e)
        {
            txtBinaryData.Text = txtResult.Text;
        }

    }
}
