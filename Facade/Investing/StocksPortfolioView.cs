using BankingApp.Data.Investing;
using BankingApp.Facade.Common;
using System.ComponentModel;
using BankingApp.Domain.Investing;
namespace BankingApp.Facade.Investing
{
    public sealed class StocksPortfolioView : UniqueEntityView
    {
        [DisplayName("Buyer email")] public string BuyerId { get; set; }
        [DisplayName("Customer name")] public string CustomerName { get; set; }
        [DisplayName("Customer Country")] public string CustomerCountry { get; set; }
        [DisplayName("Total price")] public decimal TotalPrice { get; set; }
        [DisplayName("Closed")] public bool Closed { get; set; }
    }
}
