using DovizCekmeXml1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DovizCekmeXml1.Classes
{
	public class Sale
	{
		DovizCekmeXmlEntities db = new DovizCekmeXmlEntities();

		public void MakeSale(string customerName, string customerSurname, int curencyCode, string operationType, decimal currentValue, decimal amount, decimal totalPrice)
		{
			TblOperation tblOperation = new TblOperation();
			tblOperation.CustomerName = customerName;
			tblOperation.CustomerSurName = customerSurname;
			tblOperation.CurrencyID = curencyCode;
			tblOperation.OperationType = operationType;
			tblOperation.CurrentValue = currentValue;
			tblOperation.Amount = amount;
			tblOperation.TotalPrice = totalPrice;
			tblOperation.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
			db.TblOperation.Add(tblOperation);
			db.SaveChanges();
			Console.WriteLine("Satış işlemi başarılı bir şekilde gerçekleşti");
		}
	}
}
