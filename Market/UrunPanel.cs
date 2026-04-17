using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Market.enumaration;
using Market.model;

namespace Market
{
    public partial class UrunPanel : Form
    {
        controller.Controller controller = new controller.Controller();
        public UrunPanel()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void UrunPanel_Load(object sender, EventArgs e)
        {
            tumUrunleriGetir();
            comboUrunleriYenile();
            tumUrunleriGetir();

        }

        public void tumUrunleriGetir()
        {
            dataGridView1.DataSource = controller.tumUrunleriGetir();
        }

        private void datetime_olusturulmaTarih_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_geriGel_Click(object sender, EventArgs e)
        {
            AdminPanel admin = new AdminPanel();
            admin.Show();
            this.Hide();

        }

        private void btn_urunEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(combo_urunIsim.Text))
            {
                MessageBox.Show("Ürün ismi seçin veya yazın.");
                return; 
            }

            Urun urun = new Urun();
            urun.id = txt_id.Text;
            urun.qrkod = txt_qrKod.Text;
            urun.barkodKod = txt_barkod.Text;
            urun.olusturulma_Tarih = datetime_olusturulmaTarih.Value;
            urun.guncellenme_Tarih = datetime_guncellenmeTarih.Value;
            urun.urunIsim = combo_urunIsim.Text.Trim();
            urun.kilo = int.Parse(txt_kilo.Text);
            urun.fiyat = int.Parse(txt_fiyat.Text);
            urun.ciro = int.Parse(txt_ciro.Text);

            LoginStatus sonuc = controller.urunEkle(urun);

            if(sonuc == LoginStatus.basarili)
            {
                MessageBox.Show("Ürün Eklendi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = controller.tumUrunleriGetir();
                comboUrunleriYenile();
            }
            else if (sonuc == LoginStatus.basarisiz)
            {
                MessageBox.Show("Ürün Eklenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Gerekli alanları doldurun", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_qrKod.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_barkod.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            datetime_olusturulmaTarih.Value =Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            datetime_guncellenmeTarih.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            combo_urunIsim.SelectedItem = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_kilo.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString(); ;
            txt_fiyat.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString(); ;
            txt_ciro.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString(); ;
        }

        private void btn_urunGuncelle_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun();
            urun.id = txt_id.Text;
            urun.qrkod = txt_qrKod.Text;
            urun.barkodKod = txt_barkod.Text;
            urun.olusturulma_Tarih = datetime_olusturulmaTarih.Value;
            urun.guncellenme_Tarih = datetime_guncellenmeTarih.Value;
            urun.urunIsim = combo_urunIsim.SelectedItem?.ToString();
            urun.kilo = int.Parse(txt_kilo.Text);
            urun.fiyat = int.Parse(txt_fiyat.Text);
            urun.ciro = int.Parse(txt_ciro.Text);
            LoginStatus sonuc = controller.urunGuncelle(urun);

            if (sonuc == LoginStatus.basarili)
            {
                MessageBox.Show("Ürün Güncellendi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = controller.tumUrunleriGetir();
            }
            else if (sonuc == LoginStatus.basarisiz)
            {
                MessageBox.Show("Ürün Güncellenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Gerekli alanları doldurun", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn_urunSil_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_id.Text))
            {
                LoginStatus sonuc = controller.urunSil(txt_id.Text);
                if(sonuc == LoginStatus.basarili)
                {
                    MessageBox.Show("Kayıt Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = controller.tumUrunleriGetir();
                }
                else
                {
                    MessageBox.Show("Silmek istediğiniz ürünün id'sini giriniz!", "Eksik Parametre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Silmek istediğiniz ürünün id'sini giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comboUrunleriYenile()
        {
            combo_urunIsim.Items.Clear();
            var isimler = controller.tumUrunIsimleriGetir(); 

            foreach (var isim in isimler)
                combo_urunIsim.Items.Add(isim);
        }










    }
}
