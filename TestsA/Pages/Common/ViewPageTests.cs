using BankingApp.Data.Investing;
using BankingApp.Domain.Investing;
using BankingApp.Domain.Investing.Repositories;
using BankingApp.Facade.Investing;
using BankingApp.Pages.Common;
using BankingApp.Pages.Investing;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BankingApp.Tests.Pages.Common {

    public class MockViewPage :
        ViewPage<MockViewPage, IBlockChainsRepository, BlockChain, BlockChainView, BlockChainData> {
        public MockViewPage(IBlockChainsRepository r) : base(r, nameof(BlockChain) + "s") { }
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
    public class ViewPageTests
        : AbstractClassTests<UnifiedPage<MockViewPage,IBlockChainsRepository, BlockChain, BlockChainView, BlockChainData>> {
        protected override object createObject() => new MockViewPage(MockRepos.BlockChains());
        //public abstract class ViewPageTests<TPage, TRepository, TDomain, TView, TData> :
        //UnifiedPageTests<TPage, TRepository, TDomain, TView, TData>
        //where TPage : PageModel
        //where TRepository : class, ICrudMethods<TDomain>, ISorting, IFiltering, IPaging
        //where TDomain : IEntity<TData>
        //where TData : PeriodData, new()
        //where TView : PeriodView {
        //protected ViewPageTests(TRepository r, string title) : base(r, title) { }
        //public virtual async Task OnGetIndexAsync(string sortOrder,
        //    string id, string currentFilter, string searchString, int? pageIndex,
        //    string fixedFilter, string fixedValue) {
        //    SelectedId = id;
        //    await getList(sortOrder, currentFilter, searchString, pageIndex,
        //        fixedFilter, fixedValue).ConfigureAwait(true);
        //}
        //public virtual IActionResult OnGetCreate(
        //    string sortOrder, string searchString, int? pageIndex,
        //    string fixedFilter, string fixedValue, int? switchOfCreate) {
        //    FixedFilter = fixedFilter;
        //    FixedValue = fixedValue;
        //    SortOrder = sortOrder;
        //    SearchString = searchString;
        //    PageIndex = pageIndex ?? 0;
        //    return Page();
        //}
        //public virtual async Task<IActionResult> OnPostCreateAsync(
        //    string sortOrder,
        //    string searchString,
        //    int? pageIndex,
        //    string fixedFilter,
        //    string fixedValue) {
        //    if (!await addObject(sortOrder, searchString, pageIndex, fixedFilter, fixedValue)
        //        .ConfigureAwait(true)) return Page();
        //    return Redirect(IndexUrl.ToString());
        //}
        //public virtual async Task<IActionResult> OnGetDeleteAsync(
        //    string id,
        //    string sortOrder,
        //    string searchString,
        //    int? pageIndex,
        //    string fixedFilter,
        //    string fixedValue) {
        //    await getObject(id, sortOrder, searchString, pageIndex, fixedFilter, fixedValue).ConfigureAwait(true);
        //    return Page();
        //}
        //public virtual async Task<IActionResult> OnPostDeleteAsync(string id, string sortOrder, string searchString,
        //    int pageIndex,
        //    string fixedFilter, string fixedValue) {
        //    await deleteObject(id, sortOrder, searchString, pageIndex, fixedFilter, fixedValue).ConfigureAwait(true);
        //    return Redirect(IndexUrl.ToString());
        //}
        //public virtual async Task<IActionResult> OnGetDetailsAsync(string id, string sortOrder, string searchString,
        //    int pageIndex,
        //    string fixedFilter, string fixedValue) {
        //    await getObject(id, sortOrder, searchString, pageIndex, fixedFilter, fixedValue).ConfigureAwait(true);

        //    return Page();
        //}
        //public virtual async Task<IActionResult> OnGetEditAsync(
        //    string id,
        //    string sortOrder,
        //    string searchString,
        //    int pageIndex,
        //    string fixedFilter,
        //    string fixedValue) {
        //    await getObject(id, sortOrder, searchString, pageIndex, fixedFilter, fixedValue).ConfigureAwait(true);
        //    return Page();
        //}
        //public virtual async Task<IActionResult> OnPostEditAsync(string sortOrder, string searchString, int pageIndex,
        //    string fixedFilter, string fixedValue) {
        //    await updateObject(sortOrder, searchString, pageIndex, fixedFilter, fixedValue).ConfigureAwait(true);
        //    return Redirect(IndexUrl.ToString());
        //}
    }
}
