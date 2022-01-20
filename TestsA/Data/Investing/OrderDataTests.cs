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
    public class OrderDataTests : SealedClassTests<UniqueEntityData>
    {
        [TestMethod] public void CustomerIDTest() => isProperty<string>();
        [TestMethod] public void OrderDateTest() => isProperty<DateTime>(false);
    }
}
