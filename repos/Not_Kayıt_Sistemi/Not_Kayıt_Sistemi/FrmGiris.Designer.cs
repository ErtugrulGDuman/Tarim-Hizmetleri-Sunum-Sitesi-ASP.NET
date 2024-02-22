namespace Not_Kayıt_Sistemi
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
			button1 = new Button();
			maskedTextBox1 = new MaskedTextBox();
			label1 = new Label();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(444, 62);
			button1.Margin = new Padding(4);
			button1.Name = "button1";
			button1.Size = new Size(166, 38);
			button1.TabIndex = 0;
			button1.Text = "GİRİŞ YAP";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// maskedTextBox1
			// 
			maskedTextBox1.Location = new Point(252, 62);
			maskedTextBox1.Margin = new Padding(4);
			maskedTextBox1.Mask = "0000";
			maskedTextBox1.Name = "maskedTextBox1";
			maskedTextBox1.Size = new Size(170, 34);
			maskedTextBox1.TabIndex = 3;
			maskedTextBox1.ValidatingType = typeof(int);
			maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
			maskedTextBox1.TextChanged += maskedTextBox1_TextChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(50, 62);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(194, 28);
			label1.TabIndex = 2;
			label1.Text = "ÖĞRENCİ NUMARA: ";
			// 
			// FrmGiris
			// 
			AutoScaleDimensions = new SizeF(11F, 28F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.LightSteelBlue;
			ClientSize = new Size(689, 165);
			Controls.Add(maskedTextBox1);
			Controls.Add(label1);
			Controls.Add(button1);
			Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(4);
			Name = "FrmGiris";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Öğrenci Not Kayıt Sistemi";
			Load += FrmGiris_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
		private MaskedTextBox maskedTextBox1;
		private Label label1;
	}
}