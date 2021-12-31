using BankingApp.Data.Investing;
using BankingApp.Domain.Investing;
using BankingApp.Facade.Investing;
using BankingApp.Pages.Common;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BankingApp.Domain.Investing.Repositories;
using BankingApp.Domain.Misc;
using System.Collections.Generic;
using BankingApp.Data.Misc;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace BankingApp.Pages.Investing
{
    public sealed class CryptoBasketManagerPage : CryptoBasketBasePage<CryptoBasketManagerPage>
    {
        public CryptoBasketManagerPage(ICryptoBasketsRepository cbr, ICustomerRepository cr,
            IOrdersRepository or, ICryptoOrderItemsRepository coir) : base(cbr, cr, or, coir) { }
    }
}
