using System;
using BankingApp.Aids.Methods;
using BankingApp.Aids.Random;
using BankingApp.Data.Common;
using IdentityServer4.Validation;

namespace BankingApp.Domain.Common
{
    public abstract class AccountEntity<T> : MoneyAmountEntity<T> where T : AccountData, new()
    {
        protected internal AccountEntity(T d) : base(d)
        {
        }
        
        public virtual string CustomerId => Data?.CustomerId ?? Unspecified;

        public virtual string AccountNickname => Data?.AccountNickname ?? Unspecified;

        public virtual string AccountLocation => Data?.AccountLocation ?? Unspecified;

        public virtual string AccountAddress => Data?.AccountAddress ?? Unspecified;


        

        internal string accountAddress() => add(digitCheckSum, generateBBAN());
        internal string digitCheckSum() => add(countryCode, validator());



        internal string countryCode()
        {
            return "EE";
        }

        internal string generateBBAN()
        {
            string r = "";
            for (int i = 0; i < 16; i++)
            {
                r += GetRandom.Int32(0, 9); ;
            }
            return r;
        }

        internal string validator()
        {
            double BBAN = double.Parse(generateBBAN());
            string r = "";
            return r;
        }

        internal string add(Func<string> head, string tail) =>
            (isUnspecified(tail) ? head() : $"{head()}{tail}").Trim();
    }
}
