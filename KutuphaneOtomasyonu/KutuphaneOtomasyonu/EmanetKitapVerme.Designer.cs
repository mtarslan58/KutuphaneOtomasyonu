
namespace KutuphaneOtomasyonu
{
    partial class EmanetKitapVerme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtadsoyad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtyas = new System.Windows.Forms.TextBox();
            this.txttc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txttelefon = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtbarkodno = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.datetimeiadetarih = new System.Windows.Forms.DateTimePicker();
            this.datetimeteslim = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtsayfasayisi = new System.Windows.Forms.TextBox();
            this.txtkitapsayisi = new System.Windows.Forms.TextBox();
            this.txtkitapadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtyazari = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtyayinevi = new System.Windows.Forms.TextBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.btniptal = new System.Windows.Forms.Button();
            this.btnteslim = new System.Windows.Forms.Button();
            this.lblkayitlikitap = new System.Windows.Forms.Label();
            this.lblkitapsayisi = new System.Windows.Forms.Label();
            this.kutuphaneOtomasyonuDataSet = new KutuphaneOtomasyonu.KutuphaneOtomasyonuDataSet();
            this.kutuphaneOtomasyonuDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kullanıcı_GirişiDataSet = new KutuphaneOtomasyonu.Kullanıcı_GirişiDataSet();
            this.kullanıcıGirişiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnlistele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneOtomasyonuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneOtomasyonuDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanıcı_GirişiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanıcıGirişiDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtadsoyad);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtyas);
            this.groupBox1.Controls.Add(this.txttc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txttelefon);
            this.groupBox1.Location = new System.Drawing.Point(13, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 198);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye Bilgileri";
            // 
            // txtadsoyad
            // 
            this.txtadsoyad.Location = new System.Drawing.Point(103, 71);
            this.txtadsoyad.Name = "txtadsoyad";
            this.txtadsoyad.Size = new System.Drawing.Size(155, 22);
            this.txtadsoyad.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "T.C";
            // 
            // txtyas
            // 
            this.txtyas.Location = new System.Drawing.Point(103, 111);
            this.txtyas.Name = "txtyas";
            this.txtyas.PasswordChar = '*';
            this.txtyas.Size = new System.Drawing.Size(155, 22);
            this.txtyas.TabIndex = 26;
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(105, 32);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(155, 22);
            this.txttc.TabIndex = 22;
            this.txttc.Text = " ";
            this.txttc.TextChanged += new System.EventHandler(this.txtemanetverme_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(5, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ad Soyad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = " Yaş";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Telefon";
            // 
            // txttelefon
            // 
            this.txttelefon.Location = new System.Drawing.Point(103, 150);
            this.txttelefon.Name = "txttelefon";
            this.txttelefon.PasswordChar = '*';
            this.txttelefon.Size = new System.Drawing.Size(155, 22);
            this.txttelefon.TabIndex = 27;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtbarkodno);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.datetimeiadetarih);
            this.groupBox2.Controls.Add(this.datetimeteslim);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtsayfasayisi);
            this.groupBox2.Controls.Add(this.txtkitapsayisi);
            this.groupBox2.Controls.Add(this.txtkitapadi);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtyazari);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtyayinevi);
            this.groupBox2.Location = new System.Drawing.Point(13, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 349);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap Bilgileri";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtbarkodno
            // 
            this.txtbarkodno.Location = new System.Drawing.Point(105, 31);
            this.txtbarkodno.Name = "txtbarkodno";
            this.txtbarkodno.Size = new System.Drawing.Size(153, 22);
            this.txtbarkodno.TabIndex = 42;
            this.txtbarkodno.TextChanged += new System.EventHandler(this.txtbarkodno_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(-3, 265);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 17);
            this.label11.TabIndex = 40;
            this.label11.Text = " Teslim Tarihi";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 303);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 17);
            this.label12.TabIndex = 41;
            this.label12.Text = " İade Tarihi";
            // 
            // datetimeiadetarih
            // 
            this.datetimeiadetarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimeiadetarih.Location = new System.Drawing.Point(103, 304);
            this.datetimeiadetarih.Name = "datetimeiadetarih";
            this.datetimeiadetarih.Size = new System.Drawing.Size(155, 22);
            this.datetimeiadetarih.TabIndex = 4;
            // 
            // datetimeteslim
            // 
            this.datetimeteslim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimeteslim.Location = new System.Drawing.Point(103, 265);
            this.datetimeteslim.Name = "datetimeteslim";
            this.datetimeteslim.Size = new System.Drawing.Size(155, 22);
            this.datetimeteslim.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 17);
            this.label9.TabIndex = 38;
            this.label9.Text = "Sayfa Sayısı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 17);
            this.label10.TabIndex = 39;
            this.label10.Text = "Kitap Sayısı";
            // 
            // txtsayfasayisi
            // 
            this.txtsayfasayisi.Location = new System.Drawing.Point(103, 187);
            this.txtsayfasayisi.Name = "txtsayfasayisi";
            this.txtsayfasayisi.PasswordChar = '*';
            this.txtsayfasayisi.Size = new System.Drawing.Size(155, 22);
            this.txtsayfasayisi.TabIndex = 36;
            // 
            // txtkitapsayisi
            // 
            this.txtkitapsayisi.Location = new System.Drawing.Point(103, 226);
            this.txtkitapsayisi.Name = "txtkitapsayisi";
            this.txtkitapsayisi.PasswordChar = '*';
            this.txtkitapsayisi.Size = new System.Drawing.Size(155, 22);
            this.txtkitapsayisi.TabIndex = 37;
            // 
            // txtkitapadi
            // 
            this.txtkitapadi.Location = new System.Drawing.Point(103, 70);
            this.txtkitapadi.Name = "txtkitapadi";
            this.txtkitapadi.Size = new System.Drawing.Size(155, 22);
            this.txtkitapadi.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Barkod No";
            // 
            // txtyazari
            // 
            this.txtyazari.Location = new System.Drawing.Point(103, 109);
            this.txtyazari.Name = "txtyazari";
            this.txtyazari.PasswordChar = '*';
            this.txtyazari.Size = new System.Drawing.Size(155, 22);
            this.txtyazari.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Kitap Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = " Yazarı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 30;
            this.label8.Text = "Yayınevi";
            // 
            // txtyayinevi
            // 
            this.txtyayinevi.Location = new System.Drawing.Point(103, 148);
            this.txtyayinevi.Name = "txtyayinevi";
            this.txtyayinevi.PasswordChar = '*';
            this.txtyayinevi.Size = new System.Drawing.Size(155, 22);
            this.txtyayinevi.TabIndex = 35;
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.White;
            this.btnekle.Location = new System.Drawing.Point(223, 582);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 23);
            this.btnekle.TabIndex = 3;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekleemanetverme_Click);
            // 
            // btniptal
            // 
            this.btniptal.BackColor = System.Drawing.Color.White;
            this.btniptal.Location = new System.Drawing.Point(866, 588);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(89, 23);
            this.btniptal.TabIndex = 5;
            this.btniptal.Text = "İPTAL";
            this.btniptal.UseVisualStyleBackColor = false;
            // 
            // btnteslim
            // 
            this.btnteslim.BackColor = System.Drawing.Color.White;
            this.btnteslim.Location = new System.Drawing.Point(761, 588);
            this.btnteslim.Name = "btnteslim";
            this.btnteslim.Size = new System.Drawing.Size(89, 23);
            this.btnteslim.TabIndex = 6;
            this.btnteslim.Text = "TESLİM VERME";
            this.btnteslim.UseVisualStyleBackColor = false;
            this.btnteslim.Click += new System.EventHandler(this.btnteslimvermeemanetver_Click);
            // 
            // lblkayitlikitap
            // 
            this.lblkayitlikitap.AutoSize = true;
            this.lblkayitlikitap.Location = new System.Drawing.Point(437, 588);
            this.lblkayitlikitap.Name = "lblkayitlikitap";
            this.lblkayitlikitap.Size = new System.Drawing.Size(126, 17);
            this.lblkayitlikitap.TabIndex = 8;
            this.lblkayitlikitap.Text = " Kayıtlı Kitap Sayısı";
            // 
            // lblkitapsayisi
            // 
            this.lblkitapsayisi.AutoSize = true;
            this.lblkitapsayisi.Location = new System.Drawing.Point(590, 588);
            this.lblkitapsayisi.Name = "lblkitapsayisi";
            this.lblkitapsayisi.Size = new System.Drawing.Size(85, 17);
            this.lblkitapsayisi.TabIndex = 9;
            this.lblkitapsayisi.Text = " Kitap Sayısı";
            // 
            // kutuphaneOtomasyonuDataSet
            // 
            this.kutuphaneOtomasyonuDataSet.DataSetName = "KutuphaneOtomasyonuDataSet";
            this.kutuphaneOtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kutuphaneOtomasyonuDataSetBindingSource
            // 
            this.kutuphaneOtomasyonuDataSetBindingSource.DataSource = this.kutuphaneOtomasyonuDataSet;
            this.kutuphaneOtomasyonuDataSetBindingSource.Position = 0;
            // 
            // kullanıcı_GirişiDataSet
            // 
            this.kullanıcı_GirişiDataSet.DataSetName = "Kullanıcı_GirişiDataSet";
            this.kullanıcı_GirişiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kullanıcıGirişiDataSetBindingSource
            // 
            this.kullanıcıGirişiDataSetBindingSource.DataSource = this.kullanıcı_GirişiDataSet;
            this.kullanıcıGirişiDataSetBindingSource.Position = 0;
            // 
            // btnlistele
            // 
            this.btnlistele.BackColor = System.Drawing.Color.White;
            this.btnlistele.Location = new System.Drawing.Point(961, 73);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(75, 23);
            this.btnlistele.TabIndex = 10;
            this.btnlistele.Text = "LİSTELE";
            this.btnlistele.UseVisualStyleBackColor = false;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(316, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(639, 547);
            this.dataGridView1.TabIndex = 11;
            // 
            // EmanetKitapVerme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1073, 706);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.lblkitapsayisi);
            this.Controls.Add(this.lblkayitlikitap);
            this.Controls.Add(this.btnteslim);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "EmanetKitapVerme";
            this.Text = "EmanetKitapVerme";
            this.Load += new System.EventHandler(this.EmanetKitapVerme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneOtomasyonuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneOtomasyonuDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanıcı_GirişiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanıcıGirişiDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttelefon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtyas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtadsoyad;
        private System.Windows.Forms.TextBox txtsayfasayisi;
        private System.Windows.Forms.TextBox txtkitapsayisi;
        private System.Windows.Forms.TextBox txtkitapadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtyazari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtyayinevi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker datetimeiadetarih;
        private System.Windows.Forms.DateTimePicker datetimeteslim;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.Button btnteslim;
        private System.Windows.Forms.Label lblkayitlikitap;
        private System.Windows.Forms.Label lblkitapsayisi;
        private System.Windows.Forms.TextBox txtbarkodno;
        private System.Windows.Forms.BindingSource kullanıcıGirişiDataSetBindingSource;
        private Kullanıcı_GirişiDataSet kullanıcı_GirişiDataSet;
        private KutuphaneOtomasyonuDataSet kutuphaneOtomasyonuDataSet;
        private System.Windows.Forms.BindingSource kutuphaneOtomasyonuDataSetBindingSource;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}