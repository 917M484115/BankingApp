namespace BankingApp.Data.Common
{
    public abstract class AccountData : MoneyAmountData
    {
        public string AccountAddress { get; set; }

        public string CustomerId { get; set; }
        public string AccountLocation { get; set; }

        //Account type?
    }
}
