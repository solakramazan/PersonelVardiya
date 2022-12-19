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
    public partial class Patron : Form
    {
        public Patron()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult cky = new DialogResult();
            cky = MessageBox.Show("Çıkış yapmak istiyor musunuz ? ", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cky == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void PatronEkranı_Load(object sender, EventArgs e)
        {

        }

        private void persznbtn_Click(object sender, EventArgs e)
        {
            PersonelEkle perek = new PersonelEkle();
            perek.Show();
        }
    }
}
