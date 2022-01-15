using BankingApp.Domain.Investing.Repositories;
using BankingApp.Domain.Misc;
using BankingApp.Domain.Misc.Repositories;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace BankingApp.Pages.Investing
{
    public sealed class CryptoBasketsManagerPage : CryptoBasketsBasePage<CryptoBasketsManagerPage>
    {
        public CryptoBasketsManagerPage(ICryptoBasketsRepository cbr, ICustomersRepository cr,
            IOrdersRepository or, IOrderItemsRepository coir, ICryptoBasketItemsRepository cbir, ICryptoPortfolioRepository cpr) : base(cbr, cr, or, coir, cbir, cpr) { }
        
    }
}
