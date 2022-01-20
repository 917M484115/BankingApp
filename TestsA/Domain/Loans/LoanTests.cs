//using BankingApp.Aids.Random;
//using BankingApp.Domain.Common;
//using BankingApp.Tests.Domain.Common;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace BankingApp.Tests.Domain.Loans
//{
//    [TestClass]
//    public class LoanTests : AbstractClassTests<UniqueEntity<MoneyAmountEntity<TestData>>>

//    {
//    private TestData data;

//    private class testClass : UniqueEntity<TestData>
//    {
//        public testClass(TestData d) : base(d)
//        {
//        }
//    }

//    protected override object createObject()
//    {
//        data = GetRandom.Object<TestData>();
//        return new testClass(data);
//    }

//    [TestMethod]
//    public void LoanManagerIdTest() => isProperty(data.Name);

//    [TestMethod]
//    public void LoanPeriodTest() => isProperty(data.Code);

//    [TestMethod]
//    public void InterestTest() => isProperty(data.Code);
//    }
//}
