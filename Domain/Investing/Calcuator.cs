using BankingApp.Domain.Common;
using BankingApp.Data.Investing;
namespace BankingApp.Domain.Investing
{
    public sealed class Calcuator : NamedEntity<CalculatorData>
    {
        public Calcuator(CalculatorData d) : base(d) { }
        public double Apy => Data?.APY ?? 0;
    }
}
