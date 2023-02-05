using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace GalaksiPansiyonn
{
    public partial class frmSifreGuncelle : Form
    {
        public frmSifreGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-2BUCSTS1;Initial Catalog=PansiyonDB;Integrated Security=True");
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update AdminGiris set Kullanici='" + txtKullaniciAdi.Text + "',Sifre='" + txtSifre.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
