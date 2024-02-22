namespace NotBilgiSistemi
{
    partial class FrmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            this.BtnOgrenci = new System.Windows.Forms.Button();
            this.BtnOgretmen = new System.Windows.Forms.Button();
            this.BtnDuyuru = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnOgrenci
            // 
            this.BtnOgrenci.BackColor = System.Drawing.Color.PapayaWhip;
            this.BtnOgrenci.Location = new System.Drawing.Point(12, 12);
            this.BtnOgrenci.Name = "BtnOgrenci";
            this.BtnOgrenci.Size = new System.Drawing.Size(147, 99);
            this.BtnOgrenci.TabIndex = 0;
            this.BtnOgrenci.Text = "Öğrenci Giriş";
            this.BtnOgrenci.UseVisualStyleBackColor = false;
            this.BtnOgrenci.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnOgretmen
            // 
            this.BtnOgretmen.BackColor = System.Drawing.Color.PapayaWhip;
            this.BtnOgretmen.Location = new System.Drawing.Point(165, 12);
            this.BtnOgretmen.Name = "BtnOgretmen";
            this.BtnOgretmen.Size = new System.Drawing.Size(147, 99);
            this.BtnOgretmen.TabIndex = 1;
            this.BtnOgretmen.Text = "Öğretmen Giriş";
            this.BtnOgretmen.UseVisualStyleBackColor = false;
            this.BtnOgretmen.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnDuyuru
            // 
            this.BtnDuyuru.BackColor = System.Drawing.Color.PapayaWhip;
            this.BtnDuyuru.Location = new System.Drawing.Point(318, 12);
            this.BtnDuyuru.Name = "BtnDuyuru";
            this.BtnDuyuru.Size = new System.Drawing.Size(147, 99);
            this.BtnDuyuru.TabIndex = 2;
            this.BtnDuyuru.Text = "Duyurular";
            this.BtnDuyuru.UseVisualStyleBackColor = false;
            this.BtnDuyuru.Click += new System.EventHandler(this.BtnDuyuru_Click);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(476, 124);
            this.Controls.Add(this.BtnDuyuru);
            this.Controls.Add(this.BtnOgretmen);
            this.Controls.Add(this.BtnOgrenci);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Sayfası";
            this.Load += new System.EventHandler(this.FrmGiris_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnOgrenci;
        private System.Windows.Forms.Button BtnOgretmen;
        private System.Windows.Forms.Button BtnDuyuru;
    }
}

