namespace NotBilgiSistemi
{
    partial class FrmDuyuru
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDuyuru));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duyuruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duyuruTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDuyuruBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notBilgiSistemiDataSet2 = new NotBilgiSistemi.NotBilgiSistemiDataSet2();
            this.BtnGeri = new System.Windows.Forms.Button();
            this.tblDuyuruTableAdapter = new NotBilgiSistemi.NotBilgiSistemiDataSet2TableAdapters.TblDuyuruTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDuyuruBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notBilgiSistemiDataSet2)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(121, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(667, 214);
            this.dataGridView1.TabIndex = 0;
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
            this.tblDuyuruBindingSource.DataSource = this.notBilgiSistemiDataSet2;
            // 
            // notBilgiSistemiDataSet2
            // 
            this.notBilgiSistemiDataSet2.DataSetName = "NotBilgiSistemiDataSet2";
            this.notBilgiSistemiDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnGeri
            // 
            this.BtnGeri.BackColor = System.Drawing.Color.PapayaWhip;
            this.BtnGeri.Location = new System.Drawing.Point(12, 12);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(103, 214);
            this.BtnGeri.TabIndex = 1;
            this.BtnGeri.Text = "Anasayfaya Geri Dön";
            this.BtnGeri.UseVisualStyleBackColor = false;
            this.BtnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // tblDuyuruTableAdapter
            // 
            this.tblDuyuruTableAdapter.ClearBeforeFill = true;
            // 
            // FrmDuyuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 240);
            this.Controls.Add(this.BtnGeri);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDuyuru";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duyurular Sayfası";
            this.Load += new System.EventHandler(this.FrmDuyuru_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDuyuruBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notBilgiSistemiDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnGeri;
        private NotBilgiSistemiDataSet2 notBilgiSistemiDataSet2;
        private System.Windows.Forms.BindingSource tblDuyuruBindingSource;
        private NotBilgiSistemiDataSet2TableAdapters.TblDuyuruTableAdapter tblDuyuruTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duyuruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duyuruTarihDataGridViewTextBoxColumn;
    }
}