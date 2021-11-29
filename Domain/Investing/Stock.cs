using BankingApp.Domain.Common;
using BankingApp.Data.Investing;
namespace BankingApp.Domain.Investing
{
    public sealed class Stock : VirtualAssetEntity<StockData>  
    {
        public Stock(StockData d) : base(d) { }
        public string Country => Data?.Country?? Unspecified;
    }
}
