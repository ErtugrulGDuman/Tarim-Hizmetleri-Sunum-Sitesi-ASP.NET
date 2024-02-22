namespace _203004064GPVizeOdev
{
    partial class FrmDegerDonenMetot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDegerDonenMetot));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tekBoyutluDiziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çokBoyutluDiziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.degerDonmeyenMetotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aşırıYüklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.özyinelemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(807, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.LightYellow;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "SUV",
            "SEDAN",
            "HATCHBACK"});
            this.comboBox1.Location = new System.Drawing.Point(12, 149);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 32);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.LightYellow;
            this.listBox1.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(12, 338);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(812, 124);
            this.listBox1.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightYellow;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 100);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arabalar Hakkında Bilgi";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(202, 149);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(622, 183);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tekBoyutluDiziToolStripMenuItem,
            this.çokBoyutluDiziToolStripMenuItem,
            this.degerDonmeyenMetotToolStripMenuItem,
            this.aşırıYüklemeToolStripMenuItem,
            this.özyinelemeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(836, 28);
            this.menuStrip1.TabIndex = 13;
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
            // degerDonmeyenMetotToolStripMenuItem
            // 
            this.degerDonmeyenMetotToolStripMenuItem.Name = "degerDonmeyenMetotToolStripMenuItem";
            this.degerDonmeyenMetotToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.degerDonmeyenMetotToolStripMenuItem.Text = "DegerDonmeyenMetot";
            this.degerDonmeyenMetotToolStripMenuItem.Click += new System.EventHandler(this.degerDonmeyenMetotToolStripMenuItem_Click);
            // 
            // aşırıYüklemeToolStripMenuItem
            // 
            this.aşırıYüklemeToolStripMenuItem.Name = "aşırıYüklemeToolStripMenuItem";
            this.aşırıYüklemeToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.aşırıYüklemeToolStripMenuItem.Text = "AşırıYükleme";
            this.aşırıYüklemeToolStripMenuItem.Click += new System.EventHandler(this.aşırıYüklemeToolStripMenuItem_Click);
            // 
            // özyinelemeToolStripMenuItem
            // 
            this.özyinelemeToolStripMenuItem.Name = "özyinelemeToolStripMenuItem";
            this.özyinelemeToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.özyinelemeToolStripMenuItem.Text = "Özyineleme";
            this.özyinelemeToolStripMenuItem.Click += new System.EventHandler(this.özyinelemeToolStripMenuItem_Click);
            // 
            // FrmDegerDonenMetot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(836, 473);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmDegerDonenMetot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDegerDonenMetot";
            this.Load += new System.EventHandler(this.FrmDegerDonenMetot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tekBoyutluDiziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çokBoyutluDiziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem degerDonmeyenMetotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aşırıYüklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem özyinelemeToolStripMenuItem;
    }
}