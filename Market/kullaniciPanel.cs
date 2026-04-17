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
    public partial class kullaniciPanel : Form
    {
        controller.Controller controller = new controller.Controller();

        public kullaniciPanel()
        {
            InitializeComponent();
        }

        private void kullaniciPanel_Load(object sender, EventArgs e)
        {
            defaultDegerleriDoldur();
            tumKullanicilariDoldur();
        }

        private void defaultDegerleriDoldur()
        {
            combo_yetki.Items.Add("admin");
            combo_yetki.Items.Add("kasiyer");
            combo_yetki.SelectedIndex = 0;

            //-------------------------------

            combo_bolge.Items.Add("Arnavutköy");
            combo_bolge.Items.Add("Kadıköy");
            combo_bolge.Items.Add("Bakırköy");
            combo_bolge.Items.Add("Beyoğlu");
            combo_bolge.SelectedIndex = 0;
            //-------------------------------

            combo_guvenlikSorusu.Items.Add("En Sevdiğiniz Renk ?");
            combo_guvenlikSorusu.Items.Add("En Sevdiğiniz Araba");
            combo_guvenlikSorusu.SelectedIndex = 0;


        }

        private void tumKullanicilariDoldur()
        {
            List<User> userList = controller.tumKullanicilariGetirme();
            dataGridView1.DataSource = userList;

        }

        private void btn_kayitEkle_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.kullaniciAdi = txt_kullaniciAdi.Text;
            user.sifre = txt_sifre.Text;
            user.yetki = combo_yetki.SelectedItem.ToString();
            user.bolge = combo_bolge.SelectedItem.ToString();
            user.email = txt_email.Text;
            user.guvenlikCevabi = txt_guvenlikCevabi.Text;
            user.guvenlikSorusu = combo_guvenlikSorusu.SelectedItem.ToString();

            LoginStatus sonuc = controller.kullaniciEkle(user);
            if(sonuc == LoginStatus.basarili)
            {
                MessageBox.Show("Kayıt Eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = controller.tumKullanicilariGetirme();
            }
            else
            {
                MessageBox.Show("Gerekli alanları doldurunuz ! ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dataGridView1.CurrentRow.Cells["id"].Value?.ToString();
            txt_kullaniciAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_sifre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            combo_yetki.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_email.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            combo_bolge.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();   
            combo_guvenlikSorusu.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txt_guvenlikCevabi.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            dataGridView1.Columns["status"].Visible = false;
        }

        private void btn_kayitGuncelle_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.id = int.Parse(txt_id.Text);
            user.kullaniciAdi = txt_kullaniciAdi.Text;
            user.sifre = txt_sifre.Text;
            user.yetki = combo_yetki.SelectedItem.ToString();
            user.email = txt_email.Text;
            user.bolge = combo_bolge.SelectedItem.ToString();
            user.guvenlikCevabi = txt_guvenlikCevabi.Text;
            user.guvenlikSorusu = combo_guvenlikSorusu.SelectedItem.ToString();
            LoginStatus sonuc = controller.kullaniciGuncelle(user);

            if (sonuc == LoginStatus.basarili)
            {
                MessageBox.Show("Kayıt Güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = controller.tumKullanicilariGetirme();
            }
            else
            {
                MessageBox.Show("Kayıt Güncellenirken Bir Hata Oluştu ! ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btn_kayitSil_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txt_id.Text))
            {
                LoginStatus sonuc = controller.kullaniciSil(int.Parse(txt_id.Text));

                if (sonuc == LoginStatus.basarili)
                {
                    MessageBox.Show("Kayıt Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = controller.tumKullanicilariGetirme();
                }
                else if (sonuc == LoginStatus.basarisiz)
                {
                    MessageBox.Show("Kayıt Silinirken Hata Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Silmek istenilen kaydın id değeri girilmeli !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
         
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            AdminPanel admin = new AdminPanel();
            admin.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Columns["status"].Visible = false;
        }
    }
}
