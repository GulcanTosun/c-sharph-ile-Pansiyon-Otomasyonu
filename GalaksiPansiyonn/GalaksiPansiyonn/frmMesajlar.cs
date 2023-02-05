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
    public partial class frmMesajlar : Form
    {
        public frmMesajlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-2BUCSTS1;Initial Catalog=PansiyonDB;Integrated Security=True");

        private void verileriGoster()
        {
           listMesajlar.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand(" select* from MusteriMesaj", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["mesajID"].ToString();
                ekle.SubItems.Add(oku["adsoyad"].ToString());
                ekle.SubItems.Add(oku["mesaj"].ToString());
                listMesajlar.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void frmMesajlar_Load(object sender, EventArgs e)
        {
            verileriGoster();   
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(" insert into MusteriMesaj(adsoyad,mesaj) values('" + txtAdSad.Text + "','" + richTxtMesaj.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }
        int id = 0;
        private void listMesajlar_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listMesajlar.SelectedItems[0].SubItems[0].Text);
            txtAdSad.Text = listMesajlar.SelectedItems[0].SubItems[1].Text;
            richTxtMesaj.Text=listMesajlar.SelectedItems[0].SubItems[2].Text;   

        }
    }
}
