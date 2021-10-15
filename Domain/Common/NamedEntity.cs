using BankingApp.Data.Common;

namespace BankingApp.Domain.Common
{
 

public abstract class NamedEntity<T> : UniqueEntity<T> where T : NamedData, new()
{

    protected internal NamedEntity(T d = null) : base(d) { }

    public virtual string Name => Data?.Name ?? Unspecified;

}
}

