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
    public partial class EmanetKitapVerme : Form
    {
        public EmanetKitapVerme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-2JB9NOI;Initial Catalog=Kullanıcı_Girişi;Integrated Security=True");
        DataSet daset = new DataSet();
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void sepetListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("Select * from sepet", baglanti);
            adtr.Fill(daset, "sepet");
            dataGridView1.DataSource = daset.Tables["uye"];
            baglanti.Close();
        }
        private void btnekleemanetverme_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtkitapsayisi.Text) <= 10)
            {
                if (txttc.Text != "" && txtadsoyad.Text != "" && txtyas.Text != "" && txttelefon.Text != "")
                {

                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert into sepet(barkodno,kitapadi,yazari,yayinevi,sayfasayisi,kitapsayisi) values(@barkodno,@kitapadi,@yazari,@yayinevi,@sayfasayisi,@kitapsayisi)", baglanti);
                    komut.Parameters.AddWithValue("@barkodno", txtbarkodno.Text);
                    komut.Parameters.AddWithValue("@kitapadi", txtkitapadi.Text);
                    komut.Parameters.AddWithValue("@yazari", txtyazari.Text);
                    komut.Parameters.AddWithValue("@yayinevi", txtyayinevi.Text);
                    komut.Parameters.AddWithValue("@sayfasayisi", txtsayfasayisi.Text);
                    komut.Parameters.AddWithValue("@kitapsayisi", txtkitapsayisi.Text);
                    // komut.Parameters.AddWithValue("@teslimtaraihi", "1");
                    // komut.Parameters.AddWithValue("@iadetarihi", "1");
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kitap(lar) eklendi", "Ekleme İşlemi");
                    daset.Tables["sepet"].Clear();
                    sepetListele();
                    lblkitapsayisi.Text = " ";
                    kitapsayisi();
                    foreach (Control item in groupBox2.Controls)
                    {
                        if (item is TextBox)
                        {
                            if (item != txtkitapsayisi)
                            {
                                item.Text = "";
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Kitap sayısı 3 den fazla olamaz !");
            }
        }

        private void kitapsayisi()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(kitapsayisi) from Sepet ", baglanti);
            lblkitapsayisi.Text = komut.ExecuteScalar().ToString();
            baglanti.Close();
        }
        private void EmanetKitapVerme_Load(object sender, EventArgs e)
        {
            sepetListele();
            kitapsayisi();
        }

        private void txtemanetverme_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from uye where tc like '" + txttc + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtadsoyad.Text = read["adsoyad"].ToString();
                txtyas.Text = read["yas"].ToString();
                txttelefon.Text = read["telefon"].ToString();

            }
            baglanti.Close();

            //baglanti.Open();
           // SqlCommand komut2 = new SqlCommand("select sum(kitapsayisi) from EmanetKitaplar",baglanti);
            //lblkayitlikitap.Text = komut2.ExecuteScalar().ToString();
           // baglanti.Close();


            if (txttc.Text == "")
            {
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                        lblkayitlikitap.Text = "";
                    }
                }
            }
        }

        private void txtbarkodnoemanetverme_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kitapEkleme where barkodno like '" + txtbarkodno.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtkitapadi.Text = read["kitapadi"].ToString();
                txtkitapadi.Text = read["yazari"].ToString();
                txtkitapadi.Text = read["yayinevi"].ToString();
                txtkitapadi.Text = read["sayfasayisi"].ToString();

            }
            baglanti.Close();
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    if (item != txtkitapsayisi)
                    {
                        item.Text = "";
                    }

                }
            }
        }

        private void btnsilemanetverme_Click(object sender, EventArgs e)
        {
           

        }

        private void btnteslimvermeemanetver_Click(object sender, EventArgs e)
        {
            if (lblkitapsayisi.Text != "")
            {


                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert into EmanetKitaplar(tc,adsoyad,yas,telefon,barkodno,kitapadi,yazari,yayinevi,sayfasayisi,kitapsayisi,teslimtarihi,iadetarihi)values(@tc,@adsoyad,@yas,@telefon,@barkodno,@kitapadi,@yazari,@yayinevi,@sayfasayisi,@kitapsayisi,@teslimtarihi,@iadetarihi)", baglanti);
                    komut.Parameters.AddWithValue("@tc", txttc.Text);
                    komut.Parameters.AddWithValue("@adsoyad", txtadsoyad.Text);
                    komut.Parameters.AddWithValue("@yas", txtyas.Text);
                    komut.Parameters.AddWithValue("@telefon", txttelefon.Text);
                    komut.Parameters.AddWithValue("barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
                    komut.Parameters.AddWithValue("kitapadi", dataGridView1.Rows[i].Cells["kitapadi"].Value.ToString());
                    komut.Parameters.AddWithValue("yazari", dataGridView1.Rows[i].Cells["yazari"].Value.ToString());
                    komut.Parameters.AddWithValue("yayinevi", dataGridView1.Rows[i].Cells["yayinevi"].Value.ToString());
                    komut.Parameters.AddWithValue("sayfasayisi", dataGridView1.Rows[i].Cells["sayfasayisi"].Value.ToString());
                    komut.Parameters.AddWithValue("kitapsayisi", int.Parse(dataGridView1.Rows[i].Cells["kitapsayisi"].Value.ToString()));
                    komut.Parameters.AddWithValue("teslimtarihi", dataGridView1.Rows[i].Cells["teslimtarihi"].Value.ToString());
                    komut.Parameters.AddWithValue("iadetarihi", dataGridView1.Rows[i].Cells["iadetarihi"].Value.ToString());
                    komut.ExecuteNonQuery();
                    SqlCommand komut2 = new SqlCommand("update uye set okunankitapsayisi+'" + int.Parse(dataGridView1.Rows[i].Cells["kitapsayisi"].Value.ToString()) + "' where tc = '" + txttc.Text + "'", baglanti);
                    komut2.ExecuteNonQuery();
                    SqlCommand komut3 = new SqlCommand("update kitapEkleme set stoksayisi =stoksayisi-'" + int.Parse(dataGridView1.Rows[i].Cells["kitapsayisi"].Value.ToString()) + "' where barkodno = '" + dataGridView1.Rows[i].Cells["barkodno"].Value.ToString() + "'", baglanti);
                    komut3.ExecuteNonQuery();
                    baglanti.Close();


                }

                baglanti.Open();
                SqlCommand komut4 = new SqlCommand("delete from sepet", baglanti);
                komut4.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kitap emanet edildi.");
                daset.Tables["sepet"].Clear();
                sepetListele();
                txttc.Text = "";
                lblkitapsayisi.Text = "";
                kitapsayisi();
                lblkayitlikitap.Text = "";
                //komut satırı






            }
            else
            {
                MessageBox.Show("Önce sepete kitap eklemelidir.", "UYARI");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void btnlistele_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sel = "Select * from sepet";
            SqlDataAdapter da = new SqlDataAdapter(sel, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void txtbarkodno_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kitapEkleme where barkodno like '"+txtbarkodno.Text+"'",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtkitapadi.Text = read["kitapadi"].ToString();
                txtyazari.Text = read["yazari"].ToString();
                txtyayinevi.Text = read["yayinevi"].ToString();
                txtsayfasayisi.Text = read["sayfasayisi"].ToString();
            }
            baglanti.Close();
            if (txtbarkodno.Text=="")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtkitapsayisi)
                        {
                            item.Text = "";
                        }
                    }
                }
            }
            
        }
    }
}