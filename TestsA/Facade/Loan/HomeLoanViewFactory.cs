using BankingApp.Data.Loan;
using BankingApp.Domain.Loans;
using BankingApp.Facade.Loan;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Facade.Loan
{
    [TestClass]
    public class HomeLoanViewFactoryTests : FactoryBaseTests<HomeLoanViewFactory, HomeLoanData, HomeLoan, HomeLoanView>
    {
        protected override HomeLoan createObject(HomeLoanData d) => new(d);

        protected override void doAfterCreateViewTest(HomeLoan o, HomeLoanView v)
        {
            areEqual(o.HomeValue, v.HomeValue);
            areEqual(o.HomeAge, v.HomeAge);
            areEqual(o.MonthlyReturn, v.MonthlyReturn);
        }
    }
}
