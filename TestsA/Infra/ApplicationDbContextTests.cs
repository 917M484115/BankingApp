using BankingApp.Data.Investing;
using BankingApp.Data.Misc;
using BankingApp.Infra;
using BankingApp.Tests;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BankingApp.Tests.Infra
{
    [TestClass]
    public class ApplicationDbContextTests : ClassTests<DbContext>
    {
        private class testClass : ApplicationDbContext {
            public testClass(DbContextOptions<ApplicationDbContext> o) : base(o) { }
            public ModelBuilder RunOnModelCreating() {
                var set = new ConventionSet();
                var mb = new ModelBuilder(set);
                OnModelCreating(mb);

                return mb;
            }

        }
        protected override object createObject() => new InMemoryApplicationDbContext().AppDb;
        [TestMethod] public void CryptoBasketsTest() => isProperty<DbSet<CryptoBasketData>>();
        [TestMethod] public void CryptoBasketItemsTest() => isProperty<DbSet<CryptoBasketItemData>>();
        [TestMethod] public void BlockChainsTest() => isProperty<DbSet<BlockChainData>>();
        [TestMethod] public void CustomersTest() => isProperty<DbSet<CustomerData>>();
        [TestMethod] public void CalculatorsTest() => isProperty<DbSet<CalculatorData>>();
        [TestMethod] public void OrdersTest() => isProperty<DbSet<OrderData>>();
        [TestMethod] public void OrderItemsTest() => isProperty<DbSet<OrderItemData>>();
        [TestMethod] public void CryptoPortfoliosTest() => isProperty<DbSet<CryptoPortfolioData>>();
        [TestMethod] public void InitializeTablesTest() {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase("TestDb").Options;
            var builder = new testClass(options).RunOnModelCreating();
            testEntity<CryptoPortfolioData>(builder);
            testEntity<CryptoBasketData>(builder);
            testEntity<CryptoBasketItemData>(builder);
            testEntity<BlockChainData>(builder);
            testEntity<CustomerData>(builder);
            testEntity<CalculatorData>(builder);
            testEntity<OrderData>(builder);
            testEntity<OrderItemData>(builder);
        }
        private void testEntity<T>(ModelBuilder b) {
            var name = typeof(T).FullName ?? string.Empty;
            var entity = b.Model.FindEntityType(name);
            Assert.IsNotNull(entity, name);
        }
    }
}
