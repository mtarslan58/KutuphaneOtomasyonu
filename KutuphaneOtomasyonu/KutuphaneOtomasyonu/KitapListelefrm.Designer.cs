
namespace KutuphaneOtomasyonu
{
    partial class KitapListelefrm
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
            this.txtkitapadıG = new System.Windows.Forms.TextBox();
            this.cmbboxtürüG = new System.Windows.Forms.ComboBox();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtacıklamaG = new System.Windows.Forms.TextBox();
            this.txtrafnoG = new System.Windows.Forms.MaskedTextBox();
            this.txtstoksayısıG = new System.Windows.Forms.TextBox();
            this.txtsayfasayısıG = new System.Windows.Forms.TextBox();
            this.txtyayıneviG = new System.Windows.Forms.MaskedTextBox();
            this.txtyazarıG = new System.Windows.Forms.TextBox();
            this.txtbarkodnoG = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnkitaplisteleme = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtkitapadıG
            // 
            this.txtkitapadıG.BackColor = System.Drawing.Color.White;
            this.txtkitapadıG.Location = new System.Drawing.Point(143, 121);
            this.txtkitapadıG.Margin = new System.Windows.Forms.Padding(4);
            this.txtkitapadıG.Name = "txtkitapadıG";
            this.txtkitapadıG.Size = new System.Drawing.Size(193, 22);
            this.txtkitapadıG.TabIndex = 40;
            // 
            // cmbboxtürüG
            // 
            this.cmbboxtürüG.BackColor = System.Drawing.Color.White;
            this.cmbboxtürüG.FormattingEnabled = true;
            this.cmbboxtürüG.Items.AddRange(new object[] {
            "Hikaye",
            "Roman",
            "Tarih",
            "Dünya Klasikleri",
            "Şiir",
            "Din"});
            this.cmbboxtürüG.Location = new System.Drawing.Point(143, 256);
            this.cmbboxtürüG.Margin = new System.Windows.Forms.Padding(4);
            this.cmbboxtürüG.Name = "cmbboxtürüG";
            this.cmbboxtürüG.Size = new System.Drawing.Size(193, 24);
            this.cmbboxtürüG.TabIndex = 39;
            // 
            // btngüncelle
            // 
            this.btngüncelle.BackColor = System.Drawing.Color.White;
            this.btngüncelle.Location = new System.Drawing.Point(143, 449);
            this.btngüncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(193, 42);
            this.btngüncelle.TabIndex = 38;
            this.btngüncelle.Text = "GÜNCELLE";
            this.btngüncelle.UseVisualStyleBackColor = false;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(56, 369);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 37;
            this.label10.Text = "Açıklama";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 335);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Raf No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 299);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "Stok Sayısı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 265);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Türü";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 229);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Sayfa Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Yayınevi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Yazarı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Kitap Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "K. Barkod No";
            // 
            // txtacıklamaG
            // 
            this.txtacıklamaG.BackColor = System.Drawing.Color.White;
            this.txtacıklamaG.Location = new System.Drawing.Point(143, 363);
            this.txtacıklamaG.Margin = new System.Windows.Forms.Padding(4);
            this.txtacıklamaG.Multiline = true;
            this.txtacıklamaG.Name = "txtacıklamaG";
            this.txtacıklamaG.Size = new System.Drawing.Size(193, 78);
            this.txtacıklamaG.TabIndex = 28;
            // 
            // txtrafnoG
            // 
            this.txtrafnoG.BackColor = System.Drawing.Color.White;
            this.txtrafnoG.Location = new System.Drawing.Point(143, 328);
            this.txtrafnoG.Margin = new System.Windows.Forms.Padding(4);
            this.txtrafnoG.Name = "txtrafnoG";
            this.txtrafnoG.Size = new System.Drawing.Size(193, 22);
            this.txtrafnoG.TabIndex = 27;
            // 
            // txtstoksayısıG
            // 
            this.txtstoksayısıG.BackColor = System.Drawing.Color.White;
            this.txtstoksayısıG.Location = new System.Drawing.Point(143, 293);
            this.txtstoksayısıG.Margin = new System.Windows.Forms.Padding(4);
            this.txtstoksayısıG.Name = "txtstoksayısıG";
            this.txtstoksayısıG.Size = new System.Drawing.Size(193, 22);
            this.txtstoksayısıG.TabIndex = 26;
            // 
            // txtsayfasayısıG
            // 
            this.txtsayfasayısıG.BackColor = System.Drawing.Color.White;
            this.txtsayfasayısıG.Location = new System.Drawing.Point(143, 223);
            this.txtsayfasayısıG.Margin = new System.Windows.Forms.Padding(4);
            this.txtsayfasayısıG.Name = "txtsayfasayısıG";
            this.txtsayfasayısıG.Size = new System.Drawing.Size(193, 22);
            this.txtsayfasayısıG.TabIndex = 25;
            // 
            // txtyayıneviG
            // 
            this.txtyayıneviG.BackColor = System.Drawing.Color.White;
            this.txtyayıneviG.Location = new System.Drawing.Point(143, 188);
            this.txtyayıneviG.Margin = new System.Windows.Forms.Padding(4);
            this.txtyayıneviG.Name = "txtyayıneviG";
            this.txtyayıneviG.Size = new System.Drawing.Size(193, 22);
            this.txtyayıneviG.TabIndex = 24;
            // 
            // txtyazarıG
            // 
            this.txtyazarıG.BackColor = System.Drawing.Color.White;
            this.txtyazarıG.Location = new System.Drawing.Point(143, 153);
            this.txtyazarıG.Margin = new System.Windows.Forms.Padding(4);
            this.txtyazarıG.Name = "txtyazarıG";
            this.txtyazarıG.Size = new System.Drawing.Size(193, 22);
            this.txtyazarıG.TabIndex = 23;
            // 
            // txtbarkodnoG
            // 
            this.txtbarkodnoG.BackColor = System.Drawing.Color.White;
            this.txtbarkodnoG.Location = new System.Drawing.Point(143, 83);
            this.txtbarkodnoG.Margin = new System.Windows.Forms.Padding(4);
            this.txtbarkodnoG.Name = "txtbarkodnoG";
            this.txtbarkodnoG.Size = new System.Drawing.Size(193, 22);
            this.txtbarkodnoG.TabIndex = 22;
            this.txtbarkodnoG.TextChanged += new System.EventHandler(this.txtbarkodnoG_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(367, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(882, 408);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.White;
            this.btnsil.Location = new System.Drawing.Point(1185, 508);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 23);
            this.btnsil.TabIndex = 42;
            this.btnsil.Text = " SİL";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click_1);
            // 
            // btnkitaplisteleme
            // 
            this.btnkitaplisteleme.BackColor = System.Drawing.Color.White;
            this.btnkitaplisteleme.Location = new System.Drawing.Point(378, 508);
            this.btnkitaplisteleme.Name = "btnkitaplisteleme";
            this.btnkitaplisteleme.Size = new System.Drawing.Size(165, 37);
            this.btnkitaplisteleme.TabIndex = 43;
            this.btnkitaplisteleme.Text = "YENİLE";
            this.btnkitaplisteleme.UseVisualStyleBackColor = false;
            this.btnkitaplisteleme.Click += new System.EventHandler(this.btnkitaplisteleme_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(482, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 44;
            this.label9.Text = "label9";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(572, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 45;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KitapListelefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1308, 557);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnkitaplisteleme);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtkitapadıG);
            this.Controls.Add(this.cmbboxtürüG);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtacıklamaG);
            this.Controls.Add(this.txtrafnoG);
            this.Controls.Add(this.txtstoksayısıG);
            this.Controls.Add(this.txtsayfasayısıG);
            this.Controls.Add(this.txtyayıneviG);
            this.Controls.Add(this.txtyazarıG);
            this.Controls.Add(this.txtbarkodnoG);
            this.Name = "KitapListelefrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.KitapListelefrm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtkitapadıG;
        private System.Windows.Forms.ComboBox cmbboxtürüG;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtacıklamaG;
        private System.Windows.Forms.MaskedTextBox txtrafnoG;
        private System.Windows.Forms.TextBox txtstoksayısıG;
        private System.Windows.Forms.TextBox txtsayfasayısıG;
        private System.Windows.Forms.MaskedTextBox txtyayıneviG;
        private System.Windows.Forms.TextBox txtyazarıG;
        private System.Windows.Forms.TextBox txtbarkodnoG;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnkitaplisteleme;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}