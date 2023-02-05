namespace GalaksiPansiyonn
{
    partial class FrmAnaForm
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
            this.components = new System.ComponentModel.Container();
            this.btnAdminGiris = new System.Windows.Forms.Button();
            this.btnYeniMusteri = new System.Windows.Forms.Button();
            this.btnOdalar = new System.Windows.Forms.Button();
            this.btnStoklar = new System.Windows.Forms.Button();
            this.btnGelirGider = new System.Windows.Forms.Button();
            this.btnMusteriler = new System.Windows.Forms.Button();
            this.btnHakkimizda = new System.Windows.Forms.Button();
            this.btnRadio = new System.Windows.Forms.Button();
            this.btnMusteriMesaj = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tmrSaatTarih = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGazeteler = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnSifreGuncelle = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdminGiris
            // 
            this.btnAdminGiris.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdminGiris.Location = new System.Drawing.Point(12, 12);
            this.btnAdminGiris.Name = "btnAdminGiris";
            this.btnAdminGiris.Size = new System.Drawing.Size(143, 74);
            this.btnAdminGiris.TabIndex = 0;
            this.btnAdminGiris.Text = "Admin Giriş";
            this.btnAdminGiris.UseVisualStyleBackColor = true;
            this.btnAdminGiris.Click += new System.EventHandler(this.btnAdminGiris_Click);
            // 
            // btnYeniMusteri
            // 
            this.btnYeniMusteri.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniMusteri.Location = new System.Drawing.Point(176, 12);
            this.btnYeniMusteri.Name = "btnYeniMusteri";
            this.btnYeniMusteri.Size = new System.Drawing.Size(143, 74);
            this.btnYeniMusteri.TabIndex = 1;
            this.btnYeniMusteri.Text = "Yeni Müşteri";
            this.btnYeniMusteri.UseVisualStyleBackColor = true;
            this.btnYeniMusteri.Click += new System.EventHandler(this.btnYeniMusteri_Click);
            // 
            // btnOdalar
            // 
            this.btnOdalar.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdalar.Location = new System.Drawing.Point(337, 12);
            this.btnOdalar.Name = "btnOdalar";
            this.btnOdalar.Size = new System.Drawing.Size(143, 74);
            this.btnOdalar.TabIndex = 2;
            this.btnOdalar.Text = "Odalar";
            this.btnOdalar.UseVisualStyleBackColor = true;
            this.btnOdalar.Click += new System.EventHandler(this.btnOdalar_Click);
            // 
            // btnStoklar
            // 
            this.btnStoklar.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStoklar.Location = new System.Drawing.Point(337, 118);
            this.btnStoklar.Name = "btnStoklar";
            this.btnStoklar.Size = new System.Drawing.Size(143, 74);
            this.btnStoklar.TabIndex = 5;
            this.btnStoklar.Text = "Stoklar";
            this.btnStoklar.UseVisualStyleBackColor = true;
            this.btnStoklar.Click += new System.EventHandler(this.btnStoklar_Click);
            // 
            // btnGelirGider
            // 
            this.btnGelirGider.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGelirGider.Location = new System.Drawing.Point(176, 118);
            this.btnGelirGider.Name = "btnGelirGider";
            this.btnGelirGider.Size = new System.Drawing.Size(143, 74);
            this.btnGelirGider.TabIndex = 4;
            this.btnGelirGider.Text = "Gelir-Gider";
            this.btnGelirGider.UseVisualStyleBackColor = true;
            this.btnGelirGider.Click += new System.EventHandler(this.btnGelirGider_Click);
            // 
            // btnMusteriler
            // 
            this.btnMusteriler.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriler.Location = new System.Drawing.Point(12, 118);
            this.btnMusteriler.Name = "btnMusteriler";
            this.btnMusteriler.Size = new System.Drawing.Size(143, 74);
            this.btnMusteriler.TabIndex = 3;
            this.btnMusteriler.Text = "Müşteriler";
            this.btnMusteriler.UseVisualStyleBackColor = true;
            this.btnMusteriler.Click += new System.EventHandler(this.btnMusteriler_Click);
            // 
            // btnHakkimizda
            // 
            this.btnHakkimizda.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHakkimizda.Location = new System.Drawing.Point(337, 217);
            this.btnHakkimizda.Name = "btnHakkimizda";
            this.btnHakkimizda.Size = new System.Drawing.Size(143, 74);
            this.btnHakkimizda.TabIndex = 8;
            this.btnHakkimizda.Text = "Hakkımızda";
            this.btnHakkimizda.UseVisualStyleBackColor = true;
            this.btnHakkimizda.Click += new System.EventHandler(this.btnHakkimizda_Click);
            // 
            // btnRadio
            // 
            this.btnRadio.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRadio.Location = new System.Drawing.Point(176, 217);
            this.btnRadio.Name = "btnRadio";
            this.btnRadio.Size = new System.Drawing.Size(143, 74);
            this.btnRadio.TabIndex = 7;
            this.btnRadio.Text = "Radio";
            this.btnRadio.UseVisualStyleBackColor = true;
            this.btnRadio.Click += new System.EventHandler(this.btnRadio_Click);
            // 
            // btnMusteriMesaj
            // 
            this.btnMusteriMesaj.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriMesaj.Location = new System.Drawing.Point(12, 217);
            this.btnMusteriMesaj.Name = "btnMusteriMesaj";
            this.btnMusteriMesaj.Size = new System.Drawing.Size(143, 74);
            this.btnMusteriMesaj.TabIndex = 6;
            this.btnMusteriMesaj.Text = "Müşteri\r\nMesajları";
            this.btnMusteriMesaj.UseVisualStyleBackColor = true;
            this.btnMusteriMesaj.Click += new System.EventHandler(this.btnMusteriMesaj_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnSifreGuncelle);
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Controls.Add(this.btnGazeteler);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(496, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 279);
            this.panel1.TabIndex = 9;
            // 
            // tmrSaatTarih
            // 
            this.tmrSaatTarih.Tick += new System.EventHandler(this.tmrSaatTarih_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblSaat);
            this.panel2.Controls.Add(this.lblTarih);
            this.panel2.Location = new System.Drawing.Point(22, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 63);
            this.panel2.TabIndex = 0;
            // 
            // btnGazeteler
            // 
            this.btnGazeteler.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGazeteler.Location = new System.Drawing.Point(22, 72);
            this.btnGazeteler.Name = "btnGazeteler";
            this.btnGazeteler.Size = new System.Drawing.Size(256, 56);
            this.btnGazeteler.TabIndex = 10;
            this.btnGazeteler.Text = "Gazeteler";
            this.btnGazeteler.UseVisualStyleBackColor = true;
            this.btnGazeteler.Click += new System.EventHandler(this.btnGazeteler_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(22, 212);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(256, 56);
            this.btnCikis.TabIndex = 11;
            this.btnCikis.Text = "Oturumu Kapat";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnSifreGuncelle
            // 
            this.btnSifreGuncelle.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifreGuncelle.Location = new System.Drawing.Point(22, 144);
            this.btnSifreGuncelle.Name = "btnSifreGuncelle";
            this.btnSifreGuncelle.Size = new System.Drawing.Size(256, 56);
            this.btnSifreGuncelle.TabIndex = 12;
            this.btnSifreGuncelle.Text = "Şifre Güncelle";
            this.btnSifreGuncelle.UseVisualStyleBackColor = true;
            this.btnSifreGuncelle.Click += new System.EventHandler(this.btnSifreGuncelle_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(13, 309);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(775, 38);
            this.panel3.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(537, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Galaksi Pansiyon 2023/Sakarya";
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Location = new System.Drawing.Point(43, 36);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(33, 16);
            this.lblSaat.TabIndex = 5;
            this.lblSaat.Text = "saat";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(38, 11);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(38, 16);
            this.lblTarih.TabIndex = 4;
            this.lblTarih.Text = "Tarih";
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(800, 357);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnHakkimizda);
            this.Controls.Add(this.btnRadio);
            this.Controls.Add(this.btnMusteriMesaj);
            this.Controls.Add(this.btnStoklar);
            this.Controls.Add(this.btnGelirGider);
            this.Controls.Add(this.btnMusteriler);
            this.Controls.Add(this.btnOdalar);
            this.Controls.Add(this.btnYeniMusteri);
            this.Controls.Add(this.btnAdminGiris);
            this.Name = "FrmAnaForm";
            this.Text = "FrmAnaForm";
            this.Load += new System.EventHandler(this.FrmAnaForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdminGiris;
        private System.Windows.Forms.Button btnYeniMusteri;
        private System.Windows.Forms.Button btnOdalar;
        private System.Windows.Forms.Button btnStoklar;
        private System.Windows.Forms.Button btnGelirGider;
        private System.Windows.Forms.Button btnMusteriler;
        private System.Windows.Forms.Button btnHakkimizda;
        private System.Windows.Forms.Button btnRadio;
        private System.Windows.Forms.Button btnMusteriMesaj;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer tmrSaatTarih;
        private System.Windows.Forms.Button btnSifreGuncelle;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGazeteler;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Label lblTarih;
    }
}