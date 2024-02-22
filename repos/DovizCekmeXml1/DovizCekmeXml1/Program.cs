using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using DovizCekmeXml1.Classes;
using DovizCekmeXml1.Model;

namespace DovizCekmeXml1
{
	public class Program
	{
		static void Main(string[] args)
		{
			DovizCekmeXmlEntities db = new DovizCekmeXmlEntities();
			GetCurrency getCurrency = new GetCurrency();
			Sale getSale = new Sale();


			void CurrencyList()
			{
				Console.WriteLine();
				Console.WriteLine("Döviz Listesi");
				Console.WriteLine();
				var values = db.TblCurrency.ToList();
				foreach (var item in values)
				{
					Console.WriteLine(item.ID + " " + item.CurrencyName + " " + item.CurrencySymbol);
				}
			}
			void CurrentCurrency()
			{
				Console.WriteLine();
				Console.WriteLine("Güncel Kur Listesi");
				Console.WriteLine();
				var values = db.TblCurrencyValue.ToList();
				foreach (var item in values)
				{
					Console.WriteLine("Döviz : " + item.TblCurrency.CurrencyName + " Alış" + item.CurrencyBuying + " Satış" + item.CurrencySelling);
				}
			}

			void GetCurrencyClass()
			{
				getCurrency.SaveCurrencyDollar();
				getCurrency.SaveCurrencyEuro();
				getCurrency.SaveCurrencyPound();
			}

			Console.WriteLine("Döviz işlemlerine hoş geldiniz");
			Console.WriteLine();
			Console.WriteLine("Mevcut kullanıcı: Admin"+"   Tarih:"+DateTime.Now.ToShortDateString());
			Console.WriteLine();
			Console.WriteLine("Yapmak istediğiniz işlemi seçiniz");
			Console.WriteLine();
			Console.WriteLine("1-Döviz Listesi");
			Console.WriteLine("2-Güncel Kurlar");
			Console.WriteLine("3-Satış Yap");
			Console.WriteLine("4-Müşterilere yapılan satış hareketleri");
			Console.WriteLine("5-Müşterilerden alınan satış hareketleri");
			Console.WriteLine("6-Kurları Veri Tabanına Kaydet");
			Console.WriteLine("7-Yardım");
			Console.WriteLine("8-Çıkış Yap");
			Console.WriteLine();
			Console.Write("İşlem Numarası: ");


			string choose;
			choose = Console.ReadLine();
			if(choose == "1" || choose == "01")
			{
				CurrencyList();
			}
			if (choose == "2" || choose == "02")
			{
				CurrencyList();
			}
			if (choose == "3" || choose == "03")
			{
				Console.WriteLine();
				Console.Write("Müşteri Adı ");
				string customerName = Console.ReadLine();
				Console.Write("Müşteri Soyadı ");
				string customerSurName = Console.ReadLine();
				Console.Write("Döviz Kodu ");
				int currencyCode = int.Parse(Console.ReadLine());
				Console.Write("İşlem Türü ");
				string operationType = Console.ReadLine();
				Console.Write("Güncel Kur Değeri ");
				decimal currentValue = decimal.Parse(Console.ReadLine());
				Console.Write("Alınacak Tutar ");
				decimal amount = decimal.Parse(Console.ReadLine());
				Console.Write("Toplam Ücret ");
				decimal totalAmount = decimal.Parse(Console.ReadLine());

				getSale.MakeSale(customerName, customerSurName, currencyCode, operationType, currentValue, amount, totalAmount);
			}
			if (choose == "4" || choose == "04")
			{
				SaleOperation saleOperation = new SaleOperation();
				saleOperation.CustomerSaleOperationAlis();
			}
			if (choose == "5" || choose == "05")
			{
				SaleOperation saleOperation = new SaleOperation();
				saleOperation.CustomerSaleOperationSatis();
			}
			if (choose == "6" || choose == "06")
			{
				GetCurrencyClass();
				Console.WriteLine("Dövizler başarılı bir şekilde veri tabanına kaydedildi");
			}
			if (choose == "7" || choose == "07")
			{
				Console.WriteLine("Tüm sorularınız için mail@mail.com adresinden bize ulaşabilirsiniz");
			}
			if (choose == "8" || choose == "08")
			{
				Environment.Exit(0);
			}
				Console.ReadLine();
		}
	}
}
