namespace Market
{
    partial class SifreDegistir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifreDegistir));
            this.grpBox_guvenlikAlani = new System.Windows.Forms.GroupBox();
            this.btn_geri = new System.Windows.Forms.Button();
            this.img_icon = new System.Windows.Forms.ImageList(this.components);
            this.combobox_guvenlikSorusu = new System.Windows.Forms.ComboBox();
            this.btn_sorgula = new System.Windows.Forms.Button();
            this.txt_guvenlikCevabi = new System.Windows.Forms.TextBox();
            this.txt_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_onayla = new System.Windows.Forms.Button();
            this.grpbox_mailAlani = new System.Windows.Forms.GroupBox();
            this.btn_koduGonder = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_dogrulamaKodu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.grpbox_sifreDegistirmeAlani = new System.Windows.Forms.GroupBox();
            this.btn_degistir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_yeniSifreTekrar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_yeniSifre = new System.Windows.Forms.TextBox();
            this.grpBox_guvenlikAlani.SuspendLayout();
            this.grpbox_mailAlani.SuspendLayout();
            this.grpbox_sifreDegistirmeAlani.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBox_guvenlikAlani
            // 
            this.grpBox_guvenlikAlani.Controls.Add(this.btn_geri);
            this.grpBox_guvenlikAlani.Controls.Add(this.combobox_guvenlikSorusu);
            this.grpBox_guvenlikAlani.Controls.Add(this.btn_sorgula);
            this.grpBox_guvenlikAlani.Controls.Add(this.txt_guvenlikCevabi);
            this.grpBox_guvenlikAlani.Controls.Add(this.txt_kullaniciAdi);
            this.grpBox_guvenlikAlani.Controls.Add(this.label2);
            this.grpBox_guvenlikAlani.Controls.Add(this.label3);
            this.grpBox_guvenlikAlani.Controls.Add(this.label1);
            this.grpBox_guvenlikAlani.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBox_guvenlikAlani.Location = new System.Drawing.Point(12, 12);
            this.grpBox_guvenlikAlani.Name = "grpBox_guvenlikAlani";
            this.grpBox_guvenlikAlani.Size = new System.Drawing.Size(378, 339);
            this.grpBox_guvenlikAlani.TabIndex = 0;
            this.grpBox_guvenlikAlani.TabStop = false;
            this.grpBox_guvenlikAlani.Text = "Güvenlik Soru Yönetimi";
            // 
            // btn_geri
            // 
            this.btn_geri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_geri.ImageIndex = 4;
            this.btn_geri.ImageList = this.img_icon;
            this.btn_geri.Location = new System.Drawing.Point(6, 289);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(59, 32);
            this.btn_geri.TabIndex = 4;
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // img_icon
            // 
            this.img_icon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_icon.ImageStream")));
            this.img_icon.TransparentColor = System.Drawing.Color.Transparent;
            this.img_icon.Images.SetKeyName(0, "mail.png");
            this.img_icon.Images.SetKeyName(1, "onayla.png");
            this.img_icon.Images.SetKeyName(2, "sifredegistir.png");
            this.img_icon.Images.SetKeyName(3, "sorgula.png");
            this.img_icon.Images.SetKeyName(4, "back.png");
            // 
            // combobox_guvenlikSorusu
            // 
            this.combobox_guvenlikSorusu.FormattingEnabled = true;
            this.combobox_guvenlikSorusu.Location = new System.Drawing.Point(136, 83);
            this.combobox_guvenlikSorusu.Name = "combobox_guvenlikSorusu";
            this.combobox_guvenlikSorusu.Size = new System.Drawing.Size(171, 24);
            this.combobox_guvenlikSorusu.TabIndex = 1;
            // 
            // btn_sorgula
            // 
            this.btn_sorgula.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sorgula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sorgula.ImageIndex = 3;
            this.btn_sorgula.ImageList = this.img_icon;
            this.btn_sorgula.Location = new System.Drawing.Point(169, 163);
            this.btn_sorgula.Name = "btn_sorgula";
            this.btn_sorgula.Size = new System.Drawing.Size(107, 37);
            this.btn_sorgula.TabIndex = 3;
            this.btn_sorgula.Text = "Sorgula";
            this.btn_sorgula.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sorgula.UseVisualStyleBackColor = true;
            this.btn_sorgula.Click += new System.EventHandler(this.btn_sorgula_Click_1);
            // 
            // txt_guvenlikCevabi
            // 
            this.txt_guvenlikCevabi.Location = new System.Drawing.Point(136, 128);
            this.txt_guvenlikCevabi.Name = "txt_guvenlikCevabi";
            this.txt_guvenlikCevabi.Size = new System.Drawing.Size(171, 23);
            this.txt_guvenlikCevabi.TabIndex = 2;
            // 
            // txt_kullaniciAdi
            // 
            this.txt_kullaniciAdi.Location = new System.Drawing.Point(136, 40);
            this.txt_kullaniciAdi.Name = "txt_kullaniciAdi";
            this.txt_kullaniciAdi.Size = new System.Drawing.Size(171, 23);
            this.txt_kullaniciAdi.TabIndex = 0;
            this.txt_kullaniciAdi.TextChanged += new System.EventHandler(this.txt_kullaniciAdi_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Güvenlik Sorusu :";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Güvenlik Cevabı : ";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_onayla
            // 
            this.btn_onayla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_onayla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_onayla.ImageIndex = 1;
            this.btn_onayla.ImageList = this.img_icon;
            this.btn_onayla.Location = new System.Drawing.Point(221, 126);
            this.btn_onayla.Name = "btn_onayla";
            this.btn_onayla.Size = new System.Drawing.Size(91, 28);
            this.btn_onayla.TabIndex = 3;
            this.btn_onayla.Text = "Onayla";
            this.btn_onayla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_onayla.UseVisualStyleBackColor = true;
            this.btn_onayla.Click += new System.EventHandler(this.btn_sorgula_Click);
            // 
            // grpbox_mailAlani
            // 
            this.grpbox_mailAlani.Controls.Add(this.btn_onayla);
            this.grpbox_mailAlani.Controls.Add(this.btn_koduGonder);
            this.grpbox_mailAlani.Controls.Add(this.label5);
            this.grpbox_mailAlani.Controls.Add(this.txt_dogrulamaKodu);
            this.grpbox_mailAlani.Controls.Add(this.label4);
            this.grpbox_mailAlani.Controls.Add(this.txt_email);
            this.grpbox_mailAlani.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpbox_mailAlani.Location = new System.Drawing.Point(396, 13);
            this.grpbox_mailAlani.Name = "grpbox_mailAlani";
            this.grpbox_mailAlani.Size = new System.Drawing.Size(353, 199);
            this.grpbox_mailAlani.TabIndex = 1;
            this.grpbox_mailAlani.TabStop = false;
            this.grpbox_mailAlani.Text = "Mail ile Değiştir";
            // 
            // btn_koduGonder
            // 
            this.btn_koduGonder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_koduGonder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_koduGonder.ImageIndex = 0;
            this.btn_koduGonder.ImageList = this.img_icon;
            this.btn_koduGonder.Location = new System.Drawing.Point(106, 74);
            this.btn_koduGonder.Name = "btn_koduGonder";
            this.btn_koduGonder.Size = new System.Drawing.Size(206, 28);
            this.btn_koduGonder.TabIndex = 1;
            this.btn_koduGonder.Text = "Doğrulama Kodu Gönder";
            this.btn_koduGonder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_koduGonder.UseVisualStyleBackColor = true;
            this.btn_koduGonder.Click += new System.EventHandler(this.btn_koduGonder_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Doğrulama Kodu :";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_dogrulamaKodu
            // 
            this.txt_dogrulamaKodu.Location = new System.Drawing.Point(134, 130);
            this.txt_dogrulamaKodu.Name = "txt_dogrulamaKodu";
            this.txt_dogrulamaKodu.Size = new System.Drawing.Size(81, 23);
            this.txt_dogrulamaKodu.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email :";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(106, 36);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(183, 23);
            this.txt_email.TabIndex = 0;
            // 
            // grpbox_sifreDegistirmeAlani
            // 
            this.grpbox_sifreDegistirmeAlani.Controls.Add(this.btn_degistir);
            this.grpbox_sifreDegistirmeAlani.Controls.Add(this.label7);
            this.grpbox_sifreDegistirmeAlani.Controls.Add(this.txt_yeniSifreTekrar);
            this.grpbox_sifreDegistirmeAlani.Controls.Add(this.label6);
            this.grpbox_sifreDegistirmeAlani.Controls.Add(this.txt_yeniSifre);
            this.grpbox_sifreDegistirmeAlani.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpbox_sifreDegistirmeAlani.Location = new System.Drawing.Point(396, 213);
            this.grpbox_sifreDegistirmeAlani.Name = "grpbox_sifreDegistirmeAlani";
            this.grpbox_sifreDegistirmeAlani.Size = new System.Drawing.Size(353, 138);
            this.grpbox_sifreDegistirmeAlani.TabIndex = 2;
            this.grpbox_sifreDegistirmeAlani.TabStop = false;
            this.grpbox_sifreDegistirmeAlani.Text = "Şifre Değiştir";
            // 
            // btn_degistir
            // 
            this.btn_degistir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_degistir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_degistir.ImageIndex = 2;
            this.btn_degistir.ImageList = this.img_icon;
            this.btn_degistir.Location = new System.Drawing.Point(207, 92);
            this.btn_degistir.Name = "btn_degistir";
            this.btn_degistir.Size = new System.Drawing.Size(96, 28);
            this.btn_degistir.TabIndex = 2;
            this.btn_degistir.Text = "Değiştir";
            this.btn_degistir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_degistir.UseVisualStyleBackColor = true;
            this.btn_degistir.Click += new System.EventHandler(this.btn_degistir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Yeni Şifre Tekrar :";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_yeniSifreTekrar
            // 
            this.txt_yeniSifreTekrar.Location = new System.Drawing.Point(144, 63);
            this.txt_yeniSifreTekrar.Name = "txt_yeniSifreTekrar";
            this.txt_yeniSifreTekrar.Size = new System.Drawing.Size(159, 23);
            this.txt_yeniSifreTekrar.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Yeni Şifre :";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_yeniSifre
            // 
            this.txt_yeniSifre.Location = new System.Drawing.Point(144, 30);
            this.txt_yeniSifre.Name = "txt_yeniSifre";
            this.txt_yeniSifre.Size = new System.Drawing.Size(159, 23);
            this.txt_yeniSifre.TabIndex = 0;
            // 
            // SifreDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(761, 354);
            this.Controls.Add(this.grpbox_sifreDegistirmeAlani);
            this.Controls.Add(this.grpbox_mailAlani);
            this.Controls.Add(this.grpBox_guvenlikAlani);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SifreDegistir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SifreDegistir";
            this.Load += new System.EventHandler(this.SifreDegistir_Load);
            this.grpBox_guvenlikAlani.ResumeLayout(false);
            this.grpBox_guvenlikAlani.PerformLayout();
            this.grpbox_mailAlani.ResumeLayout(false);
            this.grpbox_mailAlani.PerformLayout();
            this.grpbox_sifreDegistirmeAlani.ResumeLayout(false);
            this.grpbox_sifreDegistirmeAlani.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox_guvenlikAlani;
        private System.Windows.Forms.ComboBox combobox_guvenlikSorusu;
        private System.Windows.Forms.TextBox txt_kullaniciAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_onayla;
        private System.Windows.Forms.TextBox txt_guvenlikCevabi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpbox_mailAlani;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Button btn_koduGonder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_dogrulamaKodu;
        private System.Windows.Forms.Button btn_sorgula;
        private System.Windows.Forms.GroupBox grpbox_sifreDegistirmeAlani;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_yeniSifreTekrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_yeniSifre;
        private System.Windows.Forms.Button btn_degistir;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.ImageList img_icon;
    }
}