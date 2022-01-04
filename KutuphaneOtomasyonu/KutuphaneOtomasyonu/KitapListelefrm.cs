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
    public partial class KitapListelefrm : Form
    {
        public KitapListelefrm()
        {
            InitializeComponent();
        }
        
        private void btngüncelle_Click(object sender, EventArgs e)
        {

            SqlConnection komut = new SqlConnection(baglanti);
            komut.Open();
            SqlCommand cmd = new SqlCommand("update kitapEkleme set kitapadi=@kitapadi,yazari=@yazari,yayinevi=@yayinevi,sayfasayisi=@sayfasayisi,turu=@turu,stoksayisi=@stoksayisi,rafno=@rafno,aciklama=@aciklama where barkodno = @barkodno", komut);

            cmd.Parameters.AddWithValue("@barkodno", txtbarkodnoG.Text);
            cmd.Parameters.AddWithValue("@kitapadi", txtkitapadıG.Text);
            cmd.Parameters.AddWithValue("@yazari", txtyazarıG.Text);
            cmd.Parameters.AddWithValue("@yayinevi", txtyayıneviG.Text);
            cmd.Parameters.AddWithValue("@turu", cmbboxtürüG.Text);
            cmd.Parameters.AddWithValue("@sayfasayisi", txtsayfasayısıG.Text);
            cmd.Parameters.AddWithValue("@stoksayisi", txtstoksayısıG.Text);
            cmd.Parameters.AddWithValue("@rafno", txtrafnoG.Text);
            cmd.Parameters.AddWithValue("@aciklama", txtacıklamaG.Text);
            cmd.ExecuteNonQuery();
            komut.Close();

            MessageBox.Show("GÜNCELLEME YAPILDI");

            dataGridView1.DataSource = daset.Tables["kitapEkleme"];
            kitaplistele();

            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }

            }
        }
        string baglanti = "Data Source=DESKTOP-2JB9NOI;Initial Catalog=Kullanıcı_Girişi;Integrated Security=True";
        DataSet daset = new DataSet();
        private void kitaplistele()
        {
            SqlConnection komut = new SqlConnection(baglanti);
            komut.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from kitapEkleme", komut);
            adtr.Fill(daset, "kitapEkleme");
            dataGridView1.DataSource = daset.Tables["kitapEkleme"];
            komut.Close();
        }
        private void KitapListelefrm_Load(object sender, EventArgs e)
        {
            kitaplistele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bu kayıt silecenektir. Emin misiniz ?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                SqlConnection komut = new SqlConnection(baglanti);
                komut.Open();
                SqlCommand cmd = new SqlCommand("delete from kitapEkleme where barkodno=@barkodno", komut);
                cmd.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
                cmd.ExecuteNonQuery();
                komut.Close();
                MessageBox.Show("SİLME İŞLEMİ GERÇEKLEŞTİ.");
               // daset.Tables["kitapEkleme"].Clear();
                kitaplistele(); 
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void KitapListelefrm_Load_1(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-2JB9NOI;Initial Catalog=Kullanıcı_Girişi;Integrated Security=True");

        private void btnkitaplisteleme_Click(object sender, EventArgs e)
        {
            con.Open();
            string sel = "Select * from kitapEkleme";
            SqlDataAdapter da = new SqlDataAdapter(sel, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtbarkodnoG_TextChanged(object sender, EventArgs e)
        {
            SqlConnection komut = new SqlConnection(baglanti);
            komut.Open();
            SqlCommand cmd = new SqlCommand("select * from kitapEkleme where barkodno like'" + txtbarkodnoG.Text + "'", komut);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                txtkitapadıG.Text = read["kitapadi"].ToString();
                txtyazarıG.Text = read["yazari"].ToString();
                txtyayıneviG.Text = read["yayinevi"].ToString();
                txtsayfasayısıG.Text = read["sayfasayisi"].ToString();
                cmbboxtürüG.Text = read["turu"].ToString();
                txtstoksayısıG.Text = read["stoksayisi"].ToString();
                txtrafnoG.Text = read["rafno"].ToString();
                txtacıklamaG.Text = read["aciklama"].ToString();
            }
            komut.Close();
        }

        private void btnsil_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bu kayıt silecenektir. Emin misiniz ?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                SqlConnection komut = new SqlConnection(baglanti);
                komut.Open();
                SqlCommand cmd = new SqlCommand("delete from kitapEkleme where barkodno=@barkodno", komut);
                cmd.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
                cmd.ExecuteNonQuery();
                komut.Close();
                MessageBox.Show("SİLME İŞLEMİ GERÇEKLEŞTİ.");
                //daset.Tables["kitapEkleme"].Clear();
                kitaplistele();
            }
        }
    }
    
}
