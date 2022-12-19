namespace Vardiya_Merge
{
    partial class GirisEkrani
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisEkrani));
            this.panel1 = new System.Windows.Forms.Panel();
            this.saat = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.baslık = new System.Windows.Forms.Label();
            this.ad_lbl = new System.Windows.Forms.Label();
            this.sifre_lbl = new System.Windows.Forms.Label();
            this.ad_text = new System.Windows.Forms.TextBox();
            this.sifre_text = new System.Windows.Forms.TextBox();
            this.grs_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.yanlısuyarı = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.saat);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.baslık);
            this.panel1.Location = new System.Drawing.Point(-3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 142);
            this.panel1.TabIndex = 0;
            // 
            // saat
            // 
            this.saat.AutoSize = true;
            this.saat.BackColor = System.Drawing.Color.Black;
            this.saat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saat.ForeColor = System.Drawing.Color.White;
            this.saat.Location = new System.Drawing.Point(653, 114);
            this.saat.Name = "saat";
            this.saat.Size = new System.Drawing.Size(129, 24);
            this.saat.TabIndex = 2;
            this.saat.Text = "Hoş Geldiniz";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // baslık
            // 
            this.baslık.AutoSize = true;
            this.baslık.BackColor = System.Drawing.Color.Black;
            this.baslık.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslık.ForeColor = System.Drawing.Color.White;
            this.baslık.Location = new System.Drawing.Point(229, 42);
            this.baslık.Name = "baslık";
            this.baslık.Size = new System.Drawing.Size(392, 44);
            this.baslık.TabIndex = 0;
            this.baslık.Text = "Kullanıcı Giriş Ekranı";
            // 
            // ad_lbl
            // 
            this.ad_lbl.AutoSize = true;
            this.ad_lbl.BackColor = System.Drawing.Color.Transparent;
            this.ad_lbl.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ad_lbl.Location = new System.Drawing.Point(139, 242);
            this.ad_lbl.Name = "ad_lbl";
            this.ad_lbl.Size = new System.Drawing.Size(210, 33);
            this.ad_lbl.TabIndex = 1;
            this.ad_lbl.Text = "Kullanıcı Adı  :";
            // 
            // sifre_lbl
            // 
            this.sifre_lbl.AutoSize = true;
            this.sifre_lbl.BackColor = System.Drawing.Color.Transparent;
            this.sifre_lbl.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre_lbl.Location = new System.Drawing.Point(139, 306);
            this.sifre_lbl.Name = "sifre_lbl";
            this.sifre_lbl.Size = new System.Drawing.Size(104, 33);
            this.sifre_lbl.TabIndex = 2;
            this.sifre_lbl.Text = "Şifre  :";
            // 
            // ad_text
            // 
            this.ad_text.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ad_text.Location = new System.Drawing.Point(355, 238);
            this.ad_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ad_text.Name = "ad_text";
            this.ad_text.Size = new System.Drawing.Size(264, 39);
            this.ad_text.TabIndex = 3;
            // 
            // sifre_text
            // 
            this.sifre_text.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre_text.Location = new System.Drawing.Point(355, 300);
            this.sifre_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sifre_text.Name = "sifre_text";
            this.sifre_text.Size = new System.Drawing.Size(264, 39);
            this.sifre_text.TabIndex = 4;
            // 
            // grs_btn
            // 
            this.grs_btn.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grs_btn.Location = new System.Drawing.Point(145, 369);
            this.grs_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grs_btn.Name = "grs_btn";
            this.grs_btn.Size = new System.Drawing.Size(475, 52);
            this.grs_btn.TabIndex = 5;
            this.grs_btn.Text = "Giriş";
            this.grs_btn.UseVisualStyleBackColor = true;
            this.grs_btn.Click += new System.EventHandler(this.grs_btn_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // yanlısuyarı
            // 
            this.yanlısuyarı.AutoSize = true;
            this.yanlısuyarı.BackColor = System.Drawing.Color.Transparent;
            this.yanlısuyarı.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yanlısuyarı.ForeColor = System.Drawing.Color.Red;
            this.yanlısuyarı.Location = new System.Drawing.Point(192, 447);
            this.yanlısuyarı.Name = "yanlısuyarı";
            this.yanlısuyarı.Size = new System.Drawing.Size(0, 24);
            this.yanlısuyarı.TabIndex = 6;
            // 
            // GirisEkrani
            // 
            this.AcceptButton = this.grs_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(781, 553);
            this.Controls.Add(this.yanlısuyarı);
            this.Controls.Add(this.grs_btn);
            this.Controls.Add(this.sifre_text);
            this.Controls.Add(this.ad_text);
            this.Controls.Add(this.sifre_lbl);
            this.Controls.Add(this.ad_lbl);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GirisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Giriş Ekranı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label baslık;
        private System.Windows.Forms.Label ad_lbl;
        private System.Windows.Forms.Label sifre_lbl;
        private System.Windows.Forms.TextBox ad_text;
        private System.Windows.Forms.TextBox sifre_text;
        private System.Windows.Forms.Button grs_btn;
        private System.Windows.Forms.Label saat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label yanlısuyarı;
    }
}


