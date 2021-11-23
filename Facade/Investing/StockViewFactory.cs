using BankingApp.Facade.Common;
using BankingApp.Data.Investing;
using BankingApp.Domain.Investing;
namespace BankingApp.Facade.Investing
{
    public sealed class StockViewFactory : AbstractViewFactory<StockData, Stock, StockView>
    {
        protected internal override Stock toObject(StockData d) => new Stock(d);
    }
}