using BankingApp.Facade.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Facade.Loan
{
    [TestClass]
    public class PersonalLoanViewTests : SealedClassTests<LoanView>
    {
        [TestMethod] public void ReasonTest() => isDisplayProperty<string>("Reason");
      
    }
}

