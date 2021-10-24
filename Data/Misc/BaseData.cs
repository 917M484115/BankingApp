using System.ComponentModel.DataAnnotations;
using BankingApp.Core;


namespace BankingApp.Data.Common
{
    public abstract class BaseData : UniqueItem, IEntityData
    {
        [Timestamp] public byte[] RowVersion { get; set; }
    }
}
