using BankingApp.Domain.Investing.Repositories;
using BankingApp.Domain.Misc;
namespace BankingApp.Pages.Investing
{
    public sealed class CryptoBasketManagerPage : CryptoBasketBasePage<CryptoBasketManagerPage>
    {
        public CryptoBasketManagerPage(ICryptoBasketsRepository cbr, ICustomerRepository cr,
            IOrdersRepository or, ICryptoOrderItemsRepository coir) : base(cbr, cr, or, coir) { }
    }
}
