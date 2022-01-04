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
    public partial class KitapEklefrm : Form
    {
        public KitapEklefrm()
        {
            InitializeComponent();
        }
        string baglanti = "Data Source=DESKTOP-2JB9NOI;Initial Catalog=Kullanıcı_Girişi;Integrated Security=True";
        private void KitapEklefrm_Load(object sender, EventArgs e)
        {

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlConnection komut = new SqlConnection(baglanti);
            komut.Open();
            SqlCommand cmd = new SqlCommand("insert into kitapEkleme(barkodno,kitapadi,yazari,yayinevi,sayfasayisi,turu,stoksayisi,rafno,aciklama,kayittarihi) values(@barkodno,@kitapadi,@yazari,@yayinevi,@sayfasayisi,@turu,@stoksayisi,@rafno,@aciklama,@kayittarihi)", komut);


            cmd.Parameters.AddWithValue("@barkodno", txtbarkodno.Text);
            cmd.Parameters.AddWithValue("@kitapadi", txtkitapadı.Text);
            cmd.Parameters.AddWithValue("@yazari", txtyazarı.Text);
            cmd.Parameters.AddWithValue("@yayinevi", txtyayınevi.Text);
            cmd.Parameters.AddWithValue("@turu", cmbboxtürü.Text);
            cmd.Parameters.AddWithValue("@sayfasayisi", txtsayfasayısı.Text);
            cmd.Parameters.AddWithValue("@stoksayisi", txtstoksayısı.Text);
            cmd.Parameters.AddWithValue("@rafno", txtrafno.Text);
            cmd.Parameters.AddWithValue("@aciklama", txtacıklama.Text);
            cmd.Parameters.AddWithValue("@kayittarihi", DateTime.Now.ToShortDateString());
            cmd.ExecuteNonQuery();
            komut.Close();


            MessageBox.Show("KİTAP KAYIDI YAPILDI");



            foreach (Control item in Controls)
            {
                item.Text = "";
            }
        }
    }
}
