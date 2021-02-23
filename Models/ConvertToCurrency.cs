using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParsingOfCurrencyRates.Models
{
	public class ConvertToCurrency
	{
		public decimal USD { get; set; }
		public decimal ConvertToUSD(decimal priceRUB) => priceRUB / USD;

		public decimal EUR { get; set; }
		public decimal ConvertToEUR(decimal priceRUB) => priceRUB / EUR;

		public decimal DKK { get; set; }
		public decimal ConvertToDKK(decimal priceRUB) => priceRUB / (DKK / 10); //такие данные от ЦБ на 19.02.2021 по номиналу датских крон

		public decimal JPY { get; set; }
		public decimal ConvertToJPY(decimal priceRUB) => priceRUB / (JPY / 100); //та же история, что и с датскими кронами
	}
}
