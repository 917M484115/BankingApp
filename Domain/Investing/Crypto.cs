using BankingApp.Domain.Common;
using BankingApp.Data.Investing;
namespace BankingApp.Domain.Investing
{
    public sealed class Crypto : VirtualAssetEntity<CryptoData>
    {
        public Crypto(CryptoData d) : base(d){ }
        public string Blockchain => Data?.Blockchain?? Unspecified;
        
    }
}
