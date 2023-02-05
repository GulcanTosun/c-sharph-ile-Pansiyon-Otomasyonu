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
    //Data Source=LAPTOP-2BUCSTS1;Initial Catalog=PansiyonDB;Integrated Security=True
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }
        // tc için maxlenght e 11 yazarak girilen değerin sınırını belirledik 
        //lblGunu nun visible false yaparak gözükmesini engelleriz

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-2BUCSTS1;Initial Catalog=PansiyonDB;Integrated Security=True");   // sql bağlantı yolu oluşturuldu
        private void btn101_Click(object sender, EventArgs e)
        {
            txtOdaNum.Text = "101";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda101(adi,soyadi) values ('" + txtAd.Text + "','" + txtSad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn102_Click(object sender, EventArgs e)
        {
            txtOdaNum.Text = "102";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda102(adi,soyadi) values ('" + txtAd.Text + "','" + txtSad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn103_Click(object sender, EventArgs e)
        {
            txtOdaNum.Text = "103";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda103(adi,soyadi) values ('" + txtAd.Text + "','" + txtSad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn104_Click(object sender, EventArgs e)
        {
            txtOdaNum.Text = "104";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda104(adi,soyadi) values ('" + txtAd.Text + "','" + txtSad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void bnt105_Click(object sender, EventArgs e)
        {
            txtOdaNum.Text = "105";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda105(adi,soyadi) values ('" + txtAd.Text + "','" + txtSad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn106_Click(object sender, EventArgs e)
        {
            txtOdaNum.Text = "106";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda106(adi,soyadi) values ('" + txtAd.Text + "','" + txtSad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn107_Click(object sender, EventArgs e)
        {
            txtOdaNum.Text = "107";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda107(adi,soyadi) values ('" + txtAd.Text + "','" + txtSad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn108_Click(object sender, EventArgs e)
        {
            txtOdaNum.Text = "108";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda108(adi,soyadi) values ('" + txtAd.Text + "','" + txtSad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn109_Click(object sender, EventArgs e)
        {
            txtOdaNum.Text = "109";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda109(adi,soyadi) values ('" + txtAd.Text + "','" + txtSad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnDolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı renkli butonlar dolu odaları gösterir.");
        }

        private void BtnBos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil renkli butonlar dolu odaları gösterir.");
        }

        private void FrmYeniMusteri_Load(object sender, EventArgs e)
        {
            //oda101
            baglanti.Open();
            SqlCommand komut = new SqlCommand(" select*from oda101", baglanti);// işi sadeleştirmek için her oda için bir tablo yapıldı.
            SqlDataReader oku1 = komut.ExecuteReader();
            while (oku1.Read())
            {
                btn101.Text = oku1["adi"].ToString() + " " + oku1["soyadi"].ToString();
            }
            baglanti.Close();
            if (btn101.Text != "101")//!= farklıysa demek.
            {
                btn101.BackColor = Color.Red;
                btn101.Enabled = false;
            }

            //oda102
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand(" select*from oda102", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                btn102.Text = oku2["adi"].ToString() + " " + oku2["soyadi"].ToString();
            }
            baglanti.Close();
            if (btn102.Text != "102")
            {
                btn102.BackColor = Color.Red;
                btn102.Enabled = false;
            }

            //oda103
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand(" select*from oda103", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                btn103.Text = oku3["adi"].ToString() + " " + oku3["soyadi"].ToString();
            }
            baglanti.Close();
            if (btn103.Text != "102")
            {
                btn103.BackColor = Color.Red;
                btn103.Enabled = false;
            }

            //oda104
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand(" select*from oda104", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                btn104.Text = oku4["adi"].ToString() + " " + oku4["soyadi"].ToString();
            }
            baglanti.Close();
            if (btn104.Text != "102")
            {
                btn104.BackColor = Color.Red;
                btn104.Enabled = false;
            }

            //oda105
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand(" select*from oda105", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                btn105.Text = oku5["adi"].ToString() + " " + oku5["soyadi"].ToString();
            }
            baglanti.Close();
            if (btn105.Text != "105")
            {
                btn105.BackColor = Color.Red;
                btn105.Enabled = false;
            }

            //oda106
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand(" select*from oda106", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                btn106.Text = oku6["adi"].ToString() + " " + oku6["soyadi"].ToString();
            }
            baglanti.Close();
            if (btn106.Text != "105")
            {
                btn106.BackColor = Color.Red;
                btn106.Enabled = false;
            }

            //oda107
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand(" select*from oda107", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                btn107.Text = oku7["adi"].ToString() + " " + oku7["soyadi"].ToString();
            }
            baglanti.Close();
            if (btn107.Text != "107")
            {
                btn107.BackColor = Color.Red;
                btn107.Enabled = false;
            }

            //oda108
            baglanti.Open();
            SqlCommand komut8 = new SqlCommand(" select*from oda108", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();
            while (oku8.Read())
            {
                btn108.Text = oku8["adi"].ToString() + " " + oku8["soyadi"].ToString();
            }
            baglanti.Close();
            if (btn108.Text != "108")
            {
                btn108.BackColor = Color.Red;
                btn108.Enabled = false; 
            }

            //oda109
            baglanti.Open();
            SqlCommand komut9 = new SqlCommand(" select*from oda109", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();
            while (oku9.Read())
            {
                btn109.Text = oku9["adi"].ToString() + " " + oku9["soyadi"].ToString();
            }
            baglanti.Close();
            if (btn109.Text != "109")
            {
                btn109.BackColor = Color.Red;
                btn109.Enabled = false;
            }
        }

        private void dateTimeCikis_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime kucukTarih = Convert.ToDateTime(dateTimeGiris.Text);
            DateTime buyukTarih = Convert.ToDateTime(dateTimeCikis.Text);
            TimeSpan sonuc;// aradaki farkı alır tımespan
            sonuc = buyukTarih - kucukTarih; 
            lblgun.Text=sonuc.TotalDays.ToString();   
            ucret=Convert.ToInt32(lblgun.Text)*50; 
            txtUcret.Text=ucret.ToString(); 
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();// bağlantı pasif durumda olduğu için burada açıyoruz
            SqlCommand komut=new SqlCommand("insert into MusteriEkle (müsteriAdi,müsteriSadi,Cinsiye,Telefon,Mail,Tc,OdaNo,Ucret,GirisTarihi,CikisTarihi) values('"+ txtAd.Text+"','" +txtSad.Text+"','"+ cmbCinsiyet.Text+"','"+msgTxtTel.Text+"','"+txtMail.Text+"','"+txtTc.Text+"','"+txtOdaNum.Text+"','"+txtUcret.Text+"','"+dateTimeGiris.Value.ToString("yyyy-MM-dd")+"','"+dateTimeCikis.Value.ToString("yyyy-MM-dd") + "')",baglanti );
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müştwei başarılı bir şekilde kaydedildi.");
        }


    }
}
