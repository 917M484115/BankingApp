using BankingApp.Facade.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Tests.Facade.Investing
{
    [TestClass]
    public class CryptoViewTests : SealedClassTests<VirtualAssetView>
    {
        [TestMethod] public void BlockChainIDTest() => isDisplayProperty<string>("BlockChain");
    }
}
