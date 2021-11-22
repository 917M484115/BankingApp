namespace BankingApp.Domain.Common
{
    public interface IMoneyAmountEntity : IUniqueEntity
    {

        double MoneyAmount { get; }

    }

    public interface IMoneyAmountEntity<out TData> : IMoneyAmountEntity, IUniqueEntity
    {

    }

}
