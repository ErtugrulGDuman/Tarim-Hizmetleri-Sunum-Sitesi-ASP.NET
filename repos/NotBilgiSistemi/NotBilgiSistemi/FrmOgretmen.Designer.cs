namespace NotBilgiSistemi
{
    partial class FrmOgretmen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgretmen));
            this.TxtOgrNo = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtFinalN = new System.Windows.Forms.TextBox();
            this.TxtVizeN = new System.Windows.Forms.TextBox();
            this.TxtSehir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnListele = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnDuyuru = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vizeNotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalNotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblOgrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notBilgiSistemiDataSet1 = new NotBilgiSistemi.NotBilgiSistemiDataSet1();
            this.tblOgrenciTableAdapter = new NotBilgiSistemi.NotBilgiSistemiDataSet1TableAdapters.TblOgrenciTableAdapter();
            this.BtnGiris = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOgrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notBilgiSistemiDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtOgrNo
            // 
            this.TxtOgrNo.BackColor = System.Drawing.Color.PapayaWhip;
            this.TxtOgrNo.Location = new System.Drawing.Point(101, 29);
            this.TxtOgrNo.Name = "TxtOgrNo";
            this.TxtOgrNo.Size = new System.Drawing.Size(100, 22);
            this.TxtOgrNo.TabIndex = 0;
            // 
            // TxtAd
            // 
            this.TxtAd.BackColor = System.Drawing.Color.PapayaWhip;
            this.TxtAd.Location = new System.Drawing.Point(101, 57);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(100, 22);
            this.TxtAd.TabIndex = 1;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.BackColor = System.Drawing.Color.PapayaWhip;
            this.TxtSoyad.Location = new System.Drawing.Point(101, 85);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(100, 22);
            this.TxtSoyad.TabIndex = 2;
            // 
            // TxtFinalN
            // 
            this.TxtFinalN.BackColor = System.Drawing.Color.PapayaWhip;
            this.TxtFinalN.Location = new System.Drawing.Point(101, 169);
            this.TxtFinalN.Name = "TxtFinalN";
            this.TxtFinalN.Size = new System.Drawing.Size(100, 22);
            this.TxtFinalN.TabIndex = 5;
            // 
            // TxtVizeN
            // 
            this.TxtVizeN.BackColor = System.Drawing.Color.PapayaWhip;
            this.TxtVizeN.Location = new System.Drawing.Point(101, 141);
            this.TxtVizeN.Name = "TxtVizeN";
            this.TxtVizeN.Size = new System.Drawing.Size(100, 22);
            this.TxtVizeN.TabIndex = 4;
            // 
            // TxtSehir
            // 
            this.TxtSehir.BackColor = System.Drawing.Color.PapayaWhip;
            this.TxtSehir.Location = new System.Drawing.Point(101, 113);
            this.TxtSehir.Name = "TxtSehir";
            this.TxtSehir.Size = new System.Drawing.Size(100, 22);
            this.TxtSehir.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Öğrenci No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Şehir:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Vize Notu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Final Notu:";
            // 
            // BtnListele
            // 
            this.BtnListele.BackColor = System.Drawing.Color.PapayaWhip;
            this.BtnListele.Location = new System.Drawing.Point(225, 23);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(102, 23);
            this.BtnListele.TabIndex = 12;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = false;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackColor = System.Drawing.Color.PapayaWhip;
            this.BtnKaydet.Location = new System.Drawing.Point(225, 52);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(102, 23);
            this.BtnKaydet.TabIndex = 13;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = false;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.Color.PapayaWhip;
            this.BtnGuncelle.Location = new System.Drawing.Point(225, 110);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(102, 23);
            this.BtnGuncelle.TabIndex = 15;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.PapayaWhip;
            this.BtnSil.Location = new System.Drawing.Point(225, 81);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(102, 23);
            this.BtnSil.TabIndex = 14;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnDuyuru
            // 
            this.BtnDuyuru.BackColor = System.Drawing.Color.PapayaWhip;
            this.BtnDuyuru.Location = new System.Drawing.Point(225, 139);
            this.BtnDuyuru.Name = "BtnDuyuru";
            this.BtnDuyuru.Size = new System.Drawing.Size(102, 23);
            this.BtnDuyuru.TabIndex = 16;
            this.BtnDuyuru.Text = "Duyurular";
            this.BtnDuyuru.UseVisualStyleBackColor = false;
            this.BtnDuyuru.Click += new System.EventHandler(this.BtnDuyuru_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrNoDataGridViewTextBoxColumn,
            this.ogrAdDataGridViewTextBoxColumn,
            this.ogrSoyadDataGridViewTextBoxColumn,
            this.ogrSehirDataGridViewTextBoxColumn,
            this.vizeNotDataGridViewTextBoxColumn,
            this.finalNotDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblOgrenciBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(333, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(902, 194);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ogrNoDataGridViewTextBoxColumn
            // 
            this.ogrNoDataGridViewTextBoxColumn.DataPropertyName = "OgrNo";
            this.ogrNoDataGridViewTextBoxColumn.HeaderText = "OgrNo";
            this.ogrNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrNoDataGridViewTextBoxColumn.Name = "ogrNoDataGridViewTextBoxColumn";
            this.ogrNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.ogrNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrAdDataGridViewTextBoxColumn
            // 
            this.ogrAdDataGridViewTextBoxColumn.DataPropertyName = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.HeaderText = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrAdDataGridViewTextBoxColumn.Name = "ogrAdDataGridViewTextBoxColumn";
            this.ogrAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrSoyadDataGridViewTextBoxColumn
            // 
            this.ogrSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.HeaderText = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrSoyadDataGridViewTextBoxColumn.Name = "ogrSoyadDataGridViewTextBoxColumn";
            this.ogrSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrSehirDataGridViewTextBoxColumn
            // 
            this.ogrSehirDataGridViewTextBoxColumn.DataPropertyName = "OgrSehir";
            this.ogrSehirDataGridViewTextBoxColumn.HeaderText = "OgrSehir";
            this.ogrSehirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrSehirDataGridViewTextBoxColumn.Name = "ogrSehirDataGridViewTextBoxColumn";
            this.ogrSehirDataGridViewTextBoxColumn.Width = 125;
            // 
            // vizeNotDataGridViewTextBoxColumn
            // 
            this.vizeNotDataGridViewTextBoxColumn.DataPropertyName = "VizeNot";
            this.vizeNotDataGridViewTextBoxColumn.HeaderText = "VizeNot";
            this.vizeNotDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vizeNotDataGridViewTextBoxColumn.Name = "vizeNotDataGridViewTextBoxColumn";
            this.vizeNotDataGridViewTextBoxColumn.Width = 125;
            // 
            // finalNotDataGridViewTextBoxColumn
            // 
            this.finalNotDataGridViewTextBoxColumn.DataPropertyName = "FinalNot";
            this.finalNotDataGridViewTextBoxColumn.HeaderText = "FinalNot";
            this.finalNotDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.finalNotDataGridViewTextBoxColumn.Name = "finalNotDataGridViewTextBoxColumn";
            this.finalNotDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblOgrenciBindingSource
            // 
            this.tblOgrenciBindingSource.DataMember = "TblOgrenci";
            this.tblOgrenciBindingSource.DataSource = this.notBilgiSistemiDataSet1;
            // 
            // notBilgiSistemiDataSet1
            // 
            this.notBilgiSistemiDataSet1.DataSetName = "NotBilgiSistemiDataSet1";
            this.notBilgiSistemiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblOgrenciTableAdapter
            // 
            this.tblOgrenciTableAdapter.ClearBeforeFill = true;
            // 
            // BtnGiris
            // 
            this.BtnGiris.BackColor = System.Drawing.Color.PapayaWhip;
            this.BtnGiris.Location = new System.Drawing.Point(225, 168);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(102, 23);
            this.BtnGiris.TabIndex = 18;
            this.BtnGiris.Text = "Giriş";
            this.BtnGiris.UseVisualStyleBackColor = false;
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // FrmOgretmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1240, 205);
            this.Controls.Add(this.BtnGiris);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnDuyuru);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtFinalN);
            this.Controls.Add(this.TxtVizeN);
            this.Controls.Add(this.TxtSehir);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.TxtOgrNo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOgretmen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğretmen Sayfası";
            this.Load += new System.EventHandler(this.FrmOgretmen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOgrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notBilgiSistemiDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtOgrNo;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtFinalN;
        private System.Windows.Forms.TextBox TxtVizeN;
        private System.Windows.Forms.TextBox TxtSehir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnDuyuru;
        private System.Windows.Forms.DataGridView dataGridView1;
        private NotBilgiSistemiDataSet1 notBilgiSistemiDataSet1;
        private System.Windows.Forms.BindingSource tblOgrenciBindingSource;
        private NotBilgiSistemiDataSet1TableAdapters.TblOgrenciTableAdapter tblOgrenciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vizeNotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalNotDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BtnGiris;
    }
}