using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using Market.model;
using ZXing;

namespace Market
{
    public partial class meyveSebzePanel : Form
    {

        int sayi1;
        int sayi2;
        int islemTip;

        public meyveSebzePanel()
        {
            InitializeComponent();
            txt_islem.Text = "0";

        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_islem.Text = "0";
        }

        private void meyveSebzePanel_Load(object sender, EventArgs e)
        {
            timer1.Start();
            fic = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo camera in fic)
            {
                combo_kameraAc.Items.Add(camera.Name);
            }
            SelectCategory(_acilisKategori);

        }

        private void txt_islem_TextChanged(object sender, EventArgs e)
        {

        }

        FilterInfoCollection fic;
        VideoCaptureDevice vcd;


        private void secilenTus(object sender, EventArgs e)
        {
            if(txt_islem.Text == "0")
            {
                txt_islem.Text = "";
            }
            txt_islem.Text += ((Button)sender).Text;

        }

        private void btn_bolme_Click(object sender, EventArgs e)
        {

        }

        private void btn_bolme_Click_1(object sender, EventArgs e)
        {
            islemTip = 4; // bölmeyi temsil ediyor
            sayi1 = int.Parse(txt_islem.Text);
            txt_islem.Text = "0";

        }

        private void btn_topla_Click(object sender, EventArgs e)
        {
            islemTip = 1; // +'yı temsi ediyor
            sayi1 = int.Parse(txt_islem.Text);
            txt_islem.Text = "0";

        }

        private void btn_esittir_Click(object sender, EventArgs e)
        {
            if (islemTip == 1)
            {
                sayi2 = int.Parse(txt_islem.Text);
                txt_islem.Text = (sayi1 + sayi2).ToString();

            }
            else if (islemTip == 2)
            {
                sayi2 = int.Parse(txt_islem.Text);
                txt_islem.Text = (sayi1 - sayi2).ToString();


            }
            else if(islemTip == 3)
            {
                sayi2 = int.Parse(txt_islem.Text);
                txt_islem.Text = (sayi1 * sayi2).ToString();
            }
            else if(islemTip == 4)
            {
                sayi2 = int.Parse(txt_islem.Text);
                txt_islem.Text = (sayi1 / sayi2).ToString();
            }

        }

        private void btn_cikarma_Click(object sender, EventArgs e)
        {
            islemTip = 2; // -' yi temsil ediyor
            sayi1 = int.Parse(txt_islem.Text);
            txt_islem.Text = "0";
        }

        private void btn_carpma_Click(object sender, EventArgs e)
        {
            islemTip = 3; // *'yı temsil ediyor
            sayi1 = int.Parse(txt_islem.Text);
            txt_islem.Text = "0";
        }

        private void btn_geriGel_Click(object sender, EventArgs e)
        {
            if (txt_islem.Text.Length != 0){

                txt_islem.Text = txt_islem.Text.Substring(0, txt_islem.Text.Length - 1);
            }
            else
            {
                txt_islem.Text = "0";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
           if(pctbox_kamera.Image != null)
            {
                BarcodeReader reader = new BarcodeReader();
                Result result = reader.Decode((Bitmap)pctbox_kamera.Image);
               
                if(result != null)
                {
                    txt_barkod.Text = result.ToString();
                    timer1.Stop();
                }

            }
        }

        private void btn_kameraAc_Click(object sender, EventArgs e)
        {
            vcd = new VideoCaptureDevice(fic[combo_kameraAc.SelectedIndex].MonikerString);
            vcd.NewFrame += Vcd_NewFrame;
            vcd.Start();
            timer1.Start();
               
        }

        private void Vcd_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            pctbox_kamera.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void btn_kameraKapat_Click(object sender, EventArgs e)
        {
            vcd.Stop();
            pctbox_kamera.Image = Image.FromFile("C:\\Users\\Erkan\\Desktop\\Yeni klasör (4)\\4. sınıf");
        }

        private void txt_barkod_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            controller.Controller controller = new controller.Controller();
            Urun tUrun = controller.urunuGetir(txt_barkod.Text);
            lbl_urunIsim.Text = tUrun.urunIsim.ToString();
            txt_islem.Text = tUrun.fiyat.ToString();
            SoundPlayer ses = new SoundPlayer();
            ses.SoundLocation = "barkod.wav";


        }

        private void lbl_urunIsim_Click(object sender, EventArgs e)
        {

        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            KasiyerPanel kasiyerpanel = new KasiyerPanel();
            kasiyerpanel.Show();
            this.Hide();
        }

        private void ShowOnly(GroupBox target)
        {
            grp_etUrunleri.Visible = false;
            grp_sutUrunleri.Visible = false;
            grp_baklagil.Visible = false;
            grp_urunler.Visible = false;

            target.Visible = true;
            target.BringToFront();
        }

        private void btn_et_Click(object sender, EventArgs e)
        {
            ShowOnly(grp_etUrunleri);
        }

        private void btn_sutUrunleri_Click(object sender, EventArgs e)
        {
            ShowOnly(grp_sutUrunleri);
        }

        private void btn_baklagiller_Click(object sender, EventArgs e)
        {
            ShowOnly(grp_baklagil);
        }

        private void btn_sebzeMeyve_Click(object sender, EventArgs e)
        {
            ShowOnly(grp_urunler);
        }

        public enum UrunKategori
        {
            Et,
            Sut,
            Baklagil,
            SebzeMeyve
        }

        private UrunKategori _acilisKategori = UrunKategori.SebzeMeyve;

        public meyveSebzePanel(UrunKategori kategori) : this()
        {
            _acilisKategori = kategori;
        }

        private void SelectCategory(UrunKategori kategori)
        {
            if (kategori == UrunKategori.Et) ShowOnly(grp_etUrunleri);
            else if (kategori == UrunKategori.Sut) ShowOnly(grp_sutUrunleri);
            else if (kategori == UrunKategori.Baklagil) ShowOnly(grp_baklagil);
            else ShowOnly(grp_urunler);
        }










    }
}
