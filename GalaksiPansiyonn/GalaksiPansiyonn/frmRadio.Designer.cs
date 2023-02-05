namespace GalaksiPansiyonn
{
    partial class frmRadio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRadio));
            this.linkRadio1 = new System.Windows.Forms.LinkLabel();
            this.linkRadio2 = new System.Windows.Forms.LinkLabel();
            this.linkRadio3 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkRadio1
            // 
            this.linkRadio1.AutoSize = true;
            this.linkRadio1.BackColor = System.Drawing.Color.Transparent;
            this.linkRadio1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkRadio1.LinkColor = System.Drawing.Color.Black;
            this.linkRadio1.Location = new System.Drawing.Point(61, 0);
            this.linkRadio1.Name = "linkRadio1";
            this.linkRadio1.Size = new System.Drawing.Size(90, 28);
            this.linkRadio1.TabIndex = 0;
            this.linkRadio1.TabStop = true;
            this.linkRadio1.Text = "Kral FM ";
            this.linkRadio1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRadio1_LinkClicked);
            // 
            // linkRadio2
            // 
            this.linkRadio2.AutoSize = true;
            this.linkRadio2.BackColor = System.Drawing.Color.Transparent;
            this.linkRadio2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkRadio2.LinkColor = System.Drawing.Color.Black;
            this.linkRadio2.Location = new System.Drawing.Point(213, 0);
            this.linkRadio2.Name = "linkRadio2";
            this.linkRadio2.Size = new System.Drawing.Size(76, 28);
            this.linkRadio2.TabIndex = 1;
            this.linkRadio2.TabStop = true;
            this.linkRadio2.Text = "Pal FM";
            this.linkRadio2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRadio2_LinkClicked);
            // 
            // linkRadio3
            // 
            this.linkRadio3.AutoSize = true;
            this.linkRadio3.BackColor = System.Drawing.Color.Transparent;
            this.linkRadio3.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkRadio3.LinkColor = System.Drawing.Color.Black;
            this.linkRadio3.Location = new System.Drawing.Point(368, 0);
            this.linkRadio3.Name = "linkRadio3";
            this.linkRadio3.Size = new System.Drawing.Size(123, 28);
            this.linkRadio3.TabIndex = 2;
            this.linkRadio3.TabStop = true;
            this.linkRadio3.Text = "Taksim Pop";
            this.linkRadio3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRadio3_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.linkRadio3);
            this.panel1.Controls.Add(this.linkRadio1);
            this.panel1.Controls.Add(this.linkRadio2);
            this.panel1.Location = new System.Drawing.Point(3, 284);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 36);
            this.panel1.TabIndex = 4;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(3, 12);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(536, 212);
            this.axWindowsMediaPlayer1.TabIndex = 3;
            // 
            // frmRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(545, 366);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRadio";
            this.Text = "Radio Dinle";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkRadio1;
        private System.Windows.Forms.LinkLabel linkRadio2;
        private System.Windows.Forms.LinkLabel linkRadio3;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Panel panel1;
    }
}