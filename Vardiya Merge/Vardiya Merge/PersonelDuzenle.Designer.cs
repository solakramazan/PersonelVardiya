namespace Vardiya_Merge
{
    partial class PersonelDuzenle
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnpersonelekle = new System.Windows.Forms.Button();
            this.btnpersonelcikar = new System.Windows.Forms.Button();
            this.btnpersonelguncel = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 98);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(237, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel Düzenleme Ekranı";
            // 
            // btnpersonelekle
            // 
            this.btnpersonelekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnpersonelekle.Location = new System.Drawing.Point(70, 362);
            this.btnpersonelekle.Name = "btnpersonelekle";
            this.btnpersonelekle.Size = new System.Drawing.Size(158, 51);
            this.btnpersonelekle.TabIndex = 1;
            this.btnpersonelekle.Text = "Personel Ekle";
            this.btnpersonelekle.UseVisualStyleBackColor = true;
            this.btnpersonelekle.Click += new System.EventHandler(this.btnpersonelekle_Click);
            // 
            // btnpersonelcikar
            // 
            this.btnpersonelcikar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnpersonelcikar.Location = new System.Drawing.Point(327, 362);
            this.btnpersonelcikar.Name = "btnpersonelcikar";
            this.btnpersonelcikar.Size = new System.Drawing.Size(158, 51);
            this.btnpersonelcikar.TabIndex = 2;
            this.btnpersonelcikar.Text = "Personel Çıkar";
            this.btnpersonelcikar.UseVisualStyleBackColor = true;
            this.btnpersonelcikar.Click += new System.EventHandler(this.btnpersonelcikar_Click);
            // 
            // btnpersonelguncel
            // 
            this.btnpersonelguncel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnpersonelguncel.Location = new System.Drawing.Point(562, 362);
            this.btnpersonelguncel.Name = "btnpersonelguncel";
            this.btnpersonelguncel.Size = new System.Drawing.Size(166, 51);
            this.btnpersonelguncel.TabIndex = 3;
            this.btnpersonelguncel.Text = "Personel Güncelle";
            this.btnpersonelguncel.UseVisualStyleBackColor = true;
            // 
            // btnGeri
            // 
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(361, 456);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(103, 53);
            this.btnGeri.TabIndex = 4;
            this.btnGeri.Text = "geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(730, 194);
            this.dataGridView1.TabIndex = 5;
            // 
            // PersonelDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vardiya_Merge.Properties.Resources.personelvardiya;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnpersonelguncel);
            this.Controls.Add(this.btnpersonelcikar);
            this.Controls.Add(this.btnpersonelekle);
            this.Controls.Add(this.panel1);
            this.Name = "PersonelDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Düzenleme";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnpersonelekle;
        private System.Windows.Forms.Button btnpersonelcikar;
        private System.Windows.Forms.Button btnpersonelguncel;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}