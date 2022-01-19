using BankingApp.Tests.Infra;
using BankingApp.Aids.Random;
using BankingApp.Data.Common;
using BankingApp.Domain.Common;
using BankingApp.Infra;
using BankingApp.Infra.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Threading.Tasks;

namespace BankingApp.Tests.Infra {
    public abstract class RepoTests<TRepo, TDomain, TData>
        : SealedClassTests<UniqueEntitiesRepository<TDomain, TData>>
        where TRepo : UniqueEntitiesRepository<TDomain, TData>
        where TDomain : UniqueEntity<TData>
        where TData : UniqueEntityData, new() {
        protected ApplicationDbContext InvestingDb;
        protected TDomain item;
        protected int count;
        protected int idx;
        protected TRepo repo;
        protected DbSet<TData> dbSet;
        [TestInitialize]
        public override void TestInitialize() {
            initInMemoryDatabase();
            base.TestInitialize();
            initRepoAndDbSet();
            initDatabaseItems();
            isInDb(item);
        }
        [TestCleanup]
        public override void TestCleanup() {
            cleanDbSet();
            base.TestCleanup();
        }
        [TestMethod]
        public async Task GetTest() {
            var l = await repo.Get();
            areEqual(count, l.Count);
        }
        [TestMethod] public void GetByIdAsyncTest() { }
        [TestMethod]
        public async Task DeleteTest() {
            await repo.Delete(item.Id);
            isNotInDb(item.Id);
            areEqual(count - 1, dbSet.Count());
        }
        [TestMethod]
        public async Task AddTest() {
            item = getRandomItem();
            isNotInDb(item.Id);
            await repo.Add(item);
            isInDb(item);
            areEqual(count + 1, dbSet.Count());
        }
        [TestMethod]
        public async Task UpdateTest() {
            var d1 = random<TData>();
            d1.Id = item.Id;
            item = toObject(d1);
            await repo.Update(item);
            isInDb(item);
            areEqual(count, dbSet.Count());
        }
        [TestMethod]
        public void GetByIdTest() {
            var o = repo.GetById(item.Id) as TDomain;
            areEqualProperties(o.Data, item.Data);
            areEqual(count, dbSet.Count());
        }
        private TDomain getRandomItem() => toObject(random<TData>());
        protected abstract TDomain toObject(TData data);

        private void initRepoAndDbSet() {
            repo = obj as TRepo;
            dbSet = repo.dbSet;
            areEqual(0, dbSet.Count());
        }
        private void initDatabaseItems() {
            count = GetRandom.UInt8(10, 20);
            idx = GetRandom.UInt8(0, (byte)count);
            for (var i = 0; i < count; i++) {
                var o = getRandomItem();
                repo.Add(o).GetAwaiter();
                if (i != idx) continue;
                item = o;
            }
            areEqual(count, dbSet.Count());
        }
        private void initInMemoryDatabase() {
            var im = new InMemoryApplicationDbContext();
            InvestingDb = im.AppDb;
        }
        private void cleanDbSet() {
            foreach (var p in dbSet) InvestingDb.Entry(p).State = EntityState.Deleted;
            InvestingDb.SaveChanges();
        }
        private void isNotInDb(string id) {
            var actual = dbSet.Find(id);
            isNull(actual);
        }
        private void isInDb(TDomain i) {
            var actual = dbSet.Find(i.Id);
            areEqualProperties(i.Data, actual);
        }
    }
}