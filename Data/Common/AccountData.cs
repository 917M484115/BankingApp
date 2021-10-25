namespace BankingApp.Data.Common
{
    //TODO work on one to many relationship
    public abstract class AccountData : MoneyAmountData
    {
        public string AccountAddress { get; set; }
        public string AccountNickname { get;set;}
        public string CustomerId { get; set; }
        public string AccountLocation { get; set; }

        //Account type?
    }
}
