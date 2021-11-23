using BankingApp.Domain.Common;
using BankingApp.Data.Investing;
namespace BankingApp.Domain.Investing
{
    public sealed class Stock : NamedEntity<StockData>  
    {
        public Stock(StockData d) : base(d) { }
        public string Country => Data?.Country?? Unspecified;
        public double Price => Data?.Price?? double.NaN;
        public string Ticker => Data?.Ticker?? Unspecified;
    }
}
