using DovizCekmeXml1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DovizCekmeXml1.Classes
{
	public class SaleOperation
	{
		public void CustomerSaleOperationAlis()
		{
			DovizCekmeXmlEntities db = new DovizCekmeXmlEntities();

			var values = db.TblOperation.Where(x => x.OperationType == "alış").ToList();
			foreach (var item in values)
			{
				Console.WriteLine("ID: " + item.ID + "Müşteri: " + item.CustomerName + " " + item.CustomerSurName + "Döviz: " +
					item.TblCurrency.CurrencyName + "İşlem Türü: " + item.OperationType + "Kur birim tutarı: " +
						item.CurrentValue + "Alınan tutar: " + item.Amount + "Toplam tutar: " + item.TotalPrice);
			}
		}
		public void CustomerSaleOperationSatis()
		{
			DovizCekmeXmlEntities db = new DovizCekmeXmlEntities();

			var values = db.TblOperation.Where(x => x.OperationType == "Satis").ToList();
			foreach (var item in values)
			{
				Console.WriteLine("ID: " + item.ID + "Müşteri: " + item.CustomerName + " " + item.CustomerSurName + "Döviz: " +
					item.TblCurrency.CurrencyName + "İşlem Türü: " + item.OperationType + "Kur birim tutarı: " +
						item.CurrentValue + "Alınan tutar: " + item.Amount + "Toplam tutar: " + item.TotalPrice);
			}
		}
	}
}
