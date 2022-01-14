using BankingApp.Aids.Methods;
using BankingApp.Aids.Reflection;
using BankingApp.Data.Investing;
using BankingApp.Domain.Common;
using BankingApp.Domain.Investing.Repositories;
using BankingApp.Domain.Misc;
using BankingApp.Domain.Misc.Repositories;
using System;
using System.Collections.Generic;

namespace BankingApp.Domain.Investing
{
    public sealed class Order : UniqueEntity<OrderData>
    {
        private static string orderId => GetMember.Name<OrderItemData>(x => x.OrderID);
        public Order(OrderData d) : base(d) { }
        public string CustomerID => Data?.CustomerID ?? Unspecified;
        public string Name => $"{CustomerID} {OrderDate}";
        public DateTime OrderDate => Data?.OrderDate ?? UnspecifiedValidTo;
        public Customer Customer => new GetFrom<ICustomersRepository, Customer>().ById(CustomerID);
        public IReadOnlyList<OrderItem> Items =>
            new GetFrom<IOrderItemsRepository, OrderItem>().ListBy(orderId, Id);
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
