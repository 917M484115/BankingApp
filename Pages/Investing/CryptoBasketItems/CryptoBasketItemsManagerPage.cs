using BankingApp.Domain.Investing.Repositories;
namespace BankingApp.Pages.Investing
{
    public sealed class CryptoBasketItemsManagerPage : CryptoBasketItemsBasePage<CryptoBasketItemsManagerPage>
    {
        public CryptoBasketItemsManagerPage(ICryptoBasketItemsRepository cbir, ICryptoBasketsRepository cbr, ICryptoRepository cr)
            : base(cbir, cbr, cr) { }
    }
}
