using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;// veri tabanını kullanabilmek için kütüphaneye eklenmesi gerek.
using System.Data.SqlClient;// veri tabanını kullanabilmek için kütüphaneye eklenmesi gerek.

namespace GalaksiPansiyonn
{
    public partial class frmAdminGiris : Form
    {
        public frmAdminGiris()
        {
            InitializeComponent();
        }
        // bağlantıya heryerden erişebilmek için globale tanımlanmıştır.
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-2BUCSTS1;Initial Catalog=PansiyonDB;Integrated Security=True"); 
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            //hata yakalamak için try-catch kullanılmıştır.
            try
            {
                baglanti.Open(); //globalde tanımladığımız VT için bağlatıyı aktif hale getirilir.
                string sql = " select*from AdminGiris where kullanici=@kullanici AND Sifre=@Sifre"; //AdminGiris tablosundan kullanıcı adı ve şifreyi alarak parametre yolu ile veriler karşılatırılır.
                SqlParameter prmt1 = new SqlParameter("kullanici", txtKullaniciAdi.Text);
                SqlParameter prmt2 = new SqlParameter("Sifre", txtSifre.Text);
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prmt1);    
                komut.Parameters.Add(prmt2);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);    
                if(dt.Rows.Count > 0)
                {
                    FrmAnaForm fr = new FrmAnaForm();
                    fr.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı giriş");
            }
        }
    }
}
