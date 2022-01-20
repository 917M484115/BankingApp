using BankingApp.Data.Loan;
using BankingApp.Domain.Loans;
using BankingApp.Facade.Loan;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Facade.Loan
{
    [TestClass]
    public class CarLoanViewFactoryTests : FactoryBaseTests<CarLoanViewFactory, CarLoanData, CarLoan, CarLoanView>
    {
        protected override CarLoan createObject(CarLoanData d) => new(d);

        protected override void doAfterCreateViewTest(CarLoan o, CarLoanView v)
        {
            areEqual(o.CarType, v.CarType);
            areEqual(o.CarValue, v.CarValue);
            areEqual(o.CarAge, v.CarAge);
            areEqual(o.MonthlyReturn, v.MonthlyReturn);
        }
    }
}
