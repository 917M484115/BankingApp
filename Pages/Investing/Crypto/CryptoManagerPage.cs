using System;
using BankingApp.Domain.Investing.Repositories;

namespace BankingApp.Pages.Investing
{
    public sealed class CryptoManagerPage : CryptoBasePage<CryptoManagerPage>
    {
        public CryptoManagerPage(ICryptoRepository r,
           ICryptoBasketsRepository cbr, ICryptoBasketItemsRepository cir,IBlockChainsRepository bcr)
           : base(r, cbr, cir,bcr) { }
    }
}