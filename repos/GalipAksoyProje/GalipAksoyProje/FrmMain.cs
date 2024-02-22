using iTextSharp.text.pdf;
using iTextSharp.text;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Words.NET;

namespace GalipAksoyProje
{
	public partial class FrmMain : Form
	{
		public FrmMain()
		{
			InitializeComponent();
		}
		private void FrmMain_Load(object sender, EventArgs e)
		{
		
		}
		private void button1_Click(object sender, EventArgs e)
		{
			ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

			// Masaüstü yolunu al
			string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

			// Yeni klasör oluştur
			string folderPath = Path.Combine(desktopPath, "MyFiles");
			Directory.CreateDirectory(folderPath);

			// Excel dosyasını oluştur
			using (var package = new ExcelPackage())
			{
				var worksheet = package.Workbook.Worksheets.Add("Sheet1");

				// Başlık satırını ekle
				worksheet.Cells["A1"].Value = "Ad";
				worksheet.Cells["B1"].Value = "Soyad";
				worksheet.Cells["C1"].Value = "Yaş";

				// Veri satırlarını ekle
				worksheet.Cells["A2"].Value = "Ahmet";
				worksheet.Cells["B2"].Value = "Yılmaz";
				worksheet.Cells["C2"].Value = 30;

				worksheet.Cells["A3"].Value = "Ayşe";
				worksheet.Cells["B3"].Value = "Kara";
				worksheet.Cells["C3"].Value = 25;

				// Excel dosyasını kaydet
				string excelFilePath = Path.Combine(folderPath, "output1.xlsx");
				package.SaveAs(new FileInfo(excelFilePath));

				MessageBox.Show("Excel dosyası oluşturuldu: " + excelFilePath);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			// Masaüstü yolunu al
			string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

			// Yeni klasör oluştur
			string folderPath = Path.Combine(desktopPath, "MyFiles");
			Directory.CreateDirectory(folderPath);

			// PDF dosyasını oluştur
			string pdfFilePath = Path.Combine(desktopPath, "output.pdf");
			using (FileStream fs = new FileStream(pdfFilePath, FileMode.Create))
			{
				Document doc = new Document();
				PdfWriter writer = PdfWriter.GetInstance(doc, fs);

				doc.Open();
				doc.Add(new Paragraph("Ad: Ahmet, Soyad: Yılmaz, Yaş: 30"));
				doc.Add(new Paragraph("Ad: Ayşe, Soyad: Kara, Yaş: 25"));
				doc.Close();
			}

			MessageBox.Show("PDF dosyası oluşturuldu: " + pdfFilePath);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			// Masaüstü yolunu al
			string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

			// Yeni klasör oluştur
			string folderPath = Path.Combine(desktopPath, "MyFiles");
			Directory.CreateDirectory(folderPath);

			// Word belgesini oluştur
			string wordFilePath = Path.Combine(desktopPath, "output.docx");
			using (DocX document = DocX.Create(wordFilePath))
			{
				document.InsertParagraph("Ad: Ahmet, Soyad: Yılmaz, Yaş: 30");
				document.InsertParagraph("Ad: Ayşe, Soyad: Kara, Yaş: 25");

				document.Save();
			}

			MessageBox.Show("Word belgesi oluşturuldu: " + wordFilePath);
		}
	}
}
