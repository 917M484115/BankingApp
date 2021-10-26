using BankingApp.Domain.Common;

namespace BankingApp.Data.Common
{
    public interface IMoneyAmountEntity : IUniqueEntity
    {

        double MoneyAmount { get; }

    }

    public interface IMoneyAmountEntity<out TData> : IMoneyAmountEntity, IUniqueEntity
    {

    }

}
