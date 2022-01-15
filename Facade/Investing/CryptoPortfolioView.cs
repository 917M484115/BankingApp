using BankingApp.Facade.Common;
using System.ComponentModel;

namespace BankingApp.Facade.Investing
{
    public sealed class CryptoPortfolioView : UniqueEntityView
    {
        [DisplayName("Crypto")] public string CryptoID { get; set; }
        [DisplayName("Crypto Name")] public string CryptoName { get; set; }
        [DisplayName("Customer Name")] public string CustomerName { get;set;}
        public string CustomerID { get;set;}
        public string BlockChain { get; set; }
        public string Ticker { get; set; }
        [DisplayName("Unit price")] public decimal UnitPrice { get; set; }
        public int Units { get; set; }
        [DisplayName("Total Price")] public decimal TotalPrice { get; set; }
    }
}
