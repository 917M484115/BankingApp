using BankingApp.Aids.Constants;
using BankingApp.Aids.Random;
using BankingApp.Data.Misc;
using BankingApp.Domain.Common;
using BankingApp.Domain.Misc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Domain.Misc
{
    [TestClass]
    public class CustomerTests: SealedClassTests<PersonEntity<CustomerData>>
    {
        private CustomerData data;
        protected override object createObject() => new Customer(data);
        [TestInitialize] public override void TestInitialize() {
            data = GetRandom.Object<CustomerData>();
            base.TestInitialize();
        }
        [TestMethod] public void CountryTest() => isProperty(data.Country);
        [TestMethod] public void AgeTest() => isProperty(data.Age);

    }
}
