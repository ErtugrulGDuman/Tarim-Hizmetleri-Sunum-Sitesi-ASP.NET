namespace HasanFinalDeneme4
{
    partial class Form1
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
            this.TxtListe = new System.Windows.Forms.TextBox();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.BtnCikar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BtnEngelle = new System.Windows.Forms.Button();
            this.BtnIzinver = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TxtListe
            // 
            this.TxtListe.Location = new System.Drawing.Point(24, 48);
            this.TxtListe.Name = "TxtListe";
            this.TxtListe.Size = new System.Drawing.Size(189, 34);
            this.TxtListe.TabIndex = 0;
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(24, 90);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(189, 55);
            this.BtnEkle.TabIndex = 1;
            this.BtnEkle.Text = "Listeye Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // BtnCikar
            // 
            this.BtnCikar.Location = new System.Drawing.Point(24, 154);
            this.BtnCikar.Name = "BtnCikar";
            this.BtnCikar.Size = new System.Drawing.Size(189, 55);
            this.BtnCikar.TabIndex = 2;
            this.BtnCikar.Text = "Listeden Çıkar";
            this.BtnCikar.UseVisualStyleBackColor = true;
            this.BtnCikar.Click += new System.EventHandler(this.BtnCikar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(234, 60);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(161, 149);
            this.listBox1.TabIndex = 3;
            // 
            // BtnEngelle
            // 
            this.BtnEngelle.Location = new System.Drawing.Point(424, 79);
            this.BtnEngelle.Name = "BtnEngelle";
            this.BtnEngelle.Size = new System.Drawing.Size(189, 55);
            this.BtnEngelle.TabIndex = 4;
            this.BtnEngelle.Text = "Engelle";
            this.BtnEngelle.UseVisualStyleBackColor = true;
            this.BtnEngelle.Click += new System.EventHandler(this.BtnEngelle_Click);
            // 
            // BtnIzinver
            // 
            this.BtnIzinver.Location = new System.Drawing.Point(424, 140);
            this.BtnIzinver.Name = "BtnIzinver";
            this.BtnIzinver.Size = new System.Drawing.Size(189, 55);
            this.BtnIzinver.TabIndex = 5;
            this.BtnIzinver.Text = "İzin ver";
            this.BtnIzinver.UseVisualStyleBackColor = true;
            this.BtnIzinver.Click += new System.EventHandler(this.BtnIzinver_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 29;
            this.listBox2.Location = new System.Drawing.Point(644, 60);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(161, 149);
            this.listBox2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 252);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.BtnIzinver);
            this.Controls.Add(this.BtnEngelle);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BtnCikar);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.TxtListe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtListe;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Button BtnCikar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BtnEngelle;
        private System.Windows.Forms.Button BtnIzinver;
        private System.Windows.Forms.ListBox listBox2;
    }
}

