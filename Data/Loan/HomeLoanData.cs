using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Data.Loan
{
    public sealed class HomeLoanData : LoanData
    {
        public double HomeValue { get; set; }
    }
}
