using BankingApp.Facade.Common;
namespace BankingApp.Facade.Investing
{
	public class StockView : NamedView
	{
		public string Ticker { get; set; }
		public double Price { get; set; }
		public string Country { get; set; }
	}
}
