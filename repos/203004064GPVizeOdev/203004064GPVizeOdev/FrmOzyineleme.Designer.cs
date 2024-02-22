namespace _203004064GPVizeOdev
{
    partial class FrmOzyineleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOzyineleme));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnHesapla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tekBoyutluDiziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çokBoyutluDiziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.değerDönenMetotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.değerDönmeyenMetotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aşırıYüklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(849, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightYellow;
            this.textBox1.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(103, 269);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 34);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "0";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BtnHesapla
            // 
            this.BtnHesapla.BackColor = System.Drawing.Color.LightYellow;
            this.BtnHesapla.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHesapla.Location = new System.Drawing.Point(261, 256);
            this.BtnHesapla.Name = "BtnHesapla";
            this.BtnHesapla.Size = new System.Drawing.Size(180, 57);
            this.BtnHesapla.TabIndex = 10;
            this.BtnHesapla.Text = "HESAPLA";
            this.BtnHesapla.UseVisualStyleBackColor = false;
            this.BtnHesapla.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "SONUÇ : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightYellow;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 100);
            this.panel1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(814, 43);
            this.label3.TabIndex = 0;
            this.label3.Text = "Recursive Fonksiyon İle Faktoriyel Hesaplama";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tekBoyutluDiziToolStripMenuItem,
            this.çokBoyutluDiziToolStripMenuItem,
            this.değerDönenMetotToolStripMenuItem,
            this.değerDönmeyenMetotToolStripMenuItem,
            this.aşırıYüklemeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(877, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tekBoyutluDiziToolStripMenuItem
            // 
            this.tekBoyutluDiziToolStripMenuItem.Name = "tekBoyutluDiziToolStripMenuItem";
            this.tekBoyutluDiziToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.tekBoyutluDiziToolStripMenuItem.Text = "TekBoyutluDizi";
            this.tekBoyutluDiziToolStripMenuItem.Click += new System.EventHandler(this.tekBoyutluDiziToolStripMenuItem_Click);
            // 
            // çokBoyutluDiziToolStripMenuItem
            // 
            this.çokBoyutluDiziToolStripMenuItem.Name = "çokBoyutluDiziToolStripMenuItem";
            this.çokBoyutluDiziToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.çokBoyutluDiziToolStripMenuItem.Text = "ÇokBoyutluDizi";
            this.çokBoyutluDiziToolStripMenuItem.Click += new System.EventHandler(this.çokBoyutluDiziToolStripMenuItem_Click);
            // 
            // değerDönenMetotToolStripMenuItem
            // 
            this.değerDönenMetotToolStripMenuItem.Name = "değerDönenMetotToolStripMenuItem";
            this.değerDönenMetotToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.değerDönenMetotToolStripMenuItem.Text = "DeğerDönenMetot";
            this.değerDönenMetotToolStripMenuItem.Click += new System.EventHandler(this.değerDönenMetotToolStripMenuItem_Click);
            // 
            // değerDönmeyenMetotToolStripMenuItem
            // 
            this.değerDönmeyenMetotToolStripMenuItem.Name = "değerDönmeyenMetotToolStripMenuItem";
            this.değerDönmeyenMetotToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.değerDönmeyenMetotToolStripMenuItem.Text = "DeğerDönmeyenMetot";
            this.değerDönmeyenMetotToolStripMenuItem.Click += new System.EventHandler(this.değerDönmeyenMetotToolStripMenuItem_Click);
            // 
            // aşırıYüklemeToolStripMenuItem
            // 
            this.aşırıYüklemeToolStripMenuItem.Name = "aşırıYüklemeToolStripMenuItem";
            this.aşırıYüklemeToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.aşırıYüklemeToolStripMenuItem.Text = "AşırıYükleme";
            this.aşırıYüklemeToolStripMenuItem.Click += new System.EventHandler(this.aşırıYüklemeToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.LightYellow;
            this.listBox1.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(532, 256);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(244, 196);
            this.listBox1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(572, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "İşlem Geçmişi";
            // 
            // FrmOzyineleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(877, 508);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnHesapla);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmOzyineleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOzyineleme";
            this.Load += new System.EventHandler(this.FrmOzyineleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnHesapla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tekBoyutluDiziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çokBoyutluDiziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem değerDönenMetotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem değerDönmeyenMetotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aşırıYüklemeToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
    }
}