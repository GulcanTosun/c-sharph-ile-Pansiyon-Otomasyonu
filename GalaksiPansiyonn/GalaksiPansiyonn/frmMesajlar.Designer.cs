namespace GalaksiPansiyonn
{
    partial class frmMesajlar
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdSad = new System.Windows.Forms.TextBox();
            this.richTxtMesaj = new System.Windows.Forms.RichTextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.listMesajlar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(36, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(66, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mesaj :";
            // 
            // txtAdSad
            // 
            this.txtAdSad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdSad.Location = new System.Drawing.Point(152, 43);
            this.txtAdSad.Name = "txtAdSad";
            this.txtAdSad.Size = new System.Drawing.Size(285, 27);
            this.txtAdSad.TabIndex = 2;
            // 
            // richTxtMesaj
            // 
            this.richTxtMesaj.Location = new System.Drawing.Point(152, 82);
            this.richTxtMesaj.Name = "richTxtMesaj";
            this.richTxtMesaj.Size = new System.Drawing.Size(285, 144);
            this.richTxtMesaj.TabIndex = 3;
            this.richTxtMesaj.Text = "";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(340, 232);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(97, 30);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // listMesajlar
            // 
            this.listMesajlar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listMesajlar.HideSelection = false;
            this.listMesajlar.Location = new System.Drawing.Point(1, 283);
            this.listMesajlar.Name = "listMesajlar";
            this.listMesajlar.Size = new System.Drawing.Size(510, 169);
            this.listMesajlar.TabIndex = 5;
            this.listMesajlar.UseCompatibleStateImageBehavior = false;
            this.listMesajlar.View = System.Windows.Forms.View.Details;
            this.listMesajlar.DoubleClick += new System.EventHandler(this.listMesajlar_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 35;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ad Soyad";
            this.columnHeader2.Width = 158;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mesaj";
            this.columnHeader3.Width = 311;
            // 
            // frmMesajlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(510, 450);
            this.Controls.Add(this.listMesajlar);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.richTxtMesaj);
            this.Controls.Add(this.txtAdSad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMesajlar";
            this.Text = "Müşteri Memnuniyeti";
            this.Load += new System.EventHandler(this.frmMesajlar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdSad;
        private System.Windows.Forms.RichTextBox richTxtMesaj;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ListView listMesajlar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}