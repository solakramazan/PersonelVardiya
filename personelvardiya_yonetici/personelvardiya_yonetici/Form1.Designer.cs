
namespace personelvardiya_yonetici
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.VardiyaDuzenleme = new System.Windows.Forms.Button();
            this.PersonelDuzenleme = new System.Windows.Forms.Button();
            this.ÇıkışButonu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // VardiyaDuzenleme
            // 
            this.VardiyaDuzenleme.BackColor = System.Drawing.Color.Gainsboro;
            this.VardiyaDuzenleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.VardiyaDuzenleme.ForeColor = System.Drawing.Color.Black;
            this.VardiyaDuzenleme.Location = new System.Drawing.Point(63, 160);
            this.VardiyaDuzenleme.Name = "VardiyaDuzenleme";
            this.VardiyaDuzenleme.Size = new System.Drawing.Size(243, 34);
            this.VardiyaDuzenleme.TabIndex = 1;
            this.VardiyaDuzenleme.Text = "Vardiya Düzenleme ";
            this.VardiyaDuzenleme.UseVisualStyleBackColor = false;
            this.VardiyaDuzenleme.Click += new System.EventHandler(this.button2_Click);
            // 
            // PersonelDuzenleme
            // 
            this.PersonelDuzenleme.BackColor = System.Drawing.Color.Gainsboro;
            this.PersonelDuzenleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersonelDuzenleme.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PersonelDuzenleme.Location = new System.Drawing.Point(63, 81);
            this.PersonelDuzenleme.Name = "PersonelDuzenleme";
            this.PersonelDuzenleme.Size = new System.Drawing.Size(243, 34);
            this.PersonelDuzenleme.TabIndex = 1;
            this.PersonelDuzenleme.Text = "Personel Düzenleme";
            this.PersonelDuzenleme.UseVisualStyleBackColor = false;
            this.PersonelDuzenleme.Click += new System.EventHandler(this.PersonelDuzenleme_Click);
            // 
            // ÇıkışButonu
            // 
            this.ÇıkışButonu.BackColor = System.Drawing.Color.White;
            this.ÇıkışButonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ÇıkışButonu.Location = new System.Drawing.Point(63, 568);
            this.ÇıkışButonu.Name = "ÇıkışButonu";
            this.ÇıkışButonu.Size = new System.Drawing.Size(177, 42);
            this.ÇıkışButonu.TabIndex = 1;
            this.ÇıkışButonu.Text = "Çıkış";
            this.ÇıkışButonu.UseVisualStyleBackColor = false;
            this.ÇıkışButonu.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.ÇıkışButonu);
            this.panel1.Controls.Add(this.VardiyaDuzenleme);
            this.panel1.Controls.Add(this.PersonelDuzenleme);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 653);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(15, 81);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(15, 160);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(42, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(313, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(782, 653);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1094, 649);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Yönetici Ekranı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button VardiyaDuzenleme;
        private System.Windows.Forms.Button PersonelDuzenleme;
        private System.Windows.Forms.Button ÇıkışButonu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

