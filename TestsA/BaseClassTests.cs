using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests
{
    public abstract class BaseClassTests<TBaseClass> : BaseTests
    {
        protected object obj
        {
            get => objUnderTests;
            set => objUnderTests = value;
        }
        protected abstract object createObject();
        protected virtual Type getBaseClass() => typeof(TBaseClass);

        [TestInitialize]
        public virtual void TestInitialize()
        {
            type = getTestableClassType();
            obj = createObject();
        }
        [TestMethod] public void CanCreateTest() => isNotNull(createObject());
        [TestMethod] public void IsInheritedTest() => areEqual(getBaseClass(), type?.BaseType);
    }
}
