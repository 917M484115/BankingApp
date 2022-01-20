using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApp.Aids.Random;
using BankingApp.Data.Loan;
using BankingApp.Domain.Loans;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Domain.Loans
{
    [TestClass]
    public class HomeLoanTests : SealedClassTests<Loan<HomeLoanData>>
    {
        private HomeLoanData data;
        private HomeLoan homeLoan;

        protected override object createObject() => new HomeLoan(data);

        [TestInitialize]
        public override void TestInitialize()
        {
            data = GetRandom.Object<HomeLoanData>();
            base.TestInitialize();
            homeLoan = obj as HomeLoan;
        }
        [TestMethod] public void HomeValueTest() => isProperty(data.HomeValue);
        [TestMethod] public void HomeAgeTest() => isProperty(data.HomeAge);

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
