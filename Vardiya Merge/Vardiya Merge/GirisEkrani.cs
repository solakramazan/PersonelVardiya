using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vardiya_Merge
{
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saat.Text = DateTime.Now.ToLongTimeString();
        }

        private void grs_btn_Click(object sender, EventArgs e)
        {
            if(ad_text.Text.Equals("patron") && sifre_text.Text.Equals("123"))
            {
                Patron p = new Patron();
                p.Show();
                this.Hide();
                GC.Collect();
            }
            else if(ad_text.Text.Equals("yonetici") && sifre_text.Text.Equals("123"))
            {
                Yonetici y = new Yonetici();
                y.Show();
                this.Hide();
                GC.Collect();
            }
            else if (ad_text.Text.Equals("personel") && sifre_text.Text.Equals(""))
            {
                Personel prs = new Personel();
                prs.Show();
                this.Hide();
            }
            else
            {
                yanlısuyarı.Text = "Yanlış Giriş Yaptınız Tekrar Deneyiniz !!";
            }
            if (string.IsNullOrEmpty(sifre_text.Text))
            {
                yanlısuyarı.Text = "parola boş bırakılamaz ";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void saat_Click(object sender, EventArgs e)
        {

        }

        private void ad_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void sifre_text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
