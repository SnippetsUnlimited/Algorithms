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

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                var words = System.IO.File.ReadAllLines(txtDictionary.Text);

                foreach (var item in words)
                {
                    bloom.AddWord(item);
                }

                lbWords.DataSource = words;

                MessageBox.Show("Dictionary successfully loaded.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        Company.Algorithms.Text.BloomFilter.BloomFilter bloom = new Company.Algorithms.Text.BloomFilter.BloomFilter();

        private void frmConsole_Load(object sender, EventArgs e)
        {
            var hf1 = new Company.Algorithms.Text.BloomFilter.CustomHashFunction01();
            var hf2 = new Company.Algorithms.Text.BloomFilter.CustomHashFunction02();

            bloom.AddHashFunction(hf1);
            lbHashFunctions.Items.Add(hf1.Name);

            bloom.AddHashFunction(hf2);
            lbHashFunctions.Items.Add(hf2.Name);

            bloom.Initialize();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool found = bloom.MayContain(txtSearch.Text);
            lbResults.Items.Clear();
            var result = bloom.GetAnalysis(txtSearch.Text);

            foreach (var item in result)
            {
                lbResults.Items.Add(string.Format("{0} -> {1}", item.Key, (item.Value) ? "found" : "not found"));
            }

            if (found)
            {
                MessageBox.Show("Success! - May contain the word.");
            }
            else
            {
                MessageBox.Show("Failure! - Does not contain the word.");
            }


        }
    }
}
