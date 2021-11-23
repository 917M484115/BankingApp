using BankingApp.Domain.Common;
using BankingApp.Data.Investing;
namespace BankingApp.Domain.Investing
{
    public sealed class Crypto : NamedEntity<CryptoData>
    {
        public Crypto(CryptoData d) : base(d){ }
        public double Price => Data?.Price?? double.NaN;
        public string Blockchain => Data?.Blockchain?? Unspecified;
        public string Ticker => Data?.Ticker?? Unspecified;
    }
}
