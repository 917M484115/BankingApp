using BankingApp.Domain.Common;
using BankingApp.Data.Investing;
namespace BankingApp.Domain.Investing
{
    public sealed class Calculator : NamedEntity<CalculatorData>
    {
        public Calculator(CalculatorData d) : base(d) { }
        public double APY => Data?.APY ?? double.NaN;
        public double Amount =>Data?.Amount ?? double.NaN;
        public double TimeInMonths => Data?.TimeInMonths ?? double.NaN;
        public double Result =>Data?.Result?? double.NaN;
        public double Revenue =>Data?.Revenue?? double.NaN;
    }
}
