using BankingApp.Data.Common;

namespace BankingApp.Data.Investing
{
    public sealed class CryptoPortfolioData : UniqueEntityData
    {
        public string CustomerID {get;set;}
        public string CryptoID { get; set; }
        public int Units { get; set; }
        public int AmountToSell { get; set; }
    }
}
