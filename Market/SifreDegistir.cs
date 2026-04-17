using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Market.controller;
using Market.enumaration;
using Market.model;

namespace Market
{
    public partial class SifreDegistir : Form
    {
        int code = 111111;
        public SifreDegistir()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_sorgula_Click(object sender, EventArgs e)
        {

            if (txt_dogrulamaKodu.Text == code.ToString())
            {
                grpbox_sifreDegistirmeAlani.Enabled = true;
            }
            else
            {
                MessageBox.Show("Doğrulama kodu hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void SifreDegistir_Load(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            controller.getLoginTable();
            List<LoginTable> loginTableList = controller.getLoginTable();

            foreach (LoginTable lt in loginTableList)
            {
                combobox_guvenlikSorusu.Items.Add(lt.guvenlikSorusu.ToString());
            }
            combobox_guvenlikSorusu.SelectedIndex = 0;

            grpbox_mailAlani.Enabled = false;
            grpbox_sifreDegistirmeAlani.Enabled = false;

        }



        private void btn_sorgula_Click_1(object sender, EventArgs e)
        {

            Controller controller = new Controller();
            LoginStatus result = controller.doAuthentication(txt_kullaniciAdi.Text.Trim().ToLower(), combobox_guvenlikSorusu.SelectedItem.ToString(), txt_guvenlikCevabi.Text.ToLower());

            if (result == LoginStatus.basarili)
            {
                grpbox_mailAlani.Enabled = true;
            }
            else if (result == LoginStatus.basarisiz)
            {
                MessageBox.Show("Girdiğiniz Bilgileri Kontrol Ediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Tüm alanları doldurunuz ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void btn_koduGonder_Click(object sender, EventArgs e)
        {

            Controller controller = new Controller();
            string email = controller.checkEmailAddress(txt_kullaniciAdi.Text);

            if (email == txt_email.Text)
            {
                Random rdn = new Random();
                code = rdn.Next(111111, 999999);

                MailAddress mailAlan = new MailAddress(txt_email.Text, txt_kullaniciAdi.Text);
                MailAddress mailGonderen = new MailAddress("erkankelesoglu899@outlook.com", "Erkan Keleşoğlu");
                MailMessage mesaj = new MailMessage();

                mesaj.To.Add(mailAlan);
                mesaj.From = mailGonderen;
                mesaj.Subject = "Şifre Değiştirmek";
                mesaj.Body = "Şifrenizi değiştirmek için güvenlik kodunuz : " + code;

                SmtpClient smtp = new SmtpClient("smtp.live.com", 587);
                smtp.Credentials = new System.Net.NetworkCredential("erkankelesoglu899@outlook.com", "Erkan5566");
                smtp.EnableSsl = true;
                smtp.Send(mesaj);

                MessageBox.Show("Doğrulama kodu gönderildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Hesabınıza bağlı mail adresini giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn_degistir_Click(object sender, EventArgs e)
        {

            Controller controller = new Controller();

            if (txt_yeniSifre.Text == txt_yeniSifreTekrar.Text)
            {
                LoginStatus result = controller.changePassword(txt_kullaniciAdi.Text, txt_yeniSifre.Text);

                if (result == LoginStatus.basarili)
                {
                    MessageBox.Show("Şifreniz Değiştirilmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (txt_yeniSifre.Text != txt_yeniSifreTekrar.Text)
                {
                    MessageBox.Show("iki şifre aynı değil", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("Gerekli alanları doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
          }
      }

        private void txt_kullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}

