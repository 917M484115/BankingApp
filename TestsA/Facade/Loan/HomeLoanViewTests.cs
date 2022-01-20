using BankingApp.Facade.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Facade.Loan
{
    [TestClass]
    public class HomeLoanViewTests : SealedClassTests<LoanView>
    {
        [TestMethod] public void HomeValueTest() => isDisplayProperty<double>("Home value",false);
        [TestMethod] public void HomeAgeTest() => isDisplayProperty<int>("Home age",false);
    }
}
