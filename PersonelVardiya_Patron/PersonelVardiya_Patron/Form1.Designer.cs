
namespace PersonelVardiya_Patron
{
    partial class PatronEkranı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatronEkranı));
            this.YoneticiDuzenle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PersonelDuzenle = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PersonelDuzen = new System.Windows.Forms.Button();
            this.Cıkıs = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.HosGeldiniz = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // YoneticiDuzenle
            // 
            this.YoneticiDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YoneticiDuzenle.Location = new System.Drawing.Point(23, 13);
            this.YoneticiDuzenle.Name = "YoneticiDuzenle";
            this.YoneticiDuzenle.Size = new System.Drawing.Size(154, 35);
            this.YoneticiDuzenle.TabIndex = 0;
            this.YoneticiDuzenle.Text = "Yönetici Düzenle";
            this.YoneticiDuzenle.UseVisualStyleBackColor = true;
            this.YoneticiDuzenle.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.YoneticiDuzenle);
            this.panel1.Location = new System.Drawing.Point(26, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 60);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.PersonelDuzenle);
            this.panel2.Location = new System.Drawing.Point(530, 171);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 60);
            this.panel2.TabIndex = 1;
            // 
            // PersonelDuzenle
            // 
            this.PersonelDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersonelDuzenle.Location = new System.Drawing.Point(21, 13);
            this.PersonelDuzenle.Name = "PersonelDuzenle";
            this.PersonelDuzenle.Size = new System.Drawing.Size(153, 35);
            this.PersonelDuzenle.TabIndex = 0;
            this.PersonelDuzenle.Text = "Vardiya Düzenle";
            this.PersonelDuzenle.UseVisualStyleBackColor = true;
            this.PersonelDuzenle.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.PersonelDuzen);
            this.panel3.Location = new System.Drawing.Point(277, 171);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(195, 60);
            this.panel3.TabIndex = 1;
            // 
            // PersonelDuzen
            // 
            this.PersonelDuzen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersonelDuzen.Location = new System.Drawing.Point(23, 13);
            this.PersonelDuzen.Name = "PersonelDuzen";
            this.PersonelDuzen.Size = new System.Drawing.Size(153, 35);
            this.PersonelDuzen.TabIndex = 0;
            this.PersonelDuzen.Text = "Personel Düzenle";
            this.PersonelDuzen.UseVisualStyleBackColor = true;
            this.PersonelDuzen.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cıkıs
            // 
            this.Cıkıs.BackColor = System.Drawing.Color.Red;
            this.Cıkıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cıkıs.Location = new System.Drawing.Point(582, 363);
            this.Cıkıs.Name = "Cıkıs";
            this.Cıkıs.Size = new System.Drawing.Size(128, 54);
            this.Cıkıs.TabIndex = 2;
            this.Cıkıs.Text = "Çıkış";
            this.Cıkıs.UseVisualStyleBackColor = false;
            this.Cıkıs.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.HosGeldiniz);
            this.panel4.Location = new System.Drawing.Point(0, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 118);
            this.panel4.TabIndex = 3;
            // 
            // HosGeldiniz
            // 
            this.HosGeldiniz.AutoSize = true;
            this.HosGeldiniz.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HosGeldiniz.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HosGeldiniz.Location = new System.Drawing.Point(337, 31);
            this.HosGeldiniz.Name = "HosGeldiniz";
            this.HosGeldiniz.Size = new System.Drawing.Size(283, 52);
            this.HosGeldiniz.TabIndex = 0;
            this.HosGeldiniz.Text = "Hoş Geldiniz";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // PatronEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Cıkıs);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "PatronEkranı";
            this.Text = "Patron Ekranı";
            this.Load += new System.EventHandler(this.PatronEkranı_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button YoneticiDuzenle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button PersonelDuzenle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button PersonelDuzen;
        private System.Windows.Forms.Button Cıkıs;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label HosGeldiniz;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

