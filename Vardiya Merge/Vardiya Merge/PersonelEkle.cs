using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoliteraxLibrary;
using SoliteraxLibrary.SQLSystem;

namespace Vardiya_Merge
{
    public partial class PersonelEkle : Form
    {
        public PersonelEkle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectDatabase db = new ConnectDatabase("Data Source=projemanisa.database.windows.net;Initial Catalog='personel vardiya';User ID=personelECR;Password=kavun_45", SoliteraxConnection.ConnectionType.SQL).Connect();
            DatabaseManager dm = db.GetManager();
            dm.SendData($"insert into personeller(adi, soyadi, dtarih, cinsiyet, telno, sifre) values ('{textBox1.Texts}', '{textBox4.Text}', '{dateTimePicker1.Text}', '{(radioButton1.Checked ? "true" : "false")}', '{textBox2.Text}', '{textBox3.Text}')");
            DataTable dt = dm.GetData("select * from personeller");
            
            MessageBox.Show("İşlem Başarılı----->    "+dt.Rows[dt.Rows.Count - 1][0] + " - " + dt.Rows[dt.Rows.Count - 1][1] + " - " + dt.Rows[dt.Rows.Count - 1][2] + " - " + dt.Rows[dt.Rows.Count - 1][3] + " - " + dt.Rows[dt.Rows.Count - 1][4] + " - " + dt.Rows[dt.Rows.Count - 1][5] + " - " + dt.Rows[dt.Rows.Count - 1][6]);

            //Görüntüleme için
            //gridname.DataSource = dm.GetData("select * from personeller");
            
        
        }

        private void PersonelEkle_Load(object sender, EventArgs e)
        {

        }

        private void anasybtn_Click(object sender, EventArgs e)
        {
            Yonetici frm1 = new Yonetici();
            frm1.Show();
            this.Hide();
        }
    }
}
 