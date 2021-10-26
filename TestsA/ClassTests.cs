using BankingApp.Aids;
using Tests;

namespace BankingApp.Tests
{
    public abstract class ClassTests<TBaseClass> : BaseClassTests<TBaseClass>
    {
        protected override object createObject() => GetRandom.ObjectOf(type);
    }
}
