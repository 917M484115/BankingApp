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
    public class PersonalLoanTests : SealedClassTests<Loan<PersonalLoanData>>
    {
        private PersonalLoanData data;
        private PersonalLoan personalLoan;

        protected override object createObject() => new PersonalLoan(data);

        [TestInitialize]
        public override void TestInitialize()
        {
            data = GetRandom.Object<PersonalLoanData>();
            base.TestInitialize();
            personalLoan = obj as PersonalLoan;
        }
        [TestMethod] public void ReasonTest() => isProperty(data.Reason);

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

