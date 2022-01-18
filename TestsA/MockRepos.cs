using System;
using System.Threading.Tasks;
using BankingApp.Aids.Random;
using BankingApp.Data.ATM;
using BankingApp.Data.Common;
using BankingApp.Data.Misc;
using BankingApp.Data.Investing;
using BankingApp.Domain.ATMs;
using BankingApp.Domain.Common;
using BankingApp.Domain.Investing;
using BankingApp.Domain.Investing.Repositories;
using BankingApp.Domain.Misc;
using BankingApp.Domain.Misc.Repositories;

namespace BankingApp.Tests
{
    internal static class MockRepos
    {
	    public static IATMRepository ATMRepo(string id, out ATMData d)
		    => createMockRepo<MockATMRepo, ATM, ATMData>(
			    id, d => new ATM(d), out d);
        public static IATMManagerRepository ATMManagerRepo(string id, out ATMManagerData d)
            => createMockRepo<MockATMManagerRepo, ATMManager, ATMManagerData>(
                id, d => new ATMManager(d), out d);
        public static IInvestmentRepository InvestmentRepo(string id, out InvestmentData d)
            => createMockRepo<MockInvestmentRepo, Investment, InvestmentData>(
                id, d => new Investment(d), out d);



        public static ICryptoBasketItemsRepository CryptoBasketItemsRepo(string id, out int count)
            => createMockRepo<MockCryptoBasketItemsRepo, CryptoBasketItem, CryptoBasketItemData>(
                d => setRelatedId(d, id), d => new CryptoBasketItem(d), out count);
        public static ICryptoBasketsRepository CryptoBasketsRepo(string id, out CryptoBasketData d)
            => createMockRepo<MockCryptoBasketsRepo, CryptoBasket, CryptoBasketData>(
                id, d => new CryptoBasket(d), out d);
        public static IBlockChainsRepository BlockChainsRepo(string id, out BlockChainData d)
            => createMockRepo<MockBlockChainsRepo, BlockChain, BlockChainData>(
                id, d => new BlockChain(d), out d);
        public static ICustomersRepository Customers(string id, out CustomerData d)
            => createMockRepo<MockCustomersRepo, Customer, CustomerData>(
                id, d => new Customer(d), out d);
        public static ICalculatorsRepository CalculatorsRepo(string id, out CalculatorData d)
           => createMockRepo<MockCalculatorsRepo, Calculator, CalculatorData>(
               id, d => new Calculator(d), out d);
        public static IOrderItemsRepository OrderItemsRepo(string id, out int count)
           => createMockRepo<MockOrderItemsRepo, OrderItem, OrderItemData>(
               d => setRelatedId(d, id), d => new OrderItem(d), out count);
        public static ICryptoRepository CryptoRepo(string id, out CryptoData d)
            => createMockRepo<MockCryptoRepo, Crypto, CryptoData>(
                id, d => new Crypto(d), out d);
        public static ICryptoPortfolioRepository CrpytoPortfolioRepo(string id, out CryptoPortfolioData d)
           => createMockRepo<MockCryptoPortfolioRepo, CryptoPortfolio, CryptoPortfolioData>(
               id, d => new CryptoPortfolio(d), out d);


        public static ICryptoRepository Cryptos()
          => createMockRepo<MockCryptoRepo, Crypto, CryptoData>();
        internal static ICryptoPortfolioRepository Portfolios()
           => createMockRepo<MockCryptoPortfolioRepo, CryptoPortfolio, CryptoPortfolioData>();
        public static IBlockChainsRepository BlockChains()
            => createMockRepo<MockBlockChainsRepo, BlockChain, BlockChainData>();
        internal static ICustomersRepository Customers()
            => createMockRepo<MockCustomersRepo, Customer, CustomerData>();
        internal static ICryptoBasketsRepository CryptoBaskets()
            => createMockRepo<MockCryptoBasketsRepo, CryptoBasket, CryptoBasketData>();
        internal static IOrdersRepository Orders()
            => createMockRepo<MockOrdersRepo, Order, OrderData>();
        internal static IOrderItemsRepository OrderItems()
            => createMockRepo<MockOrderItemsRepo, OrderItem, OrderItemData>();
        internal static ICryptoBasketItemsRepository CryptoBasketItems()
            => createMockRepo<MockCryptoBasketItemsRepo, CryptoBasketItem, CryptoBasketItemData>();
        public static ICalculatorsRepository Calculators()
            => createMockRepo<MockCalculatorsRepo,Calculator,CalculatorData>();

        private class MockCustomersRepo : MockRepo<Customer>, ICustomersRepository { }
        private class MockCryptoRepo : MockRepo<Crypto>, ICryptoRepository { }
        private class MockBlockChainsRepo : MockRepo<BlockChain>, IBlockChainsRepository { }
        private class MockCalculatorsRepo : MockRepo<Calculator>, ICalculatorsRepository { }
        private class MockCryptoBasketsRepo : MockRepo<CryptoBasket>, ICryptoBasketsRepository
        {
            public Task Close(CryptoBasket b)
            {
                throw new NotImplementedException();
            }

            public Task<CryptoBasket> GetLatestForUser(string name)
            {
                throw new NotImplementedException();
            }
        }
        private class MockOrdersRepo : MockRepo<Order>, IOrdersRepository
        {
            public Task<Order> GetLatestForUser(string name)
            {
                throw new NotImplementedException();
            }
        }
        private class MockOrderItemsRepo : MockRepo<OrderItem>, IOrderItemsRepository
        {
            public Task AddItems(Order o, CryptoBasket b) => throw new NotImplementedException();

            public Task AddOrderItem(string OrderID, int Units, string CryptoID)
            {
                throw new NotImplementedException();
            }
            public async Task Delete(Order p, OrderItem c)
            {
                throw new NotImplementedException();
            }
        }
        private class MockCryptoPortfolioRepo : MockRepo<CryptoPortfolio>, ICryptoPortfolioRepository
        {
            public Task AddItems(CryptoBasket b, string id)
            {
                throw new NotImplementedException();
            }

            public Task<int> SellCrypto(string id, string CustomerID, int sellAmount)
            {
                throw new NotImplementedException();
            }
        }
        private class MockCryptoBasketItemsRepo : MockRepo<CryptoBasketItem>, ICryptoBasketItemsRepository
        {
            public Task<CryptoBasketItem> Add(CryptoBasket b, Crypto c) => throw new NotImplementedException();


            Task ICryptoBasketItemsRepository.Delete(CryptoBasket p, CryptoBasketItem c)
            {
                throw new NotImplementedException();
            }
        }

        private static OrderItemData setRelatedId(OrderItemData d, string id)
        {
            d.OrderID = id;
            d.Units = GetRandom.UInt8(1, 5);
            return d;
        }
        private static CryptoBasketItemData setRelatedId(CryptoBasketItemData d, string id)
        {
            d.CryptoBasketID = id;
            d.Quantity = GetRandom.UInt8(1, 5);
            return d;
        }







        private class MockATMRepo : MockRepo<ATM>, IATMRepository { }
        private class MockATMManagerRepo : MockRepo<ATMManager>, IATMManagerRepository { }
        private class MockInvestmentRepo : MockRepo<Investment>, IInvestmentRepository { }










        private static TRepo createMockRepo<TRepo, TObj, TData>()
          where TRepo : IRepository<TObj>, new()
          where TData : UniqueEntityData => new TRepo();
        private static TRepo createMockRepo<TRepo, TObj, TData>(string id, Func<TData, TObj> toObject, out TData data)
          where TRepo : IRepository<TObj>, new()
          where TData : UniqueEntityData
        {
            data = null;
            var count = GetRandom.UInt8(10, 20);
            var idx = GetRandom.UInt8(0, count);
            var repo = new TRepo();
            for (var i = 0; i < count; i++)
            {
                var d = GetRandom.Object<TData>();
                if (idx == i)
                {
                    d.Id = id;
                    data = d;
                }
                repo.Add(toObject(d)).GetAwaiter();
            }
            return repo;
        }
        private static TRepo createMockRepo<TRepo, TObj, TData>(
            Func<TData, TData> setRelatedId, Func<TData, TObj> toObject, out int itemsCount)
           where TRepo : IRepository<TObj>, new()
           where TData : UniqueEntityData
        {
            itemsCount = GetRandom.UInt8(3, 7);

            var repo = new TRepo();
            for (var i = 0; i < itemsCount; i++)
            {
                if (GetRandom.Bool()) repo.Add(toObject(GetRandom.Object<TData>())).GetAwaiter();
                var d = GetRandom.Object<TData>();
                d = setRelatedId(d);
                repo.Add(toObject(d)).GetAwaiter();
                if (GetRandom.Bool()) repo.Add(toObject(GetRandom.Object<TData>())).GetAwaiter();
            }
            return repo;
        }
    }
}
