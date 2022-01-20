using BankingApp.Data.Loan;
using BankingApp.Domain.Loans;
using BankingApp.Facade.Loan;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Facade.Loan
{
    [TestClass]
    public class LoanAccountViewFactoryTests : FactoryBaseTests<LoanAccountViewFactory, LoanAccountData, LoanAccount, LoanAccountView>
    {
        protected override LoanAccount createObject(LoanAccountData d) => new(d);

        protected override void doAfterCreateViewTest(LoanAccount o, LoanAccountView v)
        {
            areEqual(o.MoneyAmount, v.MoneyAmount);
            areEqual(o.AccountAddress, v.AccountAddress);
        }
    }
}
