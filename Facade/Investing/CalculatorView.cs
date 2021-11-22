using BankingApp.Facade.Common;

namespace BankingApp.Facade.Investing
{
    public class CalculatorView : NamedView
    {
        public double APY {get;set;}
        public double TimeInMonths { get;set;}
        public double Amount { get;set;}
        public double Result { get;set;}
        public double Revenue { get;set;}
    }
}
