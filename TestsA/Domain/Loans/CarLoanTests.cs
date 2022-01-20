using BankingApp.Aids.Random;
using BankingApp.Data.Common;
using BankingApp.Data.Loan;
using BankingApp.Domain.Loans;
using BankingApp.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Domain.Loans
{
    [TestClass]
    public class CarLoanTests : SealedClassTests<Loan<CarLoanData>>
    {
        private CarLoanData data;
        private CarLoan carLoan;

        protected override object createObject() => new CarLoan(data);

        [TestInitialize]
        public override void TestInitialize()
        {
            data = GetRandom.Object<CarLoanData>();
            base.TestInitialize();
            carLoan = obj as CarLoan;
        }
        [TestMethod] public void CarValueTest() => isProperty(data.CarValue);
        [TestMethod] public void CarAgeTest() => isProperty(carLoan.CarAge);
        [TestMethod] public void CarTypeTest() => isProperty(carLoan.CarType);

        //[TestMethod]
        //public void MonthlyReturnTest()
        //{
        //    data = GetRandom.Object<CarLoanData>();
        //    var expected = 0;
        //    areEqual(expected, );

        //    areEqual(expected, basket.TotalPrice);
        //}
    }
}
