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
    public partial class Yonetici: Form
    {
        public Yonetici()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult cky = new DialogResult();
            cky = MessageBox.Show("Çıkış yapmak istiyor musunuz ? ", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cky == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PersonelDuzenleme_Click(object sender, EventArgs e)
        {
            PersonelDuzenle pdz = new PersonelDuzenle();
           this.Hide();
            pdz.Show();
            



        }

        private void vardduzbtn_Click(object sender, EventArgs e)
        {

        }

        private void cksbtn_Click(object sender, EventArgs e)
        {
            DialogResult cky = new DialogResult();
            cky = MessageBox.Show("Çıkış yapmak istiyor musunuz ? ", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cky == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
