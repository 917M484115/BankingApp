using BankingApp.Domain.Common;
using BankingApp.Data.Investing;

namespace BankingApp.Domain.Investing
{
    public sealed class Investment : MoneyAmountEntity<InvestmentData>
    {
        public Investment(InvestmentData d) : base(d) { }
        public string Description => Data?.Description ?? Unspecified;
        public double CurrentAmount => Data?.CurrentAmount ?? 0;
    }
}
