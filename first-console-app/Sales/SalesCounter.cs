using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_console_app.Sales
{
	public class SalesCounter
	{
		private IEnumerable<Sale> _sales;

		public SalesCounter(string filePath)
		{
			_sales = ReadSales(filePath);
		}
		private static IEnumerable<Sale> ReadSales(string filepath)
		{
			var sales = new List<Sale>();
			var lines = File.ReadLines(filepath);
			
			foreach(var line in lines)
			{
				var items = line.Split(',');
				var sale = new Sale
				{
					ShopName = items[0],
					ProductCategory = items[1],
					Amount = int.Parse(items[2])
				};
				sales.Add(sale);

			}
			return sales;
		}

		public IDictionary<string, int> GetPerStoreSales()
		{
			var dict = new Dictionary<string, int>();
			foreach(var sale in _sales)
			{
				if (dict.ContainsKey(sale.ShopName)) dict[sale.ShopName] += sale.Amount;
				else dict[sale.ShopName] = sale.Amount;
			}
			return dict;
		}
	}
}
