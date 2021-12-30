using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApp.Domain.Common;
using BankingApp.Domain.Investing;
using BankingApp.Domain.Investing.Repositories;
using BankingApp.Domain.Misc;

namespace BankingApp.Pages.Investing
{
    public sealed class CryptoBasketPage : CryptoBasePage<CryptoBasketPage>
    {
        public CryptoBasketPage(ICryptoBasketsRepository r, ICustomerRepository b,
            IOrdersRepository o, ICryptoOrderItemsRepository oi) : base(r, b, o, oi) { }
    }
}
