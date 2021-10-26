using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Domain.Common
{
    public interface IPersonEntity : INamedEntity
    {
        string Name { get; }
        string Code { get; }

    }

    public interface IPersonEntity<out TData> : IPersonEntity, INamedEntity<TData>
    {

    }

    //TODO vaadata pärimised täpsemalt üle.
}
