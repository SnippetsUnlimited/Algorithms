using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestConsoleApplication
{
    public partial class frmConsole : Form
    {
        public frmConsole()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int result = Company.Algorithms.Text.Bitap.Bitap.MatchExact32Bit(txtSearchableText.Text, txtSearchWord.Text);

            if (result > -1)
            {
                txtSearchableText.Select(result, txtSearchWord.Text.Length);
            }
            else
            {
                MessageBox.Show("Match not found");
            }
        
        
        
        }

        private void btnFuzzySearch_Click(object sender, EventArgs e)
        {
            int result = Company.Algorithms.Text.Bitap.Bitap.MatchFuzzy32Bit(txtSearchableText.Text, txtSearchWord.Text, (int)numDistance.Value);

            if (result > -1)
            {
                txtSearchableText.Select(result, txtSearchWord.Text.Length);
            }
            else
            {
                MessageBox.Show("Match not found");
            }
        }

    }
}
