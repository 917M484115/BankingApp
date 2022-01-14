using BankingApp.Domain.Investing.Repositories;

namespace BankingApp.Pages.Investing
{
    public sealed class OrderItemsManagerPage:OrderItemsBasePage<OrderItemsManagerPage>
    {
        public OrderItemsManagerPage(IOrderItemsRepository r, IOrdersRepository o, ICryptoRepository p)
            : base(r, o, p) { }
    }
}
