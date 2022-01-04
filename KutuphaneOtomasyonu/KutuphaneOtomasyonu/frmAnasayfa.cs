using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KitapEklefrm kitapEklefrm = new KitapEklefrm();
            kitapEklefrm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KitapListelefrm kitapListelefrm = new KitapListelefrm();
            kitapListelefrm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmanetKitapVerme emanetKitapVerme = new EmanetKitapVerme();
            emanetKitapVerme.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sıralamafrm sıralamafrm = new Sıralamafrm();
            sıralamafrm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Grafikfrm grafikfrm = new Grafikfrm();
            grafikfrm.ShowDialog();
        }

        private void frmAnasayfa_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
