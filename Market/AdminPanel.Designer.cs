namespace Market
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.lbl_dakika = new System.Windows.Forms.Label();
            this.lbl_saniye = new System.Windows.Forms.Label();
            this.lbl_saat = new System.Windows.Forms.Label();
            this.btn_kullanici = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_urun = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl_dakika
            // 
            this.lbl_dakika.AutoSize = true;
            this.lbl_dakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_dakika.Location = new System.Drawing.Point(261, 9);
            this.lbl_dakika.Name = "lbl_dakika";
            this.lbl_dakika.Size = new System.Drawing.Size(24, 17);
            this.lbl_dakika.TabIndex = 1;
            this.lbl_dakika.Text = "00";
            // 
            // lbl_saniye
            // 
            this.lbl_saniye.AutoSize = true;
            this.lbl_saniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_saniye.Location = new System.Drawing.Point(291, 9);
            this.lbl_saniye.Name = "lbl_saniye";
            this.lbl_saniye.Size = new System.Drawing.Size(24, 17);
            this.lbl_saniye.TabIndex = 2;
            this.lbl_saniye.Text = "00";
            // 
            // lbl_saat
            // 
            this.lbl_saat.AutoSize = true;
            this.lbl_saat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_saat.Location = new System.Drawing.Point(231, 9);
            this.lbl_saat.Name = "lbl_saat";
            this.lbl_saat.Size = new System.Drawing.Size(24, 17);
            this.lbl_saat.TabIndex = 3;
            this.lbl_saat.Text = "00";
            this.lbl_saat.Click += new System.EventHandler(this.lbl_saat_Click);
            // 
            // btn_kullanici
            // 
            this.btn_kullanici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kullanici.ImageIndex = 3;
            this.btn_kullanici.ImageList = this.imageList1;
            this.btn_kullanici.Location = new System.Drawing.Point(32, 63);
            this.btn_kullanici.Name = "btn_kullanici";
            this.btn_kullanici.Size = new System.Drawing.Size(122, 100);
            this.btn_kullanici.TabIndex = 4;
            this.btn_kullanici.UseVisualStyleBackColor = true;
            this.btn_kullanici.Click += new System.EventHandler(this.btn_kullanici_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "admin.png");
            this.imageList1.Images.SetKeyName(1, "depo.png");
            this.imageList1.Images.SetKeyName(2, "cancel2.png");
            this.imageList1.Images.SetKeyName(3, "admin.png");
            this.imageList1.Images.SetKeyName(4, "urunduzenle.png");
            // 
            // btn_urun
            // 
            this.btn_urun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_urun.ImageIndex = 4;
            this.btn_urun.ImageList = this.imageList1;
            this.btn_urun.Location = new System.Drawing.Point(193, 63);
            this.btn_urun.Name = "btn_urun";
            this.btn_urun.Size = new System.Drawing.Size(122, 100);
            this.btn_urun.TabIndex = 5;
            this.btn_urun.Text = " ";
            this.btn_urun.UseVisualStyleBackColor = true;
            this.btn_urun.Click += new System.EventHandler(this.btn_urun_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cikis.ImageIndex = 2;
            this.btn_cikis.ImageList = this.imageList1;
            this.btn_cikis.Location = new System.Drawing.Point(111, 187);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(119, 109);
            this.btn_cikis.TabIndex = 6;
            this.btn_cikis.Text = " ";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(340, 314);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_urun);
            this.Controls.Add(this.btn_kullanici);
            this.Controls.Add(this.lbl_saat);
            this.Controls.Add(this.lbl_saniye);
            this.Controls.Add(this.lbl_dakika);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_dakika;
        private System.Windows.Forms.Label lbl_saniye;
        private System.Windows.Forms.Label lbl_saat;
        private System.Windows.Forms.Button btn_kullanici;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_urun;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Timer timer1;
    }
}