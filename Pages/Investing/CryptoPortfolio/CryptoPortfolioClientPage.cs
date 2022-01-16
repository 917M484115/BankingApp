using BankingApp.Aids.Reflection;
using BankingApp.Data.Investing;
using BankingApp.Data.Misc;
using BankingApp.Domain.Investing;
using BankingApp.Domain.Investing.Repositories;
using BankingApp.Domain.Misc;
using BankingApp.Domain.Misc.Repositories;
using BankingApp.Facade.Investing;
using BankingApp.Pages.Common;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BankingApp.Pages.Investing
{
    public sealed class CryptoPortfolioClientPage:CryptoPortfolioBasePage<CryptoPortfolioClientPage>
    {
        protected internal override Uri pageUrl() => new Uri("/Customer/CryptoPortfolios", UriKind.Relative);
        public CryptoPortfolioClientPage(ICryptoPortfolioRepository r) : base(r) { }
        //CryptoPortfolioView c;
        public override async Task OnGetIndexAsync(string sortOrder,
            string id, string currentFilter, string searchString, int? pageIndex,
            string fixedFilter, string fixedValue)
        {
            SelectedId = id;
            fixedFilter = GetMember.Name<CryptoBasketData>(x => x.CustomerID);
            fixedValue = User.Identity.Name;
            await getList(sortOrder, currentFilter, searchString, pageIndex,
                fixedFilter, fixedValue).ConfigureAwait(true);
        }
        public override async Task<IActionResult> OnPostEditAsync(string sortOrder, string searchString, int pageIndex,
            string fixedFilter, string fixedValue)
        {
            //CryptoPortfolio b = await db.Get(SelectedId);
            //var amountToSell=
            //await updateObject(sortOrder, searchString, pageIndex, fixedFilter, fixedValue).ConfigureAwait(true);
            Item.Units -= Item.AmountToSell;
            var c = Item.AmountToSell;

            await updateObject(sortOrder, searchString, pageIndex, fixedFilter, fixedValue).ConfigureAwait(true);
            return Redirect(IndexUrl.ToString());
        }
        public override async Task<IActionResult> OnPostDeleteAsync(string id, string sortOrder, string searchString,
            int pageIndex,
            string fixedFilter, string fixedValue)
        {
            //CryptoPortfolioView c=new;
            CryptoPortfolio b = await db.Get(id);
            //var amountToSell=
            //await updateObject(sortOrder, searchString, pageIndex, fixedFilter, fixedValue).ConfigureAwait(true);
            b.Data.Units -= Item.AmountToSell;
            var c = b.AmountToSell;
            
            //b.Units -= c.AmountToSell;
            //await CryptoBasketsRepository.Delete(id);
            //await deleteObject(id, sortOrder, searchString, pageIndex, fixedFilter, fixedValue).ConfigureAwait(true);
            await updateObject(sortOrder, searchString, pageIndex, fixedFilter, fixedValue).ConfigureAwait(true);
            return Redirect(IndexUrl.ToString());
        }
    }
}
