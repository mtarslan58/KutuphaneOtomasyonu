
namespace KutuphaneOtomasyonu
{
    partial class frmKullanıcı
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtkullaniciadigiris = new System.Windows.Forms.TextBox();
            this.txtSifreGiris = new System.Windows.Forms.TextBox();
            this.btngiriş = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbcinsiyet = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtokukitapsayısı = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txttelefon = new System.Windows.Forms.TextBox();
            this.Cinsiyet = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnekle = new System.Windows.Forms.Button();
            this.txtyas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txttc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSifreKayitTekrar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSifreKayit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtkullaniciadikayit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.adsoyadtxt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // txtkullaniciadigiris
            // 
            this.txtkullaniciadigiris.Location = new System.Drawing.Point(41, 134);
            this.txtkullaniciadigiris.Name = "txtkullaniciadigiris";
            this.txtkullaniciadigiris.Size = new System.Drawing.Size(155, 30);
            this.txtkullaniciadigiris.TabIndex = 2;
            // 
            // txtSifreGiris
            // 
            this.txtSifreGiris.Location = new System.Drawing.Point(41, 206);
            this.txtSifreGiris.Name = "txtSifreGiris";
            this.txtSifreGiris.PasswordChar = '*';
            this.txtSifreGiris.Size = new System.Drawing.Size(155, 30);
            this.txtSifreGiris.TabIndex = 3;
            // 
            // btngiriş
            // 
            this.btngiriş.Location = new System.Drawing.Point(41, 258);
            this.btngiriş.Name = "btngiriş";
            this.btngiriş.Size = new System.Drawing.Size(155, 35);
            this.btngiriş.TabIndex = 4;
            this.btngiriş.Text = "Giriş";
            this.btngiriş.UseVisualStyleBackColor = true;
            this.btngiriş.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btngiriş);
            this.groupBox1.Controls.Add(this.txtkullaniciadigiris);
            this.groupBox1.Controls.Add(this.txtSifreGiris);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(54, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 370);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Girişi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbcinsiyet);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtokukitapsayısı);
            this.groupBox2.Controls.Add(this.txtemail);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txttelefon);
            this.groupBox2.Controls.Add(this.Cinsiyet);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnekle);
            this.groupBox2.Controls.Add(this.txtyas);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txttc);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtSifreKayitTekrar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtSifreKayit);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtkullaniciadikayit);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.adsoyadtxt);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(340, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(728, 370);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Üye Kaydı";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cmbcinsiyet
            // 
            this.cmbcinsiyet.FormattingEnabled = true;
            this.cmbcinsiyet.Items.AddRange(new object[] {
            "Bay",
            "Bayan"});
            this.cmbcinsiyet.Location = new System.Drawing.Point(494, 43);
            this.cmbcinsiyet.Name = "cmbcinsiyet";
            this.cmbcinsiyet.Size = new System.Drawing.Size(155, 30);
            this.cmbcinsiyet.TabIndex = 27;
            this.cmbcinsiyet.Text = " ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(312, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 24);
            this.label9.TabIndex = 25;
            this.label9.Text = "Okunan Kitap Sayısı";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(426, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 24);
            this.label11.TabIndex = 23;
            this.label11.Text = "E mail";
            // 
            // txtokukitapsayısı
            // 
            this.txtokukitapsayısı.Location = new System.Drawing.Point(494, 166);
            this.txtokukitapsayısı.Name = "txtokukitapsayısı";
            this.txtokukitapsayısı.PasswordChar = '*';
            this.txtokukitapsayısı.Size = new System.Drawing.Size(155, 28);
            this.txtokukitapsayısı.TabIndex = 26;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(494, 126);
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '*';
            this.txtemail.Size = new System.Drawing.Size(155, 28);
            this.txtemail.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(414, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 24);
            this.label10.TabIndex = 21;
            this.label10.Text = "Telefon";
            // 
            // txttelefon
            // 
            this.txttelefon.Location = new System.Drawing.Point(494, 80);
            this.txttelefon.Name = "txttelefon";
            this.txttelefon.PasswordChar = '*';
            this.txttelefon.Size = new System.Drawing.Size(155, 28);
            this.txttelefon.TabIndex = 22;
            // 
            // Cinsiyet
            // 
            this.Cinsiyet.AutoSize = true;
            this.Cinsiyet.Location = new System.Drawing.Point(413, 41);
            this.Cinsiyet.Name = "Cinsiyet";
            this.Cinsiyet.Size = new System.Drawing.Size(75, 24);
            this.Cinsiyet.TabIndex = 19;
            this.Cinsiyet.Text = "Cinsiyet";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(77, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "Yaş";
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(494, 232);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(155, 52);
            this.btnekle.TabIndex = 13;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // txtyas
            // 
            this.txtyas.Location = new System.Drawing.Point(136, 232);
            this.txtyas.Name = "txtyas";
            this.txtyas.PasswordChar = '*';
            this.txtyas.Size = new System.Drawing.Size(155, 28);
            this.txtyas.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "T.C";
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(136, 36);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(155, 28);
            this.txttc.TabIndex = 12;
            this.txttc.Text = " ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Şifre Tekrar";
            // 
            // txtSifreKayitTekrar
            // 
            this.txtSifreKayitTekrar.Location = new System.Drawing.Point(136, 192);
            this.txtSifreKayitTekrar.Name = "txtSifreKayitTekrar";
            this.txtSifreKayitTekrar.PasswordChar = '*';
            this.txtSifreKayitTekrar.Size = new System.Drawing.Size(155, 28);
            this.txtSifreKayitTekrar.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Şifre";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtSifreKayit
            // 
            this.txtSifreKayit.Location = new System.Drawing.Point(136, 152);
            this.txtSifreKayit.Name = "txtSifreKayit";
            this.txtSifreKayit.PasswordChar = '*';
            this.txtSifreKayit.Size = new System.Drawing.Size(155, 28);
            this.txtSifreKayit.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(5, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kullanıcı Adı";
            // 
            // txtkullaniciadikayit
            // 
            this.txtkullaniciadikayit.Location = new System.Drawing.Point(136, 112);
            this.txtkullaniciadikayit.Name = "txtkullaniciadikayit";
            this.txtkullaniciadikayit.Size = new System.Drawing.Size(155, 28);
            this.txtkullaniciadikayit.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(26, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ad Soyad";
            // 
            // adsoyadtxt
            // 
            this.adsoyadtxt.Location = new System.Drawing.Point(136, 76);
            this.adsoyadtxt.Name = "adsoyadtxt";
            this.adsoyadtxt.Size = new System.Drawing.Size(155, 28);
            this.adsoyadtxt.TabIndex = 13;
            // 
            // frmKullanıcı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1125, 437);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmKullanıcı";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmKullanıcı_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtkullaniciadigiris;
        private System.Windows.Forms.TextBox txtSifreGiris;
        private System.Windows.Forms.Button btngiriş;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSifreKayitTekrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSifreKayit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtkullaniciadikayit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adsoyadtxt;
        private System.Windows.Forms.Label Cinsiyet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtyas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txttelefon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtokukitapsayısı;
        private System.Windows.Forms.ComboBox cmbcinsiyet;
    }
}

