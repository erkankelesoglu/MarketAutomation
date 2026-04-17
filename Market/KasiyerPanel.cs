using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Market.meyveSebzePanel;

namespace Market
{
    public partial class KasiyerPanel : Form
    {
        public KasiyerPanel()
        {
            InitializeComponent();
        }

        private void btn_cikisYap_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }

        private void KasiyerPanel_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_saat.Text = DateTime.Now.Hour.ToString()+"  :";
            lbl_dakika.Text = DateTime.Now.Minute.ToString()+" :";
            lbl_saniye.Text = DateTime.Now.Second.ToString();

        }

        private void btn_meyveSebze_Click(object sender, EventArgs e)
        {
            meyveSebzePanel frm = new meyveSebzePanel(UrunKategori.SebzeMeyve);
            frm.Show();
            this.Hide();
        }

        private void btn_sut_Click(object sender, EventArgs e)
        {
            meyveSebzePanel frm = new meyveSebzePanel(UrunKategori.Sut);
            frm.Show();
            this.Hide();
        }

        private void btn_et_Click(object sender, EventArgs e)
        {
            meyveSebzePanel frm = new meyveSebzePanel(UrunKategori.Et);
            frm.Show();
            this.Hide(); // KasiyerPanel gizlensin
        }

        private void btn_baklagil_Click(object sender, EventArgs e)
        {
            meyveSebzePanel frm = new meyveSebzePanel(UrunKategori.Baklagil);
            frm.Show();
            this.Hide();
        }
    }
}
