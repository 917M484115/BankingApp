using BankingApp.Data.ATM;
using BankingApp.Domain.Common;

namespace BankingApp.Domain.ATMs
{
    public sealed class ATMManager : PersonEntity<ATMManagerData>
    {
        public ATMManager(ATMManagerData d) : base(d) { }
    }
}

