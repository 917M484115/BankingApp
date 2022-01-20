using BankingApp.Data.Loan;
using BankingApp.Domain.Loans;
using BankingApp.Facade.Loan;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Facade.Loan
{
    [TestClass]
    public class PersonalLoanViewFactoryTests : FactoryBaseTests<PersonalLoanViewFactory, PersonalLoanData, PersonalLoan, PersonalLoanView>
    {
        protected override PersonalLoan createObject(PersonalLoanData d) => new(d);

        protected override void doAfterCreateViewTest(PersonalLoan o, PersonalLoanView v)
        {
            areEqual(o.Reason, v.Reason);
            areEqual(o.MonthlyReturn, v.MonthlyReturn);
        }
    }
}