using BankingApp.Data.Investing;
using BankingApp.Domain.Common;
using BankingApp.Aids.Reflection;
using BankingApp.Domain.Misc;
using System.Collections.Generic;
using BankingApp.Domain.Investing.Repositories;
namespace BankingApp.Domain.Investing
{
    public sealed class CryptoPortfolio : UniqueEntity<CryptoPortfolioData>
    {
        private static string cryptoPortfolioID => GetMember.Name<CryptoPortfolioItemData>(x => x.CryptoPortfolioID);
        public CryptoPortfolio(CryptoPortfolioData d) : base(d) { }
        public string CustomerID => Data?.CustomerID ?? Unspecified;
        public Customer Customer => new GetFrom<ICustomerRepository, Customer>()?.ById(CustomerID);
        public IReadOnlyList<CryptoPortfolioItem> Items =>
            new GetFrom<ICryptoPortfolioItemsRepository, CryptoPortfolioItem>()?.ListBy(cryptoPortfolioID, Id);
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
