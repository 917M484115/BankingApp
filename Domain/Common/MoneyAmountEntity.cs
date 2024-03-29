﻿using BankingApp.Data.Common;

namespace BankingApp.Domain.Common
{
    public abstract class MoneyAmountEntity <T>: UniqueEntity<T>, IMoneyAmountEntity<T> where T: MoneyAmountData, new()
    {
        protected internal MoneyAmountEntity(T d = null) : base(d) { }

        public virtual double MoneyAmount => Data?.MoneyAmount ?? 0;
    }

}
