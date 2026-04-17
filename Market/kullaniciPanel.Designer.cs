namespace Market
{
    partial class kullaniciPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kullaniciPanel));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpbox_kullanici = new System.Windows.Forms.GroupBox();
            this.btn_geri = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_kayitSil = new System.Windows.Forms.Button();
            this.btn_kayitEkle = new System.Windows.Forms.Button();
            this.btn_kayitGuncelle = new System.Windows.Forms.Button();
            this.combo_bolge = new System.Windows.Forms.ComboBox();
            this.combo_guvenlikSorusu = new System.Windows.Forms.ComboBox();
            this.combo_yetki = new System.Windows.Forms.ComboBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.txt_guvenlikCevabi = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpbox_kullanici.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 179);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // grpbox_kullanici
            // 
            this.grpbox_kullanici.Controls.Add(this.btn_geri);
            this.grpbox_kullanici.Controls.Add(this.txt_id);
            this.grpbox_kullanici.Controls.Add(this.label9);
            this.grpbox_kullanici.Controls.Add(this.btn_kayitSil);
            this.grpbox_kullanici.Controls.Add(this.btn_kayitEkle);
            this.grpbox_kullanici.Controls.Add(this.btn_kayitGuncelle);
            this.grpbox_kullanici.Controls.Add(this.combo_bolge);
            this.grpbox_kullanici.Controls.Add(this.combo_guvenlikSorusu);
            this.grpbox_kullanici.Controls.Add(this.combo_yetki);
            this.grpbox_kullanici.Controls.Add(this.txt_sifre);
            this.grpbox_kullanici.Controls.Add(this.txt_guvenlikCevabi);
            this.grpbox_kullanici.Controls.Add(this.txt_email);
            this.grpbox_kullanici.Controls.Add(this.txt_kullaniciAdi);
            this.grpbox_kullanici.Controls.Add(this.label4);
            this.grpbox_kullanici.Controls.Add(this.label6);
            this.grpbox_kullanici.Controls.Add(this.label3);
            this.grpbox_kullanici.Controls.Add(this.label2);
            this.grpbox_kullanici.Controls.Add(this.label7);
            this.grpbox_kullanici.Controls.Add(this.label5);
            this.grpbox_kullanici.Controls.Add(this.label1);
            this.grpbox_kullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpbox_kullanici.Location = new System.Drawing.Point(12, 197);
            this.grpbox_kullanici.Name = "grpbox_kullanici";
            this.grpbox_kullanici.Size = new System.Drawing.Size(776, 258);
            this.grpbox_kullanici.TabIndex = 1;
            this.grpbox_kullanici.TabStop = false;
            this.grpbox_kullanici.Text = "Kullanıcı Panel";
            // 
            // btn_geri
            // 
            this.btn_geri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_geri.ImageIndex = 0;
            this.btn_geri.ImageList = this.ımageList1;
            this.btn_geri.Location = new System.Drawing.Point(9, 203);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(56, 30);
            this.btn_geri.TabIndex = 12;
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "back.png");
            this.ımageList1.Images.SetKeyName(1, "useradd.png");
            this.ımageList1.Images.SetKeyName(2, "usersil.png");
            this.ımageList1.Images.SetKeyName(3, "userupdate.png");
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(113, 33);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(212, 23);
            this.txt_id.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "ID :";
            // 
            // btn_kayitSil
            // 
            this.btn_kayitSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_kayitSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kayitSil.ImageIndex = 2;
            this.btn_kayitSil.ImageList = this.ımageList1;
            this.btn_kayitSil.Location = new System.Drawing.Point(539, 203);
            this.btn_kayitSil.Name = "btn_kayitSil";
            this.btn_kayitSil.Size = new System.Drawing.Size(157, 30);
            this.btn_kayitSil.TabIndex = 9;
            this.btn_kayitSil.Text = "Kayıt Sil";
            this.btn_kayitSil.UseVisualStyleBackColor = true;
            this.btn_kayitSil.Click += new System.EventHandler(this.btn_kayitSil_Click);
            // 
            // btn_kayitEkle
            // 
            this.btn_kayitEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_kayitEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kayitEkle.ImageIndex = 1;
            this.btn_kayitEkle.ImageList = this.ımageList1;
            this.btn_kayitEkle.Location = new System.Drawing.Point(113, 203);
            this.btn_kayitEkle.Name = "btn_kayitEkle";
            this.btn_kayitEkle.Size = new System.Drawing.Size(157, 30);
            this.btn_kayitEkle.TabIndex = 7;
            this.btn_kayitEkle.Text = "Kayıt Ekle";
            this.btn_kayitEkle.UseVisualStyleBackColor = true;
            this.btn_kayitEkle.Click += new System.EventHandler(this.btn_kayitEkle_Click);
            // 
            // btn_kayitGuncelle
            // 
            this.btn_kayitGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_kayitGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kayitGuncelle.ImageIndex = 3;
            this.btn_kayitGuncelle.ImageList = this.ımageList1;
            this.btn_kayitGuncelle.Location = new System.Drawing.Point(316, 203);
            this.btn_kayitGuncelle.Name = "btn_kayitGuncelle";
            this.btn_kayitGuncelle.Size = new System.Drawing.Size(168, 30);
            this.btn_kayitGuncelle.TabIndex = 8;
            this.btn_kayitGuncelle.Text = "Kayıt Güncelle";
            this.btn_kayitGuncelle.UseVisualStyleBackColor = true;
            this.btn_kayitGuncelle.Click += new System.EventHandler(this.btn_kayitGuncelle_Click);
            // 
            // combo_bolge
            // 
            this.combo_bolge.FormattingEnabled = true;
            this.combo_bolge.Location = new System.Drawing.Point(517, 156);
            this.combo_bolge.Name = "combo_bolge";
            this.combo_bolge.Size = new System.Drawing.Size(219, 24);
            this.combo_bolge.TabIndex = 3;
            // 
            // combo_guvenlikSorusu
            // 
            this.combo_guvenlikSorusu.FormattingEnabled = true;
            this.combo_guvenlikSorusu.Location = new System.Drawing.Point(517, 76);
            this.combo_guvenlikSorusu.Name = "combo_guvenlikSorusu";
            this.combo_guvenlikSorusu.Size = new System.Drawing.Size(219, 24);
            this.combo_guvenlikSorusu.TabIndex = 5;
            // 
            // combo_yetki
            // 
            this.combo_yetki.FormattingEnabled = true;
            this.combo_yetki.Location = new System.Drawing.Point(113, 156);
            this.combo_yetki.Name = "combo_yetki";
            this.combo_yetki.Size = new System.Drawing.Size(212, 24);
            this.combo_yetki.TabIndex = 2;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(113, 112);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(212, 23);
            this.txt_sifre.TabIndex = 1;
            // 
            // txt_guvenlikCevabi
            // 
            this.txt_guvenlikCevabi.Location = new System.Drawing.Point(517, 120);
            this.txt_guvenlikCevabi.Name = "txt_guvenlikCevabi";
            this.txt_guvenlikCevabi.Size = new System.Drawing.Size(219, 23);
            this.txt_guvenlikCevabi.TabIndex = 6;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(517, 32);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(219, 23);
            this.txt_email.TabIndex = 4;
            // 
            // txt_kullaniciAdi
            // 
            this.txt_kullaniciAdi.Location = new System.Drawing.Point(113, 71);
            this.txt_kullaniciAdi.Name = "txt_kullaniciAdi";
            this.txt_kullaniciAdi.Size = new System.Drawing.Size(212, 23);
            this.txt_kullaniciAdi.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bölge";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(394, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Güvenlik Sorusu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Yetki :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Şifre :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(394, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Güvenlik Cevabı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // kullaniciPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.grpbox_kullanici);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "kullaniciPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kullaniciPanel";
            this.Load += new System.EventHandler(this.kullaniciPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpbox_kullanici.ResumeLayout(false);
            this.grpbox_kullanici.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpbox_kullanici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_kayitSil;
        private System.Windows.Forms.Button btn_kayitEkle;
        private System.Windows.Forms.Button btn_kayitGuncelle;
        private System.Windows.Forms.ComboBox combo_bolge;
        private System.Windows.Forms.ComboBox combo_guvenlikSorusu;
        private System.Windows.Forms.ComboBox combo_yetki;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.TextBox txt_guvenlikCevabi;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_kullaniciAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.ImageList ımageList1;
    }
}