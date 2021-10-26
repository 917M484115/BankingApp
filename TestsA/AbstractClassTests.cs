using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests;

namespace BankingApp.Tests
{

    public abstract class AbstractClassTests<TBaseClass> : BaseClassTests<TBaseClass>
    {
        [TestMethod] public void IsAbstract() => Assert.IsTrue(type.IsAbstract);

    }
}