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
    public partial class Musteriler : Form
    {
        public Musteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-2BUCSTS1;Initial Catalog=PansiyonDB;Integrated Security=True");

        private void verileriGoster()
        {
            listMusteriler.Items.Clear();   
            baglanti.Open();
            SqlCommand komut = new SqlCommand(" select* from MusteriEkle", baglanti);
            SqlDataReader oku= komut.ExecuteReader();

            while (oku.Read())
            {
               ListViewItem ekle = new  ListViewItem();
                ekle.Text = oku["müsteriID"].ToString();
                ekle.SubItems.Add(oku["müsteriAdi"].ToString());
                ekle.SubItems.Add(oku["MüsteriSadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiye"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["Tc"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());
                
                listMusteriler.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void Musteriler_Load(object sender, EventArgs e)
        {

        }

        private void btnVeriGoster_Click(object sender, EventArgs e)
        {
            verileriGoster();
        }
        int id = 0;
        private void listMusteriler_DoubleClick(object sender, EventArgs e)
        {
            //listte seçilen verileri yukarısındaki textboxlara yazdırmak için kullandığımız kodlar
            id = int.Parse(listMusteriler.SelectedItems[0].SubItems[0].Text);
            txtAd.Text = listMusteriler.SelectedItems[0].SubItems[1].Text;
            txtSad .Text = listMusteriler.SelectedItems[0].SubItems[2].Text;
            cmbCinsiyet.Text = listMusteriler.SelectedItems[0].SubItems[3].Text;
            msgTxtTel.Text = listMusteriler.SelectedItems[0].SubItems[4].Text;
            txtMail.Text = listMusteriler.SelectedItems[0].SubItems[5].Text;
            txtTc .Text = listMusteriler.SelectedItems[0].SubItems[6].Text;
            txtOdaNum.Text = listMusteriler.SelectedItems[0].SubItems[7].Text;
            txtUcret.Text = listMusteriler.SelectedItems[0].SubItems[8].Text;
            dateTimeGiris.Text = listMusteriler.SelectedItems[0].SubItems[9].Text;
            dateTimeCikis.Text = listMusteriler.SelectedItems[0].SubItems[10].Text;

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(txtOdaNum.Text=="101")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda101 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }

            if (txtOdaNum.Text == "102")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda102 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }
            if (txtOdaNum.Text == "103")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda103 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }
            if (txtOdaNum.Text == "104")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda104 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }
            if (txtOdaNum.Text == "105")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda105 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }
            if (txtOdaNum.Text == "106")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda106 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }
            if (txtOdaNum.Text == "107")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda107 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }
            if (txtOdaNum.Text == "108")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda108 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }
            if (txtOdaNum.Text == "109")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda109 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAd.Clear();
            txtSad.Clear();
            cmbCinsiyet.Text = "";
            msgTxtTel.Clear();
            txtMail.Text = "";
            txtTc.Text = "";
            txtOdaNum.Text = "";
            txtUcret.Text = "";
            dateTimeGiris.Text = "";
            dateTimeCikis.Text = "";
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(" update MusteriEkle set müsteriAdi='" + txtAd.Text + "',müsteriSadi='" + txtSad.Text + "',Cinsiye='" + cmbCinsiyet.Text + "',Telefon='" + msgTxtTel.Text +"', Mail='"+txtMail.Text+"',Tc='"+txtTc.Text+"',OdaNo='"+txtOdaNum.Text+"', Ucret='"+txtUcret.Text+"', GirisTarihi='"+dateTimeGiris.Value.ToString("yyyy-MM-dd")+"', CikisTarihi='"+dateTimeCikis.Value.ToString("yyyy-MM-dd")+"' where müsteriID=" + id+"",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verileriGoster();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            listMusteriler.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand(" select* from MusteriEkle where müsteriAdi like '&"+ txtArama.Text+"%'",baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["müsteriID"].ToString();
                ekle.SubItems.Add(oku["müsteriAdi"].ToString());
                ekle.SubItems.Add(oku["MüsteriSadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiye"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["Tc"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listMusteriler.Items.Add(ekle);
            }
            baglanti.Close();
        }
    }
    //SqlCommand komut = new SqlCommand("delete from MusteriEkle where müsteriID=(" + id + ")", baglanti);
}
