//using BankingApp.Aids.Random;
//using BankingApp.Data.Loan;
//using BankingApp.Domain.Loans;
//using BankingApp.Tests;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace Tests.Domain.Loans
//{
//    [TestClass]
//    public class CarLoanTests : SealedClassTests<LoanData>
//    {
//        private CarLoanData data;

//        protected override object createObject() => new CarLoan(data);

//        [TestMethod] public void CarValueTest() => isProperty(data.CarValue);
//        [TestMethod] public void CarAgeTest() => isProperty(data.CarAge);
//        [TestMethod] public void CarTypeTest() => isProperty(data.CarType);

//        //[TestMethod]
//        //public void MonthlyReturnTest()
//        //{
//        //    data = GetRandom.Object<CarLoanData>();
//        //    var expected = 0;
//        //    areEqual(expected, );
            
//        //    areEqual(expected, basket.TotalPrice);
//        //}
//    }
//}
