using BankingApp.Aids.Methods;
using BankingApp.Data.Investing;
using BankingApp.Domain.Investing.Repositories;
using BankingApp.Domain.Common;
namespace BankingApp.Domain.Investing
{
    public sealed class StocksPortfolioItem : UniqueEntity<StocksPortfolioItemData> 
    {
        public StocksPortfolioItem(StocksPortfolioItemData d): base(d) { }
        public int Quanity => Data?.Quantity ?? UnspecifiedInteger;
        public string StockID => Data?.StockID ?? Unspecified;
        public string StocksPortfolioID => Data?.StocksPortfolioID ?? Unspecified;
        public Stock Stock =>
            new GetFrom<IStockRepository,Stock>()?.ById(StockID);
        public decimal UnitPrice => Stock?.Price ?? UnspecifiedDecimal;
        public decimal TotalPrice 
            => Safe.Run(()=> UnitPrice*Quanity, UnspecifiedDecimal);
    }
}
