using System;
using BankingApp.Data.Common;

namespace BankingApp.Domain.Common
{
    public abstract class PersonEntity<T> : NamedEntity<T> where T : PersonData, new()
    {

        protected internal PersonEntity(T d = null) : base(d) { }

        public virtual int Age => Data?.Age ?? UnspecifiedInteger;
        public virtual string Country => Data?.Country ?? Unspecified;
    }
}
