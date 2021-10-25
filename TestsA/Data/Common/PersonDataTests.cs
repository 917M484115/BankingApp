using System;
using BankingApp.Aids;
using BankingApp.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Data.Common
{
    [TestClass]
    public class PersonDataTests : AbstractClassTests<PersonData, BaseData>
    {
        private class testClass : PersonData { }
        protected override PersonData getObject() => GetRandom.ObjectOf<testClass>();
        [TestMethod] public void LastNameTest() => isReadWriteProperty<string>();
        [TestMethod] public void FirstMidNameTest() => isReadWriteProperty<string>();

        [TestMethod] public void AgeTest() => isReadWriteProperty<int>();
        [TestMethod] public void PhotoTest() => isReadWriteProperty<byte[]>();
        [TestMethod] public void BirthdayTest() => isReadWriteProperty<DateTime?>();
    }
}
