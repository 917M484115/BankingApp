using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApp.Data.Common;
using BankingApp.Data.Investing;
using BankingApp.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Data.Investing
{
    [TestClass]
    public class OrderItemDataTests : SealedClassTests<UniqueEntityData>
    {
        [TestMethod] public void OrderIDTest() => isProperty<string>();
        [TestMethod] public void CryptoIDTest() => isProperty<string>();
        [TestMethod] public void OrderTypeTest() => isProperty<string>();
        [TestMethod] public void UnitsTest() => isProperty<int>(false);
        [TestMethod] public void OrderTimeTest() => isProperty<DateTime>(false);
    }
}
