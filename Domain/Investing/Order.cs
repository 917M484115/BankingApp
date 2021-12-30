using BankingApp.Aids.Methods;
using BankingApp.Aids.Reflection;
using BankingApp.Data;
using BankingApp.Domain.Common;
using BankingApp.Domain.Investing.Repositories;
using BankingApp.Domain.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Domain.Investing
{
    public sealed class Order : UniqueEntity<OrderData>
    {
        private static string orderId => GetMember.Name<OrderItemData>(x => x.OrderId);
        public Order(OrderData d) : base(d) { }
        public string BuyerId => Data?.CustomerId ?? Unspecified;
        public string Name => $"{BuyerId} {OrderDate}";
        public DateTime OrderDate => Data?.OrderDate ?? UnspecifiedValidTo;
        public Customer Customer => new GetFrom<ICustomerRepository, Customer>().ById(BuyerId);
        public IReadOnlyList<OrderItem> Items =>
            new GetFrom<ICryptoOrderItemsRepository, OrderItem>().ListBy(orderId, Id);
        public decimal TotalPrice
        {
            get
            {
                return Safe.Run(() => {
                    var t = decimal.Zero;
                    foreach (var i in Items)
                    {
                        t += i.TotalPrice;
                    }
                    return t;
                }, decimal.MaxValue);
            }
        }
    }
}
