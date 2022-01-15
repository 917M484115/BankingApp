using System;

namespace BankingApp.Data.Common
{
    public abstract class UniqueEntityData : PeriodData
    {
        public string Code { get; set; }
        public string Id { get; set; } = Guid.NewGuid().ToString();

    }
}
