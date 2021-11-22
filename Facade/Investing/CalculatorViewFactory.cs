using BankingApp.Facade.Common;
using BankingApp.Data.Investing;
using BankingApp.Domain.Investing;
namespace BankingApp.Facade.Investing
{
    public sealed class CalculatorViewFactory : AbstractViewFactory<CalculatorData, Calculator, CalculatorView>
    {
        protected internal override Calculator toObject(CalculatorData d) => new Calculator(d);
    }
}
