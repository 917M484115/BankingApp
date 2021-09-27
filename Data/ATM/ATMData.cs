using BankingApp.Data.Common;

namespace BankingApp.Data
{
    public sealed class ATMData : MoneyAmountData
    {
        public string Location { get; set; }
        public string Manager { get; set; }

    }
}
