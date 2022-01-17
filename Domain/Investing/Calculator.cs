using BankingApp.Domain.Common;
using BankingApp.Data.Investing;
namespace BankingApp.Domain.Investing
{
    public sealed class Calculator : NamedEntity<CalculatorData>
    {
        public Calculator(CalculatorData d) : base(d) { }
    }
}
