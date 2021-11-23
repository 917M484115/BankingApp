using BankingApp.Facade.Common;
namespace BankingApp.Facade.Investing
{
	public class CryptoView : NamedView 
	{
		public string Ticker { get;set;}
		public double Price { get;set;}
		public string Blockchain { get;set;}

    }
}
