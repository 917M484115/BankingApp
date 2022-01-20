using BankingApp.Data.Loan;
using BankingApp.Domain.Loans;
using BankingApp.Facade.Loan;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Facade.Loan
{
    [TestClass]
    public class LoanManagerViewFactoryTests : FactoryBaseTests<LoanManagerViewFactory, LoanManagerData, LoanManager, LoanManagerView>
    {
        protected override LoanManager createObject(LoanManagerData d) => new(d);
    }
}