using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    class Kullanıcı_Forum
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-2JB9NOI;Initial Catalog=Kullanıcı_Girişi;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader read;
        frmAnasayfa anasayfa = new frmAnasayfa();
        public SqlDataReader kullanici(TextBox kullanıcıadi, TextBox sifre)
        {
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select * from uye where kullanıcıadi='"+kullanıcıadi.Text+"'";
            read = komut.ExecuteReader();
            if (read.Read()==true)
            {
                if (sifre.Text==read["sifre"].ToString())
                {
                    MessageBox.Show("Giriş yapıldı.");
                    anasayfa.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Şifrenizi kontrol ediniz");
                }
            }
            else
            {
                MessageBox.Show("Bilgilerinizi kontrol ediniz");

           }
            baglanti.Close();
            return read;
        }
        public void yenikullanıcı(TextBox adsoyad, TextBox kullancıadi, TextBox sifre, TextBox sifretekrar, TextBox tc,GroupBox grup)
        {
            if (sifre.Text==sifretekrar.Text)
            {
                baglanti.Open();
                komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "İnsert İnto uye() values('"+adsoyad.Text+"','"+kullancıadi.Text+"','"+sifre.Text+"','"+tc.Text+"')";
                baglanti.Close();
                MessageBox.Show("Üye Kaydı Yapıldı");
                foreach (Control item in grup.Controls) if (item is TextBox) item.Text = "";
            }
            else
            {
                MessageBox.Show("Şifreler uyuşmuyor!");
            }
        }
    }

}
