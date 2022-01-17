using BankingApp.Aids.Random;
using BankingApp.Domain.Common;
using BankingApp.Pages.Common;
using BankingApp.Tests;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BankingApp.Tests.Pages {
    public abstract class CommonPageTests<TPage, TBaseClass> : AbstractClassTests<TBaseClass>
        where TPage : PageModel, IUnifiedPage<TPage> {

        protected string id;
        protected string sortOrder;
        protected string searchString;
        protected int pageIndex;
        protected string fixedFilter;
        protected string fixedValue;
        protected string currentFilter;
        protected int switchOfCreate;
        protected virtual string expectedUrl => string.Empty;
        protected abstract List<string> expectedIndexPageColumns { get; }
        protected TPage page;
        [TestInitialize] public override void TestInitialize() {
            base.TestInitialize();
            page = obj as TPage;
            id = Guid.NewGuid().ToString();
            sortOrder = random<string>();
            searchString = random<string>();
            pageIndex = random<int>();
            switchOfCreate = random<int>();
            currentFilter = random<string>();
            fixedFilter = random<string>();
            fixedValue = random<string>();
        }
        [TestMethod] public void PageUrlTest() {
            if (expectedUrl == string.Empty) notTested();
            var pi = objUnderTests?.GetType()?.GetProperty("PageUrl");
            var expected = pi?.GetValue(objUnderTests).ToString();
            areEqual(expectedUrl, expected);
        }
        [TestMethod] public void TableColumnsTest() {
            var expectedCount = expectedIndexPageColumns.Count;
            areNotEqual(0, expectedCount);
            var pi = objUnderTests?.GetType()?.GetProperty("Columns");
            dynamic c = pi?.GetValue(objUnderTests);
            areEqual(expectedCount, c.Count);
            for (var i = 0; i < expectedCount; i++)
                isTrue(c[i].ToString().EndsWith(expectedIndexPageColumns[i]));
        }
        [TestMethod] public void GetNameTest() {
            var count = expectedIndexPageColumns.Count;
            IHtmlHelper<TPage> htmlHelper = new MockHtmlHelper<TPage>();
            for (var index = 0; index < count; index++) {
                var expected = expectedIndexPageColumns[index];
                areEqual("Undefined", page.GetName(null, index));
                isTrue(page.GetName(htmlHelper, index).EndsWith(expected));
            }
            var indexOutOfLimits = GetRandom.Int32(count);
            areEqual("Undefined", page.GetName(null, indexOutOfLimits));
            areEqual("Undefined", page.GetName(htmlHelper, indexOutOfLimits));
        }
        [TestMethod]
        public void GetValueTest() {
            var count = expectedIndexPageColumns.Count;
            IHtmlHelper<TPage> htmlHelper = new MockHtmlHelper<TPage>();
            for (var index = 0; index < count; index++) {
                var expected = expectedIndexPageColumns[index];
                areEqual(default(IHtmlContent), page.GetValue(null, index));
                var c = page.GetValue(htmlHelper, index);
                if (c is not MockHtmlContent) c = new MockHtmlContent(c);
                validateValue((c as MockHtmlContent).Value, expected);
            }
            var indexOutOfLimits = GetRandom.Int32(count);
            areEqual(default(IHtmlContent), page.GetValue(null, indexOutOfLimits));
            areEqual(default(IHtmlContent), page.GetValue(htmlHelper, indexOutOfLimits));
        }
        protected virtual void validateValue(string actual, string expected) 
            => isTrue(actual.EndsWith(expected));
        protected IRepository<TO> addItems<TO, TD>(IRepository<TO> r, Func<TD, TO> f) {
            var c = random(5, 10);
            for (var i = 0; i < c; i++)
                r.Add(f(random<TD>()));
            return r;
        }
        protected async Task selectListTest<TO>(dynamic l, IRepository<TO> r)
            => areEqual((await r.Get()).Count + 1, l.Count);
        protected async Task selectNameTest<TO>(IRepository<TO> r, Func<string, string> f ) {
            var l = await r.Get();
            var idx = random(0, l.Count);
            dynamic o = l[idx];
            areEqual(o.Name, f(o.Id));
        }
    }
}
