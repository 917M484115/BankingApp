using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApp.Aids;
using BankingApp.Data.Common;
using BankingApp.Data.Loan;
using BankingApp.Domain.Common;
using BankingApp.Domain.Loans;

namespace BankingApp.Facade.Common
{
    public abstract class LoanViewFactory<TData, TObject, TView> : AbstractViewFactory<LoanData, Loan<T>, LoanView>
        where T : LoanData, new()
        where TData : PeriodData, new()
        where TView : PeriodView, new()
        where TObject : IEntity<TData>
    {

		public virtual TObject Create(TView v)
        {
            var d = new TData();
            copyMembers(v, d);
            return toObject(d);
        }
        internal protected abstract TObject toObject(TData d);
        internal protected virtual void copyMembers(TView v, TData d) => Copy.Members(v, d);
        internal protected virtual void copyMembers(TData d, TView v) => Copy.Members(d, v);
        public virtual TView Create(TObject o)
        {
            var v = new TView();
            copyMembers(o.Data, v);
            return v;
        }


	}
}
