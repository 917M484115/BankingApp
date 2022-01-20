using BankingApp.Facade.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Facade.Loan
{
    [TestClass]
    public class CarLoanViewTests : SealedClassTests<LoanView>
    {
        [TestMethod] public void CarTypeTest() => isDisplayProperty<string>("Car type");
        [TestMethod] public void CarValueTest() => isDisplayProperty<double>("Car value",false);
        [TestMethod] public void CarAgeTest() => isDisplayProperty<int>("Car age",false);
    }
}
