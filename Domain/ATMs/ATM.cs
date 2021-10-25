using BankingApp.Data.ATM;
using BankingApp.Domain.Common;

namespace BankingApp.Domain.ATMs
{
    public sealed class ATM : MoneyAmountEntity<ATMData>
    {
        public ATM(ATMData d) : base(d) { }
        public string Location => Data?.Location ?? Unspecified;
    }
}
