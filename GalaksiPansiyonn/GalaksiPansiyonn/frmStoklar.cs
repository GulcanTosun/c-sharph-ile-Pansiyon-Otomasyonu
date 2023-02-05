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
    public partial class frmStoklar : Form
    {
        public frmStoklar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-2BUCSTS1;Initial Catalog=PansiyonDB;Integrated Security=True");

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
        }
        private void veriler()
        {
            listtablo.Items.Clear(); 
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from stoklar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["gida"].ToString();
                ekle.SubItems.Add(oku["icecek"].ToString());
                ekle.SubItems.Add(oku["cerez"].ToString());
                listtablo.Items.Add(ekle);  

            }
            baglanti.Close();
        }

        private void veriler2()
        {
            listFatura.Items.Clear();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Faturalar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku2["Elektrik"].ToString();
                ekle.SubItems.Add(oku2["Su"].ToString());
                ekle.SubItems.Add(oku2["Internet"].ToString());
                listFatura.Items.Add(ekle);

            }
            baglanti.Close();
        }

        private void frmStoklar_Load(object sender, EventArgs e)
        {
            veriler();
            veriler2();
        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(" insert into stoklar(gida,icecek,cerez) values ('" + txtGida.Text + "','" + txtIcecek.Text + "','" + txtAtistirmalik.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriler();

        }

        private void btnKaydet2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(" insert into Faturalar(Elektrik,Su,Internet) values ('" + txtElektrik.Text + "','" + txtSu.Text + "','" + txtInternet.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriler2();
        }
    }
}
