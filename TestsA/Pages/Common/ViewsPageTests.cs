using BankingApp.Data.Investing;
using BankingApp.Domain.Investing;
using BankingApp.Domain.Investing.Repositories;
using BankingApp.Facade.Investing;
using BankingApp.Pages.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BankingApp.Tests.Pages.Common {
    public class MockViewsPage :
        ViewsPage<MockViewsPage, IBlockChainsRepository, BlockChain, BlockChainView, BlockChainData> {
        public MockViewsPage(IBlockChainsRepository r) : base(r, nameof(BlockChain) + "s") { }
        protected override void createTableColumns() {
            //throw new NotImplementedException();
        }
        protected override Uri pageUrl() {
            throw new NotImplementedException();
        }
        protected override void setPageValues(string sortOrder, string searchString, in int? pageIndex) {
            throw new System.NotImplementedException();
        }
        protected override BlockChain toObject(BlockChainView v) {
            throw new System.NotImplementedException();
        }
        protected override BlockChainView toView(BlockChain o) {
            throw new System.NotImplementedException();
        }
    }
    [TestClass]
    public class ViewsPageTests
        : AbstractClassTests<ViewPage<MockViewsPage, IBlockChainsRepository, BlockChain, BlockChainView, BlockChainData>> {
        protected override object createObject() => new MockViewsPage(MockRepos.BlockChains());
        //public abstract class ViewsPageTests<TPage, TRepository, TDomain, TView, TData> :
        //ViewPageTests<TPage, TRepository, TDomain, TView, TData>
        //where TPage : PageModel
        //where TRepository : class, ICrudMethods<TDomain>, ISorting, IFiltering, IPaging
        //where TDomain : IEntity<TData>
        //where TData : PeriodData, new()
        //where TView : PeriodView {
        //protected ViewsPageTests(TRepository r, string title) : base(r, title) { }

        //protected internal Uri createUri(int i) {
        //    var uri = CreateUrl.ToString();
        //    uri += $"&switchOfCreate={i}";

        //    return new Uri(uri, UriKind.Relative);
        //}
    }
}
