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
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            tmrSaatTarih.Start();
        }

        private void btnAdminGiris_Click(object sender, EventArgs e)
        {
            frmAdminGiris fr = new frmAdminGiris();
            fr.Show();
        }

        private void btnYeniMusteri_Click(object sender, EventArgs e)
        {
            FrmYeniMusteri fr = new FrmYeniMusteri();   
            fr.Show();
        }

        private void btnOdalar_Click(object sender, EventArgs e)
        {
            frmOdalar fr = new frmOdalar();
            fr.Show();
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            Musteriler fr = new Musteriler();   
            fr.Show();
        }

        private void btnGelirGider_Click(object sender, EventArgs e)
        {
            frmGelirGider fr = new frmGelirGider(); 
            fr.Show();
        }

        private void btnStoklar_Click(object sender, EventArgs e)
        {
            frmStoklar fr = new frmStoklar();   
            fr.Show();
        }

        private void btnMusteriMesaj_Click(object sender, EventArgs e)
        {
            frmMesajlar fr = new frmMesajlar(); 
            fr.Show();
        }

        private void btnRadio_Click(object sender, EventArgs e)
        {
            frmRadio fr = new frmRadio(); 
            fr.Show();    
        }

        private void btnHakkimizda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Galaksi Pansiyon 2023/Sakarya");
        }

        private void tmrSaatTarih_Tick(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToLongDateString();
            lblSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnGazeteler_Click(object sender, EventArgs e)
        {
            frmGazete fr = new frmGazete();
            fr.Show();
        }

        private void btnSifreGuncelle_Click(object sender, EventArgs e)
        {
            frmSifreGuncelle fr = new frmSifreGuncelle();   
            fr.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
