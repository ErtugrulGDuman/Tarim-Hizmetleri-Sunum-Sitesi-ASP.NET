namespace NotBilgiSistemi
{
    partial class FrmOgrenci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrenci));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vizeNotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalNotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblOgrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notBilgiSistemiDataSet = new NotBilgiSistemi.NotBilgiSistemiDataSet();
            this.tblOgrenciTableAdapter = new NotBilgiSistemi.NotBilgiSistemiDataSetTableAdapters.TblOgrenciTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOgrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notBilgiSistemiDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1038, 295);
            this.dataGridView1.TabIndex = 0;
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
            this.tblOgrenciBindingSource.DataSource = this.notBilgiSistemiDataSet;
            // 
            // notBilgiSistemiDataSet
            // 
            this.notBilgiSistemiDataSet.DataSetName = "NotBilgiSistemiDataSet";
            this.notBilgiSistemiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblOgrenciTableAdapter
            // 
            this.tblOgrenciTableAdapter.ClearBeforeFill = true;
            // 
            // FrmOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1038, 295);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOgrenci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Bilgi Ekranı";
            this.Load += new System.EventHandler(this.FrmOgrenci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOgrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notBilgiSistemiDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private NotBilgiSistemiDataSet notBilgiSistemiDataSet;
        private System.Windows.Forms.BindingSource tblOgrenciBindingSource;
        private NotBilgiSistemiDataSetTableAdapters.TblOgrenciTableAdapter tblOgrenciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vizeNotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalNotDataGridViewTextBoxColumn;
    }
}