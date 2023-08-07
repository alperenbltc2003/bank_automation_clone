namespace bankamatikOto
{
    partial class YetkiliIslem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(31, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hoşgeldiniz Sayın Admin...";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCikis);
            this.groupBox2.Controls.Add(this.btnListele);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.btnGuncelle);
            this.groupBox2.Controls.Add(this.btnAra);
            this.groupBox2.Controls.Add(this.btnEkle);
            this.groupBox2.Location = new System.Drawing.Point(60, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 441);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yetkili İşlemleri";
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Red;
            this.btnCikis.ForeColor = System.Drawing.Color.White;
            this.btnCikis.Location = new System.Drawing.Point(33, 370);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(293, 45);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.White;
            this.btnListele.Location = new System.Drawing.Point(33, 313);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(293, 45);
            this.btnListele.TabIndex = 4;
            this.btnListele.Text = "Müşterileri Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(33, 253);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(293, 45);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Müşteri Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(33, 193);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(293, 45);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Müşteri Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.White;
            this.btnAra.Location = new System.Drawing.Point(33, 133);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(293, 45);
            this.btnAra.TabIndex = 1;
            this.btnAra.Text = "Müşteri Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(33, 73);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(293, 45);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Müşteri Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // YetkiliIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(478, 542);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "YetkiliIslem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YETKİLİ İŞLEM EKRANI";
            this.Load += new System.EventHandler(this.YetkiliIslem_Load);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnEkle;
    }
}