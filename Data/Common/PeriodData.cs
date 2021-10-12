using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Data.Common
{
    public abstract class PeriodData : BaseEntity
    {
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
    }
}
