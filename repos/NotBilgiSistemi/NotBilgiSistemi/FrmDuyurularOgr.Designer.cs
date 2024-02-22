namespace NotBilgiSistemi
{
    partial class FrmDuyurularOgr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDuyurularOgr));
            this.MskTarih = new System.Windows.Forms.MaskedTextBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.RchTxtDuyuru = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duyuruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duyuruTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDuyuruBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notBilgiSistemiDataSet5 = new NotBilgiSistemi.NotBilgiSistemiDataSet5();
            this.BtnListele = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGeri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tblDuyuruTableAdapter = new NotBilgiSistemi.NotBilgiSistemiDataSet5TableAdapters.TblDuyuruTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDuyuruBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notBilgiSistemiDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // MskTarih
            // 
            this.MskTarih.BackColor = System.Drawing.Color.PapayaWhip;
            this.MskTarih.Location = new System.Drawing.Point(116, 40);
            this.MskTarih.Mask = "00/00/0000";
            this.MskTarih.Name = "MskTarih";
            this.MskTarih.Size = new System.Drawing.Size(153, 22);
            this.MskTarih.TabIndex = 0;
            this.MskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // TxtID
            // 
            this.TxtID.BackColor = System.Drawing.Color.PapayaWhip;
            this.TxtID.Location = new System.Drawing.Point(116, 12);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(153, 22);
            this.TxtID.TabIndex = 1;
            // 
            // RchTxtDuyuru
            // 
            this.RchTxtDuyuru.BackColor = System.Drawing.Color.PapayaWhip;
            this.RchTxtDuyuru.Location = new System.Drawing.Point(116, 68);
            this.RchTxtDuyuru.Name = "RchTxtDuyuru";
            this.RchTxtDuyuru.Size = new System.Drawing.Size(153, 166);
            this.RchTxtDuyuru.TabIndex = 2;
            this.RchTxtDuyuru.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.duyuruDataGridViewTextBoxColumn,
            this.duyuruTarihDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblDuyuruBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(415, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(543, 222);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıDDataGridViewTextBoxColumn.Width = 125;
            // 
            // duyuruDataGridViewTextBoxColumn
            // 
            this.duyuruDataGridViewTextBoxColumn.DataPropertyName = "Duyuru";
            this.duyuruDataGridViewTextBoxColumn.HeaderText = "Duyuru";
            this.duyuruDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.duyuruDataGridViewTextBoxColumn.Name = "duyuruDataGridViewTextBoxColumn";
            this.duyuruDataGridViewTextBoxColumn.Width = 125;
            // 
            // duyuruTarihDataGridViewTextBoxColumn
            // 
            this.duyuruTarihDataGridViewTextBoxColumn.DataPropertyName = "DuyuruTarih";
            this.duyuruTarihDataGridViewTextBoxColumn.HeaderText = "DuyuruTarih";
            this.duyuruTarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.duyuruTarihDataGridViewTextBoxColumn.Name = "duyuruTarihDataGridViewTextBoxColumn";
            this.duyuruTarihDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblDuyuruBindingSource
            // 
            this.tblDuyuruBindingSource.DataMember = "TblDuyuru";
            this.tblDuyuruBindingSource.DataSource = this.notBilgiSistemiDataSet5;
            // 
            // notBilgiSistemiDataSet5
            // 
            this.notBilgiSistemiDataSet5.DataSetName = "NotBilgiSistemiDataSet5";
            this.notBilgiSistemiDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnListele
            // 
            this.BtnListele.BackColor = System.Drawing.Color.PapayaWhip;
            this.BtnListele.Location = new System.Drawing.Point(295, 24);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(91, 36);
            this.BtnListele.TabIndex = 4;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = false;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackColor = System.Drawing.Color.PapayaWhip;
            this.BtnKaydet.Location = new System.Drawing.Point(295, 66);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(91, 36);
            this.BtnKaydet.TabIndex = 5;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = false;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.Color.PapayaWhip;
            this.BtnGuncelle.Location = new System.Drawing.Point(295, 108);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(91, 36);
            this.BtnGuncelle.TabIndex = 6;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.PapayaWhip;
            this.BtnSil.Location = new System.Drawing.Point(295, 149);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(91, 36);
            this.BtnSil.TabIndex = 7;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGeri
            // 
            this.BtnGeri.BackColor = System.Drawing.Color.PapayaWhip;
            this.BtnGeri.Location = new System.Drawing.Point(295, 191);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(91, 36);
            this.BtnGeri.TabIndex = 8;
            this.BtnGeri.Text = "Geri Dön";
            this.BtnGeri.UseVisualStyleBackColor = false;
            this.BtnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Duyuru ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Duyuru Tarih:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Duyuru Metni:";
            // 
            // tblDuyuruTableAdapter
            // 
            this.tblDuyuruTableAdapter.ClearBeforeFill = true;
            // 
            // FrmDuyurularOgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(970, 246);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGeri);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.RchTxtDuyuru);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.MskTarih);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDuyurularOgr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duyuru Sayfası";
            this.Load += new System.EventHandler(this.FrmDuyurularOgr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDuyuruBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notBilgiSistemiDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox MskTarih;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.RichTextBox RchTxtDuyuru;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGeri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private NotBilgiSistemiDataSet5 notBilgiSistemiDataSet5;
        private System.Windows.Forms.BindingSource tblDuyuruBindingSource;
        private NotBilgiSistemiDataSet5TableAdapters.TblDuyuruTableAdapter tblDuyuruTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duyuruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duyuruTarihDataGridViewTextBoxColumn;
    }
}