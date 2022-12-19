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
    public partial class PersonelDuzenle : Form
    {
        public PersonelDuzenle()
        {
            InitializeComponent();
        }

        private void btnpersonelekle_Click(object sender, EventArgs e)
        {
            PersonelEkle ekle = new PersonelEkle();
            this.Hide();
            ekle.Show();
            this.Dispose();
          
        }

        private void btnpersonelcikar_Click(object sender, EventArgs e)
        {

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            
            Yonetici ynt = new Yonetici();
            this.Hide();
            ynt.Show();
            

        }
    }
}
