using BankingApp.Facade.Common;
using System.ComponentModel;
namespace BankingApp.Facade.Investing
{
    public sealed class StocksPortfolioItemView: UniqueEntityView 
    {
        [DisplayName("Unit price")] public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        [DisplayName("Stock")] public string StockID { get; set; }
        [DisplayName("Stock")] public string StockName { get; set; }
        [DisplayName("Ticker")] public string Ticker { get;set;}
        [DisplayName("Country")] public string Country { get;set;}
        [DisplayName("Stocks Portfolio")] public string StocksPortfolioID { get; set; }
        [DisplayName("Total price")] public decimal TotalPrice { get; set; }
    }
}
