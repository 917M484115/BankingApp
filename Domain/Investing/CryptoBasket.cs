using BankingApp.Data.Investing;
using BankingApp.Domain.Common;
using BankingApp.Aids.Reflection;
using BankingApp.Domain.Misc;
using System.Collections.Generic;
using BankingApp.Domain.Investing.Repositories;
using BankingApp.Domain.Misc.Repositories;

namespace BankingApp.Domain.Investing
{
    public sealed class CryptoBasket : UniqueEntity<CryptoBasketData>
    {
        private static string cryptoBasketID => GetMember.Name<CryptoBasketItemData>(x => x.CryptoBasketID);
        public CryptoBasket(CryptoBasketData d) : base(d) { }
        public string CustomerID => Data?.CustomerID ?? Unspecified;
        public Customer Customer => new GetFrom<ICustomersRepository, Customer>()?.ById(CustomerID);
        public IReadOnlyList<CryptoBasketItem> Items =>
            new GetFrom<ICryptoBasketItemsRepository, CryptoBasketItem>()?.ListBy(cryptoBasketID, Id);
        public string Name => $"{CustomerID} {ValidFrom}";
        public decimal TotalPrice
        {
            get
            {
                var t = decimal.Zero;
                foreach (var i in Items)
                {
                    t += i.TotalPrice;
                }
                return t;
            }
        }
    }
}
