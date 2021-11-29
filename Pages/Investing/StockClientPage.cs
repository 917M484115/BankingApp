using BankingApp.Domain.Investing.Repositories;

namespace BankingApp.Pages.Investing
{
    public sealed class StockClientPage : StockBasePage<StockClientPage>
    {
        public StockClientPage(IStockRepository r) : base(r) { }

    }
}
