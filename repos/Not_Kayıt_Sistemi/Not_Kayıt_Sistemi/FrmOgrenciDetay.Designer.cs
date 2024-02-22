namespace Not_Kayıt_Sistemi
{
	partial class FrmOgrenciDetay
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
			label1 = new Label();
			LblAdSoyad = new Label();
			LblNumara = new Label();
			label4 = new Label();
			LblSınav1 = new Label();
			label6 = new Label();
			LblSınav2 = new Label();
			label8 = new Label();
			LblSınav3 = new Label();
			label10 = new Label();
			LblDurum = new Label();
			label12 = new Label();
			LblOrtalama = new Label();
			label14 = new Label();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(75, 50);
			label1.Name = "label1";
			label1.Size = new Size(106, 28);
			label1.TabIndex = 0;
			label1.Text = "Ad Soyad: ";
			// 
			// LblAdSoyad
			// 
			LblAdSoyad.AutoSize = true;
			LblAdSoyad.Location = new Point(186, 50);
			LblAdSoyad.Name = "LblAdSoyad";
			LblAdSoyad.Size = new Size(59, 28);
			LblAdSoyad.TabIndex = 1;
			LblAdSoyad.Text = "NULL";
			// 
			// LblNumara
			// 
			LblNumara.AutoSize = true;
			LblNumara.Location = new Point(186, 97);
			LblNumara.Name = "LblNumara";
			LblNumara.Size = new Size(56, 28);
			LblNumara.TabIndex = 3;
			LblNumara.Text = "0000";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(75, 97);
			label4.Name = "label4";
			label4.Size = new Size(91, 28);
			label4.TabIndex = 2;
			label4.Text = "Numara: ";
			// 
			// LblSınav1
			// 
			LblSınav1.AutoSize = true;
			LblSınav1.Location = new Point(186, 143);
			LblSınav1.Name = "LblSınav1";
			LblSınav1.Size = new Size(34, 28);
			LblSınav1.TabIndex = 5;
			LblSınav1.Text = "00";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(75, 143);
			label6.Name = "label6";
			label6.Size = new Size(79, 28);
			label6.TabIndex = 4;
			label6.Text = "Sınav 1:";
			// 
			// LblSınav2
			// 
			LblSınav2.AutoSize = true;
			LblSınav2.Location = new Point(186, 189);
			LblSınav2.Name = "LblSınav2";
			LblSınav2.Size = new Size(34, 28);
			LblSınav2.TabIndex = 7;
			LblSınav2.Text = "00";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(75, 189);
			label8.Name = "label8";
			label8.Size = new Size(79, 28);
			label8.TabIndex = 6;
			label8.Text = "Sınav 2:";
			// 
			// LblSınav3
			// 
			LblSınav3.AutoSize = true;
			LblSınav3.Location = new Point(186, 232);
			LblSınav3.Name = "LblSınav3";
			LblSınav3.Size = new Size(34, 28);
			LblSınav3.TabIndex = 9;
			LblSınav3.Text = "00";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(75, 232);
			label10.Name = "label10";
			label10.Size = new Size(79, 28);
			label10.TabIndex = 8;
			label10.Text = "Sınav 3:";
			// 
			// LblDurum
			// 
			LblDurum.AutoSize = true;
			LblDurum.Location = new Point(186, 319);
			LblDurum.Name = "LblDurum";
			LblDurum.Size = new Size(59, 28);
			LblDurum.TabIndex = 13;
			LblDurum.Text = "NULL";
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Location = new Point(75, 319);
			label12.Name = "label12";
			label12.Size = new Size(81, 28);
			label12.TabIndex = 12;
			label12.Text = "Durum: ";
			label12.Click += label12_Click;
			// 
			// LblOrtalama
			// 
			LblOrtalama.AutoSize = true;
			LblOrtalama.Location = new Point(186, 275);
			LblOrtalama.Name = "LblOrtalama";
			LblOrtalama.Size = new Size(34, 28);
			LblOrtalama.TabIndex = 11;
			LblOrtalama.Text = "00";
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Location = new Point(75, 275);
			label14.Name = "label14";
			label14.Size = new Size(102, 28);
			label14.TabIndex = 10;
			label14.Text = "Ortalama: ";
			// 
			// FrmOgrenciDetay
			// 
			AutoScaleDimensions = new SizeF(11F, 28F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.LightSteelBlue;
			ClientSize = new Size(335, 402);
			Controls.Add(LblDurum);
			Controls.Add(label12);
			Controls.Add(LblOrtalama);
			Controls.Add(label14);
			Controls.Add(LblSınav3);
			Controls.Add(label10);
			Controls.Add(LblSınav2);
			Controls.Add(label8);
			Controls.Add(LblSınav1);
			Controls.Add(label6);
			Controls.Add(LblNumara);
			Controls.Add(label4);
			Controls.Add(LblAdSoyad);
			Controls.Add(label1);
			Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(4);
			Name = "FrmOgrenciDetay";
			Text = "Öğrenci Not Kayıt Sistemi";
			Load += FrmOgrenciDetay_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label LblAdSoyad;
		private Label LblNumara;
		private Label label4;
		private Label LblSınav1;
		private Label label6;
		private Label LblSınav2;
		private Label label8;
		private Label LblSınav3;
		private Label label10;
		private Label LblDurum;
		private Label label12;
		private Label LblOrtalama;
		private Label label14;
	}
}