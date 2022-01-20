using System;
using BankingApp.Aids.Methods;
using BankingApp.Aids.Random;
using BankingApp.Data.Common;
using IdentityServer4.Validation;

namespace BankingApp.Domain.Common
{
    public abstract class AccountEntity<T> : MoneyAmountEntity<T> where T : AccountData, new()
    {
        protected internal AccountEntity(T d) : base(d)
        {
        }

        public virtual string AccountOwnerName => Data?.AccountOwnerName ?? Unspecified;

        public virtual string AccountLocation => Data?.AccountLocation ?? Unspecified;

        public virtual string AccountAddress => Data?.AccountAddress ?? Unspecified;

    }

}
