using BankingApp.Domain.Investing.Repositories;
using BankingApp.Domain.Misc.Repositories;

namespace BankingApp.Pages.Investing
{
    public sealed class OrdersManagerPage : OrdersBasePage<OrdersClientPage>
    {
        public OrdersManagerPage(IOrdersRepository r, ICustomersRepository b) : base(r, b) { }
    }
}
