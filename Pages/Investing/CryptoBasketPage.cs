using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApp.Domain.Common;
using BankingApp.Domain.Investing;
using BankingApp.Domain.Investing.Repositories;

namespace BankingApp.Pages.Investing
{
    public sealed class CryptoBasketPage : CryptoBasePage<CryptoBasketPage>
    {
        public CryptoBasketPage(ICryptoBasketsRepository r, PersonEntity b,
            IOrdersRepository o, IOrderItemsRepository oi) : base(r, b, o, oi) { }
    }
}
