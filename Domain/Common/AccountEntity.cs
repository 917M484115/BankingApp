using System;
using BankingApp.Data.Common;
using IdentityServer4.Validation;

namespace BankingApp.Domain.Common
{
    public abstract class AccountEntity<T> : MoneyAmountEntity<T> where T : AccountData, new()
    {
        protected internal AccountEntity(T d) : base(d)
        {
            d.acc();
        }
        
        public virtual string CustomerId => Data?.CustomerId ?? Unspecified;

        public virtual string AccountNickname => Data?.AccountNickname ?? Unspecified;

        public virtual string AccountLocation => Data?.AccountLocation ?? Unspecified;

        public virtual string AccountAddress => Data?.AccountAddress ?? Unspecified;
        //    {
        //        get
        //        {
        //            var a = accountAddress();
        //            if (Data.AccountAddress != null)
        //            {

        //            }
        //            else
        //            {
        //                Data.AccountAddress = accountAddress();
        //}
        //            return string.IsNullOrWhiteSpace(a) ? Unspecified : a;
        //        }
        //    } 
        //    internal void acc()
        //    {
        //        Data.AccountAddress = accountAddress();
        //    }

        //    internal string accountAddress() => add(digitCheckSum, BBAN);
        //    internal string digitCheckSum() => add(countryCode, checkSum);

        //    internal string countryCode()
        //    {
        //        return "EE";
        //    }

        //    internal string BBAN = generateBBAN();
        //    internal static string generateBBAN()
        //    {
        //        Random random = new Random();
        //        string r = "";
        //        for (int i = 0; i < 16; i++)
        //        {
        //            r += random.Next(0, 10).ToString();
        //        }
        //        return r;
        //    }

        //    internal string checkSum = validator();
        //    internal static string validator()
        //    {
        //        double BBAN = double.Parse(generateBBAN());
        //        string r = "";
        //        return r;
        //    }
        //    //TODO checkSum vaja toimima saada ja lugeda andmebaasi KontoNr sisse, muidu teeb iga kord uue

        //    internal static string add(Func<string> head, string tail) =>
        //        (isUnspecified(tail) ? head() : $"{head()}{tail}").Trim();

        //}
    }
}
