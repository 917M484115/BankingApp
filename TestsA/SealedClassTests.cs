using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests
{
    public abstract class SealedClassTests<TBaseClass> : ClassTests<TBaseClass>
    {
        [TestMethod] public virtual void IsSealed() => isTrue(type?.IsSealed ?? false);
    }
}