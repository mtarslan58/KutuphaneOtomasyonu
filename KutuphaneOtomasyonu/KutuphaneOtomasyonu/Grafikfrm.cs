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
    public partial class Grafikfrm : Form
    {
        public Grafikfrm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-2JB9NOI;Initial Catalog=Kullanıcı_Girişi;Integrated Security=True");
        DataSet daset = new DataSet();
        private void Grafikfrm_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select adsoyad,okunankitapsayisi from uye",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                chart1.Series["Okunan Kitap Sayısı"].Points.AddXY(read["adsoyad"].ToString(), read["okunankitapsayisi"]);
            }
            
            baglanti.Close();
            chart1.Series["Okunan Kitap Sayısı"].Color = Color.Orange;
            
        }
    }
}
