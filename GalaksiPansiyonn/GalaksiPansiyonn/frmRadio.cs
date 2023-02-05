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
    public partial class frmRadio : Form
    {
        public frmRadio()
        {
            InitializeComponent();
        }

        private void linkRadio1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Ktalpop
            axWindowsMediaPlayer1.URL = "http://46.20.3.201:80/";
        }

        private void linkRadio2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://77.223.136.16:9920/";
        }

        private void linkRadio3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://cast1.taksim.fm:8014/";
        }
    }
}
