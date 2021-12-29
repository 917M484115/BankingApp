using BankingApp.Data.Investing;
using BankingApp.Domain.Common;
using BankingApp.Aids.Reflection;
using BankingApp.Domain.Misc;
using System.Collections.Generic;
using BankingApp.Domain.Investing.Repositories;
namespace BankingApp.Domain.Investing
{
    public sealed class StocksPortfolio : UniqueEntity<StocksPortfolioData>
    {
        private static string stocksPortfolioID => GetMember.Name<StocksPortfolioItemData>(x=>x.StocksPortfolioID);
        public StocksPortfolio(StocksPortfolioData d): base(d) { }
        public string CustomerID =>Data?.CustomerID?? Unspecified;
        public Customer Customer => new GetFrom<ICustomerRepository,Customer>()?.ById(CustomerID);
        public IReadOnlyList<StocksPortfolioItem> Items =>
            new GetFrom<IStocksPortfolioItemsRepository,StocksPortfolioItem>()?.ListBy(stocksPortfolioID,Id);
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
