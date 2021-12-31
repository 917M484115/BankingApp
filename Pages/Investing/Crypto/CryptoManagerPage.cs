using System;
using BankingApp.Domain.Investing.Repositories;

namespace BankingApp.Pages.Investing
{
    public sealed class CryptoManagerPage : CryptoBasePage<CryptoManagerPage>
    {
        public CryptoManagerPage(ICryptoRepository r,
           ICryptoBasketsRepository cbr, ICryptoBasketItemsRepository cir)
           : base(r, cbr, cir) { }
    }
}