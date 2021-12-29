using BankingApp.Aids.Methods;
using BankingApp.Data.Investing;
using BankingApp.Domain.Investing.Repositories;
using BankingApp.Domain.Common;
namespace BankingApp.Domain.Investing
{
    public sealed class CryptoPortfolioItem : UniqueEntity<CryptoPortfolioItemData> 
    {
        public CryptoPortfolioItem(CryptoPortfolioItemData d) : base(d) { }
        public int Quanity => Data?.Quantity ?? UnspecifiedInteger;
        public string CryptoID => Data?.CryptoID ?? Unspecified;
        public string CryptoPortfolioID => Data?.CryptoPortfolioID ?? Unspecified;
        public Crypto Crypto =>
            new GetFrom<ICryptoRepository, Crypto>()?.ById(CryptoID);
        public decimal UnitPrice => Crypto?.Price ?? UnspecifiedDecimal;
        public decimal TotalPrice
            => Safe.Run(() => UnitPrice * Quanity, UnspecifiedDecimal);
    }
}
