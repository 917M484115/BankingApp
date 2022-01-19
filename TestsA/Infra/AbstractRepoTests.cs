using BankingApp.Tests.Infra;
using BankingApp.Data.Common;
using BankingApp.Domain.Common;
using BankingApp.Infra.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Infra {
    public abstract class AbstractRepoTests<TRepo, TDomain, TData>: 
        RepoTests<TRepo, TDomain, TData>
        where TRepo : UniqueEntitiesRepository<TDomain, TData>
        where TDomain : UniqueEntity<TData>
        where TData : UniqueEntityData, new() {
        [TestMethod] public override void IsSealed() => isFalse(type?.IsSealed ?? true);
        [TestMethod] public void IsAbstract() => isTrue(type?.IsAbstract ?? false);

    }
}