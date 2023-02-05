namespace GalaksiPansiyonn
{
    partial class FrmYeniMusteri
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblgun = new System.Windows.Forms.Label();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimeCikis = new System.Windows.Forms.DateTimePicker();
            this.dateTimeGiris = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.ucret = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.msgTxtTel = new System.Windows.Forms.MaskedTextBox();
            this.txtOdaNum = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtSad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Odalar = new System.Windows.Forms.GroupBox();
            this.btnDolu = new System.Windows.Forms.Button();
            this.BtnBos = new System.Windows.Forms.Button();
            this.btn109 = new System.Windows.Forms.Button();
            this.btn108 = new System.Windows.Forms.Button();
            this.btn107 = new System.Windows.Forms.Button();
            this.btn106 = new System.Windows.Forms.Button();
            this.btn103 = new System.Windows.Forms.Button();
            this.btn102 = new System.Windows.Forms.Button();
            this.btn101 = new System.Windows.Forms.Button();
            this.btn105 = new System.Windows.Forms.Button();
            this.btn104 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.Odalar.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox1.Controls.Add(this.lblgun);
            this.groupBox1.Controls.Add(this.cmbCinsiyet);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dateTimeCikis);
            this.groupBox1.Controls.Add(this.dateTimeGiris);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtUcret);
            this.groupBox1.Controls.Add(this.ucret);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.msgTxtTel);
            this.groupBox1.Controls.Add(this.txtOdaNum);
            this.groupBox1.Controls.Add(this.txtTc);
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.txtSad);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 379);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // lblgun
            // 
            this.lblgun.AutoSize = true;
            this.lblgun.Location = new System.Drawing.Point(209, 315);
            this.lblgun.Name = "lblgun";
            this.lblgun.Size = new System.Drawing.Size(14, 16);
            this.lblgun.TabIndex = 43;
            this.lblgun.Text = "0";
            this.lblgun.Visible = false;
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Bay",
            "Bayan"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(117, 73);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(201, 24);
            this.cmbCinsiyet.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 41;
            this.label9.Text = "Cinsiyet:";
            // 
            // dateTimeCikis
            // 
            this.dateTimeCikis.Location = new System.Drawing.Point(114, 270);
            this.dateTimeCikis.Name = "dateTimeCikis";
            this.dateTimeCikis.Size = new System.Drawing.Size(200, 22);
            this.dateTimeCikis.TabIndex = 40;
            this.dateTimeCikis.ValueChanged += new System.EventHandler(this.dateTimeCikis_ValueChanged);
            // 
            // dateTimeGiris
            // 
            this.dateTimeGiris.Location = new System.Drawing.Point(115, 238);
            this.dateTimeGiris.Name = "dateTimeGiris";
            this.dateTimeGiris.Size = new System.Drawing.Size(200, 22);
            this.dateTimeGiris.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 38;
            this.label8.Text = "Çıkış Tarihi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 37;
            this.label7.Text = "Giriş Tarihi:";
            // 
            // txtUcret
            // 
            this.txtUcret.Location = new System.Drawing.Point(118, 210);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(198, 22);
            this.txtUcret.TabIndex = 36;
            // 
            // ucret
            // 
            this.ucret.AutoSize = true;
            this.ucret.Location = new System.Drawing.Point(66, 213);
            this.ucret.Name = "ucret";
            this.ucret.Size = new System.Drawing.Size(42, 16);
            this.ucret.TabIndex = 35;
            this.ucret.Text = "Ücret:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Transparent;
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKaydet.Location = new System.Drawing.Point(240, 304);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 27);
            this.btnKaydet.TabIndex = 34;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // msgTxtTel
            // 
            this.msgTxtTel.Location = new System.Drawing.Point(118, 101);
            this.msgTxtTel.Mask = "(000) 000 00 00";
            this.msgTxtTel.Name = "msgTxtTel";
            this.msgTxtTel.Size = new System.Drawing.Size(197, 22);
            this.msgTxtTel.TabIndex = 31;
            // 
            // txtOdaNum
            // 
            this.txtOdaNum.Enabled = false;
            this.txtOdaNum.Location = new System.Drawing.Point(118, 182);
            this.txtOdaNum.Name = "txtOdaNum";
            this.txtOdaNum.Size = new System.Drawing.Size(198, 22);
            this.txtOdaNum.TabIndex = 30;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(118, 154);
            this.txtTc.MaxLength = 11;
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(197, 22);
            this.txtTc.TabIndex = 29;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(118, 126);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(197, 22);
            this.txtMail.TabIndex = 28;
            // 
            // txtSad
            // 
            this.txtSad.Location = new System.Drawing.Point(118, 46);
            this.txtSad.Name = "txtSad";
            this.txtSad.Size = new System.Drawing.Size(197, 22);
            this.txtSad.TabIndex = 27;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(119, 18);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(197, 22);
            this.txtAd.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Oda Numarası:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "T.C Kimlik No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ad:";
            // 
            // Odalar
            // 
            this.Odalar.BackgroundImage = global::GalaksiPansiyonn.Properties.Resources.pngwing_com__25_;
            this.Odalar.Controls.Add(this.btn104);
            this.Odalar.Controls.Add(this.btn105);
            this.Odalar.Controls.Add(this.btnDolu);
            this.Odalar.Controls.Add(this.BtnBos);
            this.Odalar.Controls.Add(this.btn109);
            this.Odalar.Controls.Add(this.btn108);
            this.Odalar.Controls.Add(this.btn107);
            this.Odalar.Controls.Add(this.btn106);
            this.Odalar.Controls.Add(this.btn103);
            this.Odalar.Controls.Add(this.btn102);
            this.Odalar.Controls.Add(this.btn101);
            this.Odalar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Odalar.Location = new System.Drawing.Point(424, 12);
            this.Odalar.Name = "Odalar";
            this.Odalar.Size = new System.Drawing.Size(296, 379);
            this.Odalar.TabIndex = 1;
            this.Odalar.TabStop = false;
            this.Odalar.Text = "Odalar";
            // 
            // btnDolu
            // 
            this.btnDolu.BackColor = System.Drawing.Color.Red;
            this.btnDolu.Location = new System.Drawing.Point(114, 258);
            this.btnDolu.Name = "btnDolu";
            this.btnDolu.Size = new System.Drawing.Size(56, 32);
            this.btnDolu.TabIndex = 10;
            this.btnDolu.Text = "Dolu";
            this.btnDolu.UseVisualStyleBackColor = false;
            this.btnDolu.Click += new System.EventHandler(this.btnDolu_Click);
            // 
            // BtnBos
            // 
            this.BtnBos.BackColor = System.Drawing.Color.YellowGreen;
            this.BtnBos.Location = new System.Drawing.Point(39, 258);
            this.BtnBos.Name = "BtnBos";
            this.BtnBos.Size = new System.Drawing.Size(56, 32);
            this.BtnBos.TabIndex = 9;
            this.BtnBos.Text = "Boş";
            this.BtnBos.UseVisualStyleBackColor = false;
            this.BtnBos.Click += new System.EventHandler(this.BtnBos_Click);
            // 
            // btn109
            // 
            this.btn109.BackColor = System.Drawing.Color.YellowGreen;
            this.btn109.Location = new System.Drawing.Point(192, 192);
            this.btn109.Name = "btn109";
            this.btn109.Size = new System.Drawing.Size(56, 32);
            this.btn109.TabIndex = 8;
            this.btn109.Text = "109";
            this.btn109.UseVisualStyleBackColor = false;
            this.btn109.Click += new System.EventHandler(this.btn109_Click);
            // 
            // btn108
            // 
            this.btn108.BackColor = System.Drawing.Color.YellowGreen;
            this.btn108.Location = new System.Drawing.Point(114, 192);
            this.btn108.Name = "btn108";
            this.btn108.Size = new System.Drawing.Size(56, 32);
            this.btn108.TabIndex = 7;
            this.btn108.Text = "108";
            this.btn108.UseVisualStyleBackColor = false;
            this.btn108.Click += new System.EventHandler(this.btn108_Click);
            // 
            // btn107
            // 
            this.btn107.BackColor = System.Drawing.Color.YellowGreen;
            this.btn107.Location = new System.Drawing.Point(39, 192);
            this.btn107.Name = "btn107";
            this.btn107.Size = new System.Drawing.Size(56, 32);
            this.btn107.TabIndex = 6;
            this.btn107.Text = "107";
            this.btn107.UseVisualStyleBackColor = false;
            this.btn107.Click += new System.EventHandler(this.btn107_Click);
            // 
            // btn106
            // 
            this.btn106.BackColor = System.Drawing.Color.YellowGreen;
            this.btn106.Location = new System.Drawing.Point(192, 131);
            this.btn106.Name = "btn106";
            this.btn106.Size = new System.Drawing.Size(56, 32);
            this.btn106.TabIndex = 5;
            this.btn106.Text = "106";
            this.btn106.UseVisualStyleBackColor = false;
            this.btn106.Click += new System.EventHandler(this.btn106_Click);
            // 
            // btn103
            // 
            this.btn103.BackColor = System.Drawing.Color.YellowGreen;
            this.btn103.Location = new System.Drawing.Point(192, 64);
            this.btn103.Name = "btn103";
            this.btn103.Size = new System.Drawing.Size(56, 32);
            this.btn103.TabIndex = 2;
            this.btn103.Text = "103";
            this.btn103.UseVisualStyleBackColor = false;
            this.btn103.Click += new System.EventHandler(this.btn103_Click);
            // 
            // btn102
            // 
            this.btn102.BackColor = System.Drawing.Color.YellowGreen;
            this.btn102.Location = new System.Drawing.Point(114, 64);
            this.btn102.Name = "btn102";
            this.btn102.Size = new System.Drawing.Size(56, 32);
            this.btn102.TabIndex = 1;
            this.btn102.Text = "102";
            this.btn102.UseVisualStyleBackColor = false;
            this.btn102.Click += new System.EventHandler(this.btn102_Click);
            // 
            // btn101
            // 
            this.btn101.BackColor = System.Drawing.Color.YellowGreen;
            this.btn101.Location = new System.Drawing.Point(39, 64);
            this.btn101.Name = "btn101";
            this.btn101.Size = new System.Drawing.Size(56, 32);
            this.btn101.TabIndex = 0;
            this.btn101.Text = "101";
            this.btn101.UseVisualStyleBackColor = false;
            this.btn101.Click += new System.EventHandler(this.btn101_Click);
            // 
            // btn105
            // 
            this.btn105.BackColor = System.Drawing.Color.YellowGreen;
            this.btn105.Location = new System.Drawing.Point(114, 131);
            this.btn105.Name = "btn105";
            this.btn105.Size = new System.Drawing.Size(56, 32);
            this.btn105.TabIndex = 11;
            this.btn105.Text = "105";
            this.btn105.UseVisualStyleBackColor = false;
            // 
            // btn104
            // 
            this.btn104.BackColor = System.Drawing.Color.YellowGreen;
            this.btn104.Location = new System.Drawing.Point(39, 131);
            this.btn104.Name = "btn104";
            this.btn104.Size = new System.Drawing.Size(56, 32);
            this.btn104.TabIndex = 12;
            this.btn104.Text = "104";
            this.btn104.UseVisualStyleBackColor = false;
            this.btn104.Click += new System.EventHandler(this.btn104_Click);
            // 
            // FrmYeniMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(740, 414);
            this.Controls.Add(this.Odalar);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmYeniMusteri";
            this.Text = "FrmYeniMusteri";
            this.Load += new System.EventHandler(this.FrmYeniMusteri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Odalar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.MaskedTextBox msgTxtTel;
        private System.Windows.Forms.TextBox txtOdaNum;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtSad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Odalar;
        private System.Windows.Forms.Button btn109;
        private System.Windows.Forms.Button btn108;
        private System.Windows.Forms.Button btn107;
        private System.Windows.Forms.Button btn106;
        private System.Windows.Forms.Button btn103;
        private System.Windows.Forms.Button btn102;
        private System.Windows.Forms.Button btn101;
        private System.Windows.Forms.Button btnDolu;
        private System.Windows.Forms.Button BtnBos;
        private System.Windows.Forms.DateTimePicker dateTimeCikis;
        private System.Windows.Forms.DateTimePicker dateTimeGiris;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.Label ucret;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblgun;
        private System.Windows.Forms.Button btn105;
        private System.Windows.Forms.Button btn104;
    }
}