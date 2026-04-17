namespace Market
{
    partial class UrunPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunPanel));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grp_urunPanel = new System.Windows.Forms.GroupBox();
            this.combo_urunIsim = new System.Windows.Forms.ComboBox();
            this.txt_ciro = new System.Windows.Forms.TextBox();
            this.txt_fiyat = new System.Windows.Forms.TextBox();
            this.txt_kilo = new System.Windows.Forms.TextBox();
            this.datetime_guncellenmeTarih = new System.Windows.Forms.DateTimePicker();
            this.datetime_olusturulmaTarih = new System.Windows.Forms.DateTimePicker();
            this.btn_urunSil = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_geriGel = new System.Windows.Forms.Button();
            this.btn_urunEkle = new System.Windows.Forms.Button();
            this.btn_urunGuncelle = new System.Windows.Forms.Button();
            this.txt_barkod = new System.Windows.Forms.TextBox();
            this.txt_qrKod = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grp_urunPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 205);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // grp_urunPanel
            // 
            this.grp_urunPanel.Controls.Add(this.combo_urunIsim);
            this.grp_urunPanel.Controls.Add(this.txt_ciro);
            this.grp_urunPanel.Controls.Add(this.txt_fiyat);
            this.grp_urunPanel.Controls.Add(this.txt_kilo);
            this.grp_urunPanel.Controls.Add(this.datetime_guncellenmeTarih);
            this.grp_urunPanel.Controls.Add(this.datetime_olusturulmaTarih);
            this.grp_urunPanel.Controls.Add(this.btn_urunSil);
            this.grp_urunPanel.Controls.Add(this.btn_geriGel);
            this.grp_urunPanel.Controls.Add(this.btn_urunEkle);
            this.grp_urunPanel.Controls.Add(this.btn_urunGuncelle);
            this.grp_urunPanel.Controls.Add(this.txt_barkod);
            this.grp_urunPanel.Controls.Add(this.txt_qrKod);
            this.grp_urunPanel.Controls.Add(this.txt_id);
            this.grp_urunPanel.Controls.Add(this.label9);
            this.grp_urunPanel.Controls.Add(this.label8);
            this.grp_urunPanel.Controls.Add(this.label7);
            this.grp_urunPanel.Controls.Add(this.label6);
            this.grp_urunPanel.Controls.Add(this.label5);
            this.grp_urunPanel.Controls.Add(this.label3);
            this.grp_urunPanel.Controls.Add(this.label4);
            this.grp_urunPanel.Controls.Add(this.label2);
            this.grp_urunPanel.Controls.Add(this.label1);
            this.grp_urunPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grp_urunPanel.Location = new System.Drawing.Point(12, 223);
            this.grp_urunPanel.Name = "grp_urunPanel";
            this.grp_urunPanel.Size = new System.Drawing.Size(776, 292);
            this.grp_urunPanel.TabIndex = 1;
            this.grp_urunPanel.TabStop = false;
            this.grp_urunPanel.Text = "Ürün Panel";
            // 
            // combo_urunIsim
            // 
            this.combo_urunIsim.FormattingEnabled = true;
            this.combo_urunIsim.Location = new System.Drawing.Point(466, 31);
            this.combo_urunIsim.Name = "combo_urunIsim";
            this.combo_urunIsim.Size = new System.Drawing.Size(169, 24);
            this.combo_urunIsim.TabIndex = 3;
            // 
            // txt_ciro
            // 
            this.txt_ciro.Location = new System.Drawing.Point(466, 139);
            this.txt_ciro.Name = "txt_ciro";
            this.txt_ciro.Size = new System.Drawing.Size(169, 23);
            this.txt_ciro.TabIndex = 6;
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.Location = new System.Drawing.Point(466, 103);
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Size = new System.Drawing.Size(169, 23);
            this.txt_fiyat.TabIndex = 5;
            // 
            // txt_kilo
            // 
            this.txt_kilo.Location = new System.Drawing.Point(466, 62);
            this.txt_kilo.Name = "txt_kilo";
            this.txt_kilo.Size = new System.Drawing.Size(169, 23);
            this.txt_kilo.TabIndex = 4;
            // 
            // datetime_guncellenmeTarih
            // 
            this.datetime_guncellenmeTarih.Location = new System.Drawing.Point(158, 173);
            this.datetime_guncellenmeTarih.Name = "datetime_guncellenmeTarih";
            this.datetime_guncellenmeTarih.Size = new System.Drawing.Size(169, 23);
            this.datetime_guncellenmeTarih.TabIndex = 7;
            // 
            // datetime_olusturulmaTarih
            // 
            this.datetime_olusturulmaTarih.Location = new System.Drawing.Point(158, 136);
            this.datetime_olusturulmaTarih.Name = "datetime_olusturulmaTarih";
            this.datetime_olusturulmaTarih.Size = new System.Drawing.Size(169, 23);
            this.datetime_olusturulmaTarih.TabIndex = 6;
            this.datetime_olusturulmaTarih.ValueChanged += new System.EventHandler(this.datetime_olusturulmaTarih_ValueChanged);
            // 
            // btn_urunSil
            // 
            this.btn_urunSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_urunSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_urunSil.ImageIndex = 0;
            this.btn_urunSil.ImageList = this.ımageList1;
            this.btn_urunSil.Location = new System.Drawing.Point(501, 222);
            this.btn_urunSil.Name = "btn_urunSil";
            this.btn_urunSil.Size = new System.Drawing.Size(134, 32);
            this.btn_urunSil.TabIndex = 10;
            this.btn_urunSil.Text = "Ürün Sil";
            this.btn_urunSil.UseVisualStyleBackColor = true;
            this.btn_urunSil.Click += new System.EventHandler(this.btn_urunSil_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "delete.png");
            this.ımageList1.Images.SetKeyName(1, "add-to-basket.png");
            this.ımageList1.Images.SetKeyName(2, "update.png");
            this.ımageList1.Images.SetKeyName(3, "back.png");
            // 
            // btn_geriGel
            // 
            this.btn_geriGel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_geriGel.ImageIndex = 3;
            this.btn_geriGel.ImageList = this.ımageList1;
            this.btn_geriGel.Location = new System.Drawing.Point(20, 223);
            this.btn_geriGel.Name = "btn_geriGel";
            this.btn_geriGel.Size = new System.Drawing.Size(47, 31);
            this.btn_geriGel.TabIndex = 7;
            this.btn_geriGel.UseVisualStyleBackColor = true;
            this.btn_geriGel.Click += new System.EventHandler(this.btn_geriGel_Click);
            // 
            // btn_urunEkle
            // 
            this.btn_urunEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_urunEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_urunEkle.ImageIndex = 1;
            this.btn_urunEkle.ImageList = this.ımageList1;
            this.btn_urunEkle.Location = new System.Drawing.Point(158, 222);
            this.btn_urunEkle.Name = "btn_urunEkle";
            this.btn_urunEkle.Size = new System.Drawing.Size(134, 32);
            this.btn_urunEkle.TabIndex = 9;
            this.btn_urunEkle.Text = "Ürün Ekle";
            this.btn_urunEkle.UseVisualStyleBackColor = true;
            this.btn_urunEkle.Click += new System.EventHandler(this.btn_urunEkle_Click);
            // 
            // btn_urunGuncelle
            // 
            this.btn_urunGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_urunGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_urunGuncelle.ImageKey = "update.png";
            this.btn_urunGuncelle.ImageList = this.ımageList1;
            this.btn_urunGuncelle.Location = new System.Drawing.Point(327, 222);
            this.btn_urunGuncelle.Name = "btn_urunGuncelle";
            this.btn_urunGuncelle.Size = new System.Drawing.Size(134, 32);
            this.btn_urunGuncelle.TabIndex = 8;
            this.btn_urunGuncelle.Text = "Ürün Güncelle";
            this.btn_urunGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_urunGuncelle.UseVisualStyleBackColor = true;
            this.btn_urunGuncelle.Click += new System.EventHandler(this.btn_urunGuncelle_Click);
            // 
            // txt_barkod
            // 
            this.txt_barkod.Location = new System.Drawing.Point(158, 102);
            this.txt_barkod.Name = "txt_barkod";
            this.txt_barkod.Size = new System.Drawing.Size(169, 23);
            this.txt_barkod.TabIndex = 2;
            // 
            // txt_qrKod
            // 
            this.txt_qrKod.Location = new System.Drawing.Point(158, 65);
            this.txt_qrKod.Name = "txt_qrKod";
            this.txt_qrKod.Size = new System.Drawing.Size(169, 23);
            this.txt_qrKod.TabIndex = 1;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(158, 31);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(169, 23);
            this.txt_id.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(365, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ciro :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(365, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Fiyat :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(365, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Kilo :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ürün isim :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Güncellenme Tarih :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Barkod Kod :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Oluşturulma Tarih :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "QR Kod :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // UrunPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(801, 525);
            this.Controls.Add(this.grp_urunPanel);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UrunPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UrunPanel";
            this.Load += new System.EventHandler(this.UrunPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grp_urunPanel.ResumeLayout(false);
            this.grp_urunPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grp_urunPanel;
        private System.Windows.Forms.TextBox txt_barkod;
        private System.Windows.Forms.TextBox txt_qrKod;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_urunGuncelle;
        private System.Windows.Forms.Button btn_geriGel;
        private System.Windows.Forms.Button btn_urunEkle;
        private System.Windows.Forms.Button btn_urunSil;
        private System.Windows.Forms.DateTimePicker datetime_guncellenmeTarih;
        private System.Windows.Forms.DateTimePicker datetime_olusturulmaTarih;
        private System.Windows.Forms.TextBox txt_ciro;
        private System.Windows.Forms.TextBox txt_fiyat;
        private System.Windows.Forms.TextBox txt_kilo;
        private System.Windows.Forms.ComboBox combo_urunIsim;
        private System.Windows.Forms.ImageList ımageList1;
    }
}