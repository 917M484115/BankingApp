using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApp.Data.Common;

namespace BankingApp.Domain.Common
{
    public abstract class UniqueEntity<T> : Entity<T>, IUniqueEntity<T> where T : UniqueEntityData, new()
    {

        protected internal UniqueEntity(T d = null) : base(d) { }

        public virtual string Id => Data?.Id ?? Unspecified;
    }
}
