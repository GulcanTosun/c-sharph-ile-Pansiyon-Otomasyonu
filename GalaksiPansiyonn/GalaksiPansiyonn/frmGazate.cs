using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GalaksiPansiyonn
{
    public partial class frmGazete : Form
    {
        public frmGazete()
        {
            InitializeComponent();
        }

        private void btnHurriyet_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.hurriyet.com.tr/");
        }

        private void btnMilliyet_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.milliyet.com.tr/");
        }

        private void btnSozcu_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.sozcu.com.tr/");
        }

        private void btnHaberturk_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://m.haberturk.com/");
        }

        private void btnFanatik_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.fanatik.com.tr/");
        }

        private void frmGazete_Load(object sender, EventArgs e)
        {

        }
    }
}
