namespace BankingApp.Domain.Common
{
    public interface IAccountEntity : IMoneyAmountEntity
    {

        string AccountAddress { get; }

    }

    public interface IAccountEntity<out TData> : IAccountEntity, IMoneyAmountEntity
    {

    }

}