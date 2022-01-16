using BankingApp.Facade.Common;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using DataAnnotationsExtensions;
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
        [Min(0)]
        [DisplayName("Unit price")] public decimal UnitPrice { get; set; }
        [Min(0)]
        public int Units { get; set; }
        [Min(0)]
        [DisplayName("Total Price")] public decimal TotalPrice { get; set; }
        [TempData, DisplayName("Amount to sell")] public int AmountToSell { get; set; }
    }
}
