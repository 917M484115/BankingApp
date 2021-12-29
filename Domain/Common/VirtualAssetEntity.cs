using BankingApp.Data.Common;

namespace BankingApp.Domain.Common
{
    public abstract class VirtualAssetEntity<T> : NamedEntity<T> where T : VirtualAssetData, new()
    {
        protected internal VirtualAssetEntity(T d = null) : base(d) { }

        public virtual string Ticker => Data?.Ticker ?? Unspecified;
        public virtual decimal Price => Data?.Price ?? UnspecifiedDecimal;

    }
}
