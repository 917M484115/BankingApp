using BankingApp.Data.Investing;
using BankingApp.Domain.Investing;
using BankingApp.Domain.Investing.Repositories;
using BankingApp.Domain.Misc;
using BankingApp.Facade.Investing;
using BankingApp.Pages.Common;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Pages.Investing
{
    public abstract class CryptoBasketBasePage<TPage> :
        ViewPage<TPage, ICryptoBasketsRepository, CryptoBasket, 
            CryptoBasketView, CryptoBasketData>
        where TPage : PageModel
    {
        protected CryptoBasketBasePage(ICryptoBasketsRepository r, ICustomerRepository b,
            IInvestmentRepository o, IOrderItemsRepository oi) : base(r, "Baskets")
        {
            Buyers = newItemsList<Buyer, BuyerData>(b);
            Orders = o;
            OrderItems = oi;
        }
    }
}
