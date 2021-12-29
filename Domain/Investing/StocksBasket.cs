using BankingApp.Data.Investing;
using BankingApp.Domain.Common;
using BankingApp.Aids.Reflection;
using BankingApp.Domain.Misc;
using System.Collections.Generic;
using BankingApp.Domain.Investing.Repositories;
namespace BankingApp.Domain.Investing
{
    public sealed class StocksBasket : UniqueEntity<StocksBasketData>
    {
        private static string stocksBasketID => GetMember.Name<StocksBasketItemData>(x=>x.StocksBasketID);
        public StocksBasket(StocksBasketData d): base(d) { }
        public string CustomerID =>Data?.CustomerID?? Unspecified;
        public Customer Customer => new GetFrom<ICustomerRepository,Customer>()?.ById(CustomerID);
        public IReadOnlyList<StocksBasketItem> Items =>
            new GetFrom<IStocksBasketItemsRepository,StocksBasketItem>()?.ListBy(stocksBasketID,Id);
        public string Name => $"{CustomerID} {ValidFrom}";
        public decimal TotalPrice
        {
            get
            {
                var t =decimal.Zero;
                foreach(var i in Items)
                {
                    t+=i.TotalPrice;
                }
                return t;
            }
        }
    }
}
