using BankingApp.Data.Investing;
using BankingApp.Domain.Investing;
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
    [TestClass] public class BlockChainViewFactoryTests : FactoryBaseTests<BlockChainViewFactory, BlockChainData, BlockChain, BlockChainView>
    {
        protected override BlockChain createObject(BlockChainData d) => new(d);
    }
}
