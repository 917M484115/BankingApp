using BankingApp.Data.Common;
using BankingApp.Facade.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BankingApp.Tests.Facade.Common {

    [TestClass]
    public class PeriodViewTests : AbstractClassTests<BaseEntity> {

        private class testClass : PeriodView {
            private static string id;
            public override string GetId() {
                if (id is null) id = Guid.NewGuid().ToString();
                return id;
            }
        }
        [TestMethod] public void FromTest() => isDateProperty<DateTime?>("Valid from");
        [TestMethod] public void ToTest() => isDateProperty<DateTime?>("Valid to");
        [TestMethod] public void GetIdTest() => isAbstractMethod<PeriodView>("GetId");
        protected override object createObject() => new testClass();
    }
}