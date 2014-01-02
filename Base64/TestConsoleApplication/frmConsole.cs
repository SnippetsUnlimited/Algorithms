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

        private void btnEncode_Click(object sender, EventArgs e)
        {
            txtEncoded.Text = Company.Algorithms.Text.Base64.Base64Encoder.Encode(txtDecoded.Text, true);
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            txtDecoded.Text = Company.Algorithms.Text.Base64.Base64Encoder.Decode(txtEncoded.Text);
        }
    }
}
