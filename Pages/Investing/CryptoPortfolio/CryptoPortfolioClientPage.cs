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
        ICryptoPortfolioRepository cryptoRepo;
        IOrderItemsRepository orderItemsRepo;
        IOrdersRepository ordersRepo;
        public CryptoPortfolioClientPage(ICryptoPortfolioRepository r, IOrderItemsRepository oir, IOrdersRepository or) : base(r,oir,or) {cryptoRepo=r;orderItemsRepo=oir;ordersRepo=or; }
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
            var c = await cryptoRepo.SellCrypto(Item.CryptoID,User.Identity.Name, Item.AmountToSell);
            if(c>0)
            {
                var o = ordersRepo.GetLatestForUser(User.Identity.Name).Result;
                await orderItemsRepo.AddOrderItem(o.Id,c,Item.CryptoID);
            }
            return Redirect(IndexUrl.ToString());
        }
    }
}
