using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using BankingApp.Domain;
//using BankingApp.Data.ATM;
//using BankingApp.Domain.ATMs;
//using BankingApp.Facade.Common;

//namespace BankingApp.Facade.ATM
//{
//	public sealed class ATMViewFactory : AbstractViewFactory<ATMData, ATM, ATMView>
//	{
//		protected internal override ATM toObject(ATMData d) => new ATM(d);
//		public override ATMView Create(ATM o)
//		{
//			var v = base.Create(o);
//			v.Location = o?.Location;
//			return v;
//		}
//	}
//}
