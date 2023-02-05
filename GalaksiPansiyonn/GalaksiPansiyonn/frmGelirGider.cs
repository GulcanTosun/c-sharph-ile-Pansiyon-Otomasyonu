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
    public partial class frmGelirGider : Form
    {
        public frmGelirGider()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-2BUCSTS1;Initial Catalog=PansiyonDB;Integrated Security=True");
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int personel = Convert.ToInt16(txtPersonelSayisi.Text);
            lblMaas.Text = (personel * 1500).ToString();    // her personelin maaşının 1500 olduğunu varsayıyoruz.
            int sonuc;
            sonuc = Convert.ToInt32(lblTutar.Text)-(Convert.ToInt32(lblMaas.Text)+ Convert.ToInt32(lblUrunToplamTutar.Text)+ Convert.ToInt32(lblUrunToplam2.Text)+ Convert.ToInt32( lblUrunToplam3.Text)+ Convert.ToInt32(lblFatura.Text) + Convert.ToInt32(lblfatura2.Text) + Convert.ToInt32(lblFatura3.Text));
            lblSonuc.Text = sonuc.ToString();
        }

        private void frmGelirGider_Load(object sender, EventArgs e)
        {
            // kasadaki topalm tutar
            baglanti.Open();
            SqlCommand komut = new SqlCommand(" select sum(Ucret) as toplam from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblTutar.Text = oku["toplam"].ToString();
            }
            baglanti.Close();

            // gıda tutar
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand(" select sum(gida) as toplam1 from stoklar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                lblUrunToplamTutar.Text = oku2["toplam1"].ToString();
            }
            baglanti.Close();

            // icecek tutar
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand(" select sum(icecek) as toplam2 from stoklar", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                lblUrunToplam2.Text = oku3["toplam2"].ToString();
            }
            baglanti.Close();


            // cerez tutar
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand(" select sum(cerez) as toplam3 from stoklar", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                lblUrunToplam3.Text = oku4["toplam3"].ToString();
            }
            baglanti.Close();

            // elektrık tutar
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand(" select sum(Elektrik) as toplam4 from Faturalar", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                lblFatura.Text = oku5["toplam4"].ToString();
            }
            baglanti.Close();

            // su tutar
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand(" select sum(Su) as toplam5 from Faturalar", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                lblfatura2.Text = oku6["toplam5"].ToString();
            }
            baglanti.Close();

            // internet tutar
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand(" select sum(Internet) as toplam6 from Faturalar", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                lblFatura3.Text = oku7["toplam6"].ToString();
            }
            baglanti.Close();
        }
    }
}
