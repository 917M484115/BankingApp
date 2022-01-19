using BankingApp.Data.Investing;
using BankingApp.Domain.Investing;
using BankingApp.Domain.Investing.Repositories;
using BankingApp.Facade.Investing;
using BankingApp.Pages.Common;
using BankingApp.Pages.Investing;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Pages.Common {

    [TestClass]
    public class PagedPageTests
        : AbstractClassTests<CrudPage<IBlockChainsRepository, BlockChain, BlockChainView, BlockChainData>> {
        private class testClass :
            PagedPage<IBlockChainsRepository, BlockChain, BlockChainView, BlockChainData> {
            public testClass(IBlockChainsRepository r) : base(r) { }
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
        protected override object createObject() => new testClass(MockRepos.BlockChains());
        //public abstract class PagedPageTests<TRepository, TDomain, TView, TData> :
        //CrudPageTests<TRepository, TDomain, TView, TData>
        //where TRepository : class, ICrudMethods<TDomain>, ISorting, IFiltering, IPaging
        //where TView : PeriodView {

        //protected PagedPageTests(TRepository r) : base(r) { }

        //public IList<TView> Items { get; private set; }

        //public string SelectedId {
        //    get;
        //    set;
        //}
        //public int PageIndex {
        //    get => db.PageIndex;
        //    set => db.PageIndex = value;
        //}
        //public bool HasPreviousPage => db.HasPreviousPage;
        //public bool HasNextPage => db.HasNextPage;

        //public int TotalPages => db.TotalPages;

        //protected internal override void setPageValues(string sortOrder, string searchString, in int? pageIndex) {
        //    SortOrder = sortOrder;
        //    SearchString = searchString;
        //    PageIndex = pageIndex ?? 0;
        //}

        //protected internal async Task getList(string sortOrder, string currentFilter, string searchString,
        //    int? pageIndex, string fixedFilter, string fixedValue) {

        //    FixedFilter = fixedFilter;
        //    FixedValue = fixedValue;
        //    SortOrder = sortOrder;
        //    SearchString = searchString;
        //    CurrentFilter = getCurrentFilter(currentFilter, searchString, ref pageIndex);
        //    PageIndex = pageIndex ?? 1;
        //    Items = await getList().ConfigureAwait(true);
        //}

        //internal async Task<List<TView>> getList() {
        //    var l = await db.Get().ConfigureAwait(true);

        //    return l.Select(toView).ToList();
        //}

    }

}
