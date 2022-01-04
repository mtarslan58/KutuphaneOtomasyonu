using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class frmKullanıcı : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-2JB9NOI;Initial Catalog=Kullanıcı_Girişi;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader read;
        public frmKullanıcı()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //frmSifre sifre = new frmSifre();
           // sifre.ShowDialog();
        }
        //Kullanıcı_Forum k = new Kullanıcı_Forum();
        private void button1_Click(object sender, EventArgs e)
        {
            KullaniciGiris();
            //k.kullanici(txtkullaniciadigiris, txtSifreGiris);
        }

        private void KullaniciGiris()
        {
            frmAnasayfa anasayfa = new frmAnasayfa();
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select * from uye where kullanıcıadi='" + txtkullaniciadigiris.Text + "'";
            read = komut.ExecuteReader();
            if (read.Read() == true)
            {
                if (txtSifreGiris.Text == read["sifre"].ToString())
                {
                    MessageBox.Show("Giriş yapıldı.");
                    this.Hide();
                    anasayfa.lblAnasayfaKullaniciAdi.Text = read["kullanıcıadi"].ToString();
                    anasayfa.Show();
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
            //return read;
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            KullaniciKayit();
            //k.yenikullanıcı(adsoyadtxt,txtkullaniciadikayit,txtsifre,txttekrarsifre,txttc,groupBox2);
        }

        private void KullaniciKayit()
        {
            if (txtSifreKayit.Text == txtSifreKayitTekrar.Text)
            {
                baglanti.Open();
                komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "insert into uye(adsoyad, kullanıcıadi, sifre, tc, yas, cinsiyet,telefon,email,okunankitapsayisi) values('" + adsoyadtxt.Text + "','" + txtkullaniciadikayit.Text + "','" + txtSifreKayit.Text + "','" + txttc.Text + "','" + txtyas.Text + "','" + cmbcinsiyet.Text + "','" + txttelefon.Text + "','" + txtemail.Text + "','" + txtokukitapsayısı.Text + "')";
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Üye Kaydı Yapıldı");
                foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmKullanıcı_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
