
namespace Vardiya_Merge
{
    partial class Patron
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patron));
            this.panel1 = new System.Windows.Forms.Panel();
            this.yontcdzbtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.vardzbtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.persznbtn = new System.Windows.Forms.Button();
            this.Cıkıs = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HosGeldiniz = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.yontcdzbtn);
            this.panel1.Location = new System.Drawing.Point(27, 171);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 60);
            this.panel1.TabIndex = 1;
            // 
            // yontcdzbtn
            // 
            this.yontcdzbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yontcdzbtn.Location = new System.Drawing.Point(20, 15);
            this.yontcdzbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yontcdzbtn.Name = "yontcdzbtn";
            this.yontcdzbtn.Size = new System.Drawing.Size(156, 32);
            this.yontcdzbtn.TabIndex = 0;
            this.yontcdzbtn.Text = "Yönetici düzenle";
            this.yontcdzbtn.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.vardzbtn);
            this.panel2.Location = new System.Drawing.Point(531, 171);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 60);
            this.panel2.TabIndex = 1;
            // 
            // vardzbtn
            // 
            this.vardzbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.vardzbtn.Location = new System.Drawing.Point(19, 14);
            this.vardzbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vardzbtn.Name = "vardzbtn";
            this.vardzbtn.Size = new System.Drawing.Size(159, 33);
            this.vardzbtn.TabIndex = 0;
            this.vardzbtn.Text = "Vardiya Düzenle";
            this.vardzbtn.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.persznbtn);
            this.panel3.Location = new System.Drawing.Point(277, 171);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(195, 60);
            this.panel3.TabIndex = 1;
            // 
            // persznbtn
            // 
            this.persznbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.persznbtn.Location = new System.Drawing.Point(19, 15);
            this.persznbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.persznbtn.Name = "persznbtn";
            this.persznbtn.Size = new System.Drawing.Size(159, 32);
            this.persznbtn.TabIndex = 0;
            this.persznbtn.Text = "Personel Düzenle";
            this.persznbtn.UseVisualStyleBackColor = true;
            this.persznbtn.Click += new System.EventHandler(this.persznbtn_Click);
            // 
            // Cıkıs
            // 
            this.Cıkıs.BackColor = System.Drawing.Color.Red;
            this.Cıkıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cıkıs.Location = new System.Drawing.Point(581, 363);
            this.Cıkıs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cıkıs.Name = "Cıkıs";
            this.Cıkıs.Size = new System.Drawing.Size(128, 54);
            this.Cıkıs.TabIndex = 2;
            this.Cıkıs.Text = "Çıkış";
            this.Cıkıs.UseVisualStyleBackColor = false;
            this.Cıkıs.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.HosGeldiniz);
            this.panel4.Location = new System.Drawing.Point(0, -1);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 118);
            this.panel4.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // HosGeldiniz
            // 
            this.HosGeldiniz.AutoSize = true;
            this.HosGeldiniz.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HosGeldiniz.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HosGeldiniz.Location = new System.Drawing.Point(337, 31);
            this.HosGeldiniz.Name = "HosGeldiniz";
            this.HosGeldiniz.Size = new System.Drawing.Size(279, 51);
            this.HosGeldiniz.TabIndex = 0;
            this.HosGeldiniz.Text = "Hoş Geldiniz";
            // 
            // Patron
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Patron";
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Cıkıs;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label HosGeldiniz;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button yontcdzbtn;
        private System.Windows.Forms.Button vardzbtn;
        private System.Windows.Forms.Button persznbtn;
    }
}

