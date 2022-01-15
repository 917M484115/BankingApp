﻿using BankingApp.Infra.Common;
using BankingApp.Domain.Investing;
using BankingApp.Domain.Investing.Repositories;
using System.Threading.Tasks;
using BankingApp.Data.Investing;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BankingApp.Infra.Investing
{
    public sealed class CryptoPortfolioRepository : UniqueEntitiesRepository<CryptoPortfolio, CryptoPortfolioData>, ICryptoPortfolioRepository
    {
        public CryptoPortfolioRepository(ApplicationDbContext c) : base(c, c.CryptoPortfolios) { }
        public async Task AddItems(CryptoBasket b,string id)
        {
            foreach (var i in b.Items)
            {
                var cryp = dbSet.FirstOrDefault(c => c.CryptoID==i.CryptoID && c.CustomerID==id);
                if(cryp==null)
                { 
                    var d = new CryptoPortfolioData
                    {
                        CryptoID = i.CryptoID,
                        Units = i.Quantity,
                        CustomerID =b.CustomerID
                    };
                    var portfolioItem = toDomainObject(d);
                    await Add(portfolioItem);
                }
                if(cryp!=null)
                {
                    var old = cryp;
                    old.Units+=i.Quantity;
                    old.CustomerID = b.CustomerID;
                    var newItem = toDomainObject(old);
                    await Update(newItem);
                }
            }
        }

        protected internal override CryptoPortfolio toDomainObject(CryptoPortfolioData d)
            => new CryptoPortfolio(d);
    }
}
