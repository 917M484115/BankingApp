using System;
using BankingApp.Aids;
using BankingApp.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Data.Common
{
    [TestClass]
    public class PersonDataTests : AbstractClassTests<NamedEntityData>
    {
        private class testClass : PersonData { }
        protected override PersonData createObject() =>new testClass();
        [TestMethod] public void LastNameTest() => isProperty<string>();
        [TestMethod] public void FirstMidNameTest() => isProperty<string>();

        [TestMethod] public void AgeTest() => isProperty<int>();
        [TestMethod] public void PhotoTest() => isProperty<byte[]>();
        [TestMethod] public void BirthdayTest() => isProperty<DateTime?>();
    }
}
