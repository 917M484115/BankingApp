using BankingApp.Infra;
using Microsoft.EntityFrameworkCore;

namespace BankingApp.Tests.Infra
{
    internal class InMemoryApplicationDbContext
    {
        public ApplicationDbContext AppDb;
        public InMemoryApplicationDbContext()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase("TestDb").Options;
            AppDb = new ApplicationDbContext(options);
        }
    }
}
