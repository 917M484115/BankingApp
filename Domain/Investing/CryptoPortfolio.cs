using BankingApp.Data.Investing;
using BankingApp.Domain.Common;
using BankingApp.Domain.Investing.Repositories;
using BankingApp.Aids.Methods;
using BankingApp.Domain.Misc;
using BankingApp.Domain.Misc.Repositories;
namespace BankingApp.Domain.Investing
{
    public sealed class CryptoPortfolio : UniqueEntity<CryptoPortfolioData>
    {
        public CryptoPortfolio(CryptoPortfolioData d) : base(d) { }
        public int Units => Data?.Units ?? UnspecifiedInteger;
        public string CryptoID => Data?.CryptoID ?? Unspecified;
        public string CustomerID =>Data?.CustomerID?? Unspecified;
        public Customer Customer => new GetFrom<ICustomersRepository,Customer>().ById(CustomerID);
        public Crypto Crypto => new GetFrom<ICryptoRepository, Crypto>().ById(CryptoID);
        public string Ticker => Crypto?.Ticker ?? Unspecified;
        public string BlockChain => Crypto?.Blockchain ?? Unspecified;
        public decimal UnitPrice => Crypto?.Price ?? UnspecifiedDecimal;
        public decimal TotalPrice
            => Safe.Run(() => UnitPrice * Units, UnspecifiedDecimal);
    }
}
