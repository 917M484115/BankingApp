using BankingApp.Aids.Methods;
using BankingApp.Data.Investing;
using BankingApp.Domain.Investing.Repositories;
using BankingApp.Domain.Common;
namespace BankingApp.Domain.Investing
{
    public sealed class CryptoBasketItem : UniqueEntity<CryptoBasketItemData> 
    {
        public CryptoBasketItem(CryptoBasketItemData d) : base(d) { }
        public int Quantity => Data?.Quantity ?? UnspecifiedInteger;
        public string CryptoID => Data?.CryptoID ?? Unspecified;
        public string CryptoBasketID => Data?.CryptoBasketID ?? Unspecified;
        public Crypto Crypto =>
            new GetFrom<ICryptoRepository, Crypto>()?.ById(CryptoID);
        public string Ticker => Crypto?.Ticker ?? Unspecified;
        public string BlockChain => Crypto?.BlockChainID ?? Unspecified;
        public decimal UnitPrice => Crypto?.Price ?? UnspecifiedDecimal;
        public decimal TotalPrice
            => Safe.Run(() => UnitPrice * Quantity, UnspecifiedDecimal);
    }
}
