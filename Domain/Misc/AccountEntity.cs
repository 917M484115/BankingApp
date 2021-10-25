using BankingApp.Data.Common;
using BankingApp.Domain.Common;

namespace BankingApp.Domain.Misc
{
    public abstract class AccountEntity<T> : MoneyAmountEntity<T> where T : AccountData, new()
    {
        protected internal AccountEntity(T d) : base(d) { }
        public virtual string CustomerId => Data?.CustomerId ?? Unspecified;

        public virtual string AccountAddress => Data?.AccountAddress ?? Unspecified;

        public virtual string AccountNickName => Data?.AccountNickName ?? Unspecified;

        public virtual string AccountLocation => Data?.AccountLocation ?? Unspecified;
    }
}
