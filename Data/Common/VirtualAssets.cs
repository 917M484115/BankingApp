using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Data.Common
{
    public abstract class VirtualAssets : NamedEntityData
    {
        public string Ticker {get;set;}
        public double Price { get;set;}
    }
}
