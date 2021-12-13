using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApp.Aids;
using BankingApp.Aids.Random;
using BankingApp.Data.ATM;
using BankingApp.Data.Common;
using BankingApp.Data.Investing;
using BankingApp.Domain.ATMs;
using BankingApp.Domain.Common;
using BankingApp.Domain.Investing;

namespace Tests
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
