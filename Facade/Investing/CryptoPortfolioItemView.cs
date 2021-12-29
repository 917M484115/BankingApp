using BankingApp.Facade.Common;
using System.ComponentModel;

namespace BankingApp.Facade.Investing
{
    public sealed class CryptoPortfolioItemView : UniqueEntityView
    {
        [DisplayName("Unit price")] public decimal UnitPrice { get; set; }
        public int Quanity { get; set; }
        [DisplayName("Crypto")] public string CryptoID { get; set; }
        [DisplayName("Crypto")] public string CryptoName { get; set; }
        [DisplayName("Ticker")] public string Ticker { get;set;}
        [DisplayName("BlockChain")] public string BlockChain { get;set;}
        [DisplayName("CryptoPortfolio")] public string CryptoPortfolioID { get; set; }
        [DisplayName("Total price")] public decimal TotalPrice { get; set; }
    }
}
