using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace BankingApp.Tests
{

    public abstract class AbstractClassTests<TBaseClass> : BaseClassTests<TBaseClass>
    {
        [TestMethod] public virtual void IsAbstract() => Assert.IsTrue(type.IsAbstract);
        protected override Type getBaseClass() => obj.GetType().BaseType.BaseType;
    }
}