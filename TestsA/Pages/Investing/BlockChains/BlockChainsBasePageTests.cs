using BankingApp.Data.Investing;
using BankingApp.Domain.Investing;
using BankingApp.Domain.Investing.Repositories;
using BankingApp.Facade.Investing;
using BankingApp.Pages.Common;
using BankingApp.Pages.Investing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Tests.Pages.Investing
{
    [TestClass]
    public class BlockChainsBasePageTests : CommonPageTests<BlockChainsManagerPage, ViewPage<BlockChainsManagerPage, IBlockChainsRepository, BlockChain,
        BlockChainView, BlockChainData>>
    {
        protected override string expectedUrl => "/Manager/BlockChains";

        protected override object createObject() => new BlockChainsManagerPage(MockRepos.BlockChains());
        //public abstract class CatalogsBasePageTests<TPage> :
        //ViewPage<TPage, ICatalogsRepository, Catalog, CatalogView, CatalogData>
        //where TPage: PageModel{
        //protected CatalogsBasePageTests(ICatalogsRepository r) : base(r, "Catalogs") { }
        //protected internal override Uri pageUrl() => new Uri("/Shop/Catalogs", UriKind.Relative);
        //protected internal override Catalog toObject(CatalogView v) => new CatalogViewFactory().Create(v);
        //protected internal override CatalogView toView(Catalog o) => new CatalogViewFactory().Create(o);
        protected override List<string> expectedIndexPageColumns => new()
        {
            "Id",
            "Name"
        };
    }
}
