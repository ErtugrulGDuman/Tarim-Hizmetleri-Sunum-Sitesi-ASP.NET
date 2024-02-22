using DovizCekmeXml1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DovizCekmeXml1.Classes
{
	public class GetCurrency
	{
		DovizCekmeXmlEntities db = new DovizCekmeXmlEntities();

		public void SaveCurrencyDollar()
		{
			string today = "https://www.tcmb.gov.tr/kurlar/today.xml";
			var XmlDoc = new XmlDocument();
			XmlDoc.Load(today);
			string DolarAlis = XmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod = 'USD']/BanknoteBuying").InnerXml;
			DolarAlis = DolarAlis.Replace(".", ",");
			string DolarSatis = XmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod = 'USD']/BanknoteSelling").InnerXml;
			DolarSatis = DolarSatis.Replace(".", ",");
			TblCurrencyValue t = new TblCurrencyValue();
			t.CurrencyID = 1;
			t.CurrencyBuying = decimal.Parse(DolarAlis);
			t.CurrencySelling = decimal.Parse(DolarSatis);
			t.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
			db.TblCurrencyValue.Add(t);
			db.SaveChanges();
		}

		public void SaveCurrencyEuro()
		{
			string today = "https://www.tcmb.gov.tr/kurlar/today.xml";
			var XmlDoc = new XmlDocument();
			XmlDoc.Load(today);
			string EuroAlis = XmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod = 'EUR']/BanknoteBuying").InnerXml;
			EuroAlis = EuroAlis.Replace(".", ",");
			string EuroSatis = XmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod = 'EUR']/BanknoteSelling").InnerXml;
			EuroSatis = EuroSatis.Replace(".", ",");
			TblCurrencyValue t = new TblCurrencyValue();
			t.CurrencyID = 1;
			t.CurrencyBuying = decimal.Parse(EuroAlis);
			t.CurrencySelling = decimal.Parse(EuroSatis);
			t.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
			db.TblCurrencyValue.Add(t);
			db.SaveChanges();
		}

		public void SaveCurrencyPound()
		{
			string today = "https://www.tcmb.gov.tr/kurlar/today.xml";
			var XmlDoc = new XmlDocument();
			XmlDoc.Load(today);
			string PoundAlis = XmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod = 'GBP']/BanknoteBuying").InnerXml;
			PoundAlis = PoundAlis.Replace(".", ",");
			string PoundSatis = XmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod = 'GBP']/BanknoteSelling").InnerXml;
			PoundSatis = PoundSatis.Replace(".", ",");
			TblCurrencyValue t = new TblCurrencyValue();
			t.CurrencyID = 1;
			t.CurrencyBuying = decimal.Parse(PoundAlis);
			t.CurrencySelling = decimal.Parse(PoundSatis);
			t.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
			db.TblCurrencyValue.Add(t);
			db.SaveChanges();
		}
	}
}
