using BankingApp.Data.Common;

namespace BankingApp.Data.Investing
{
    public sealed class InvestmentData : MoneyAmountData //MoneyAmount siin on InitialAmount
    {
        public double CurrentAmount { get; set; }
        public string Description { get; set; } 
    }
}
