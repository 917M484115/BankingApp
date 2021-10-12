using BankingApp.Core;
using BankingApp.Data.Common;

namespace BankingApp.Domain.Common
{
    public interface IPersonEntity : IBaseEntity
    {
        public string LastName { get; }
        public string FirstMidName { get; }
        public string FullName { get; }
        public int Age { get; }
    }
    public abstract class PersonEntity<TData> : BaseEntity<TData>, IPersonEntity
        where TData : PersonData, new()
    {
        protected PersonEntity() : this(null) { }
        protected PersonEntity(TData d) : base(d) { }
        public string LastName => Data?.LastName ?? "Unspecified";
        public string FirstMidName => Data?.FirstMidName ?? "Unspecified";
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }

        public int Age => Data?.Age ?? 20;
    }
}
