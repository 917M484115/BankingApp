using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Domain.Common
{
    public interface IPersonEntity : INamedEntity
    { 
    }

    public interface IPersonEntity<out TData> : IPersonEntity, INamedEntity<TData>
    {

    }

    //TODO vaadata pärimised täpsemalt üle.
}
