using BankingApp.Facade.Common;
using BankingApp.Facade.Investing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Tests.Facade.Investing
{
    [TestClass]
    public class BlockChainViewTests : SealedClassTests<NamedView>
    {
        [TestMethod] public void CodeTest() => isDisplayProperty<string>("Code");
        [TestMethod] public void NameTest() => isDisplayProperty<string>("Name");
    }
}
