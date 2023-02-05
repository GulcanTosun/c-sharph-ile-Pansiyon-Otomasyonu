namespace GalaksiPansiyonn
{
    partial class frmGazete
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnHurriyet = new System.Windows.Forms.Button();
            this.btnMilliyet = new System.Windows.Forms.Button();
            this.btnSozcu = new System.Windows.Forms.Button();
            this.btnHaberturk = new System.Windows.Forms.Button();
            this.btnFanatik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(23, 62);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(609, 376);
            this.webBrowser1.TabIndex = 0;
            // 
            // btnHurriyet
            // 
            this.btnHurriyet.Font = new System.Drawing.Font("Segoe UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHurriyet.Location = new System.Drawing.Point(23, 12);
            this.btnHurriyet.Name = "btnHurriyet";
            this.btnHurriyet.Size = new System.Drawing.Size(117, 44);
            this.btnHurriyet.TabIndex = 1;
            this.btnHurriyet.Text = "Hürriyet";
            this.btnHurriyet.UseVisualStyleBackColor = true;
            this.btnHurriyet.Click += new System.EventHandler(this.btnHurriyet_Click);
            // 
            // btnMilliyet
            // 
            this.btnMilliyet.Font = new System.Drawing.Font("Segoe UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMilliyet.Location = new System.Drawing.Point(146, 12);
            this.btnMilliyet.Name = "btnMilliyet";
            this.btnMilliyet.Size = new System.Drawing.Size(117, 44);
            this.btnMilliyet.TabIndex = 2;
            this.btnMilliyet.Text = "Milliyet";
            this.btnMilliyet.UseVisualStyleBackColor = true;
            this.btnMilliyet.Click += new System.EventHandler(this.btnMilliyet_Click);
            // 
            // btnSozcu
            // 
            this.btnSozcu.Font = new System.Drawing.Font("Segoe UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSozcu.Location = new System.Drawing.Point(269, 12);
            this.btnSozcu.Name = "btnSozcu";
            this.btnSozcu.Size = new System.Drawing.Size(117, 44);
            this.btnSozcu.TabIndex = 3;
            this.btnSozcu.Text = "Sözcü";
            this.btnSozcu.UseVisualStyleBackColor = true;
            this.btnSozcu.Click += new System.EventHandler(this.btnSozcu_Click);
            // 
            // btnHaberturk
            // 
            this.btnHaberturk.Font = new System.Drawing.Font("Segoe UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHaberturk.Location = new System.Drawing.Point(392, 12);
            this.btnHaberturk.Name = "btnHaberturk";
            this.btnHaberturk.Size = new System.Drawing.Size(117, 44);
            this.btnHaberturk.TabIndex = 4;
            this.btnHaberturk.Text = "HaberTürk";
            this.btnHaberturk.UseVisualStyleBackColor = true;
            this.btnHaberturk.Click += new System.EventHandler(this.btnHaberturk_Click);
            // 
            // btnFanatik
            // 
            this.btnFanatik.Font = new System.Drawing.Font("Segoe UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFanatik.Location = new System.Drawing.Point(515, 12);
            this.btnFanatik.Name = "btnFanatik";
            this.btnFanatik.Size = new System.Drawing.Size(117, 44);
            this.btnFanatik.TabIndex = 5;
            this.btnFanatik.Text = "Fanatik";
            this.btnFanatik.UseVisualStyleBackColor = true;
            this.btnFanatik.Click += new System.EventHandler(this.btnFanatik_Click);
            // 
            // frmGazete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(657, 455);
            this.Controls.Add(this.btnFanatik);
            this.Controls.Add(this.btnHaberturk);
            this.Controls.Add(this.btnSozcu);
            this.Controls.Add(this.btnMilliyet);
            this.Controls.Add(this.btnHurriyet);
            this.Controls.Add(this.webBrowser1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGazete";
            this.Text = "Gazete";
            this.Load += new System.EventHandler(this.frmGazete_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnHurriyet;
        private System.Windows.Forms.Button btnMilliyet;
        private System.Windows.Forms.Button btnSozcu;
        private System.Windows.Forms.Button btnHaberturk;
        private System.Windows.Forms.Button btnFanatik;
    }
}