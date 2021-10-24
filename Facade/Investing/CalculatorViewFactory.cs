using BankingApp.Facade.Common;
using BankingApp.Data.Investing;
using BankingApp.Domain.Investing;
namespace BankingApp.Facade.Investing
{
    public sealed class CalculatorViewFactory : AbstractViewFactory<CalculatorData, Calcuator, CalcuatorView>
    {
        protected internal override Calcuator toObject(CalculatorData d) => new Calcuator(d);
    }
}
