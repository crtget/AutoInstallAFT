using System;
using System.Windows.Forms;

namespace AutoInstallAFT
{
    public partial class FastSegaTools : Form
    {
        public AutoInstller ai = new AutoInstller();
        public string divapath;
        public FastSegaTools()
        {
            InitializeComponent();
        }

        private void Setini_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test");
            divapath = ai.pathBox.Text;
        }
    }
}