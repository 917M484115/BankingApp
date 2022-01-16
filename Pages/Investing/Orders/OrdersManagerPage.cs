using BankingApp.Domain.Investing.Repositories;
using BankingApp.Domain.Misc.Repositories;

namespace BankingApp.Pages.Investing
{
    public sealed class OrdersManagerPage : OrdersBasePage<OrdersManagerPage>
    {
        public OrdersManagerPage(IOrdersRepository r, ICustomersRepository b) : base(r, b) { }
    }
}
