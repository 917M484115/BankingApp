﻿using BankingApp.Data.Misc;
using BankingApp.Domain.Common;

namespace BankingApp.Domain.Misc
{
	public sealed class Bank : NamedEntity<BankData>
	{
		public Bank(BankData d) : base(d) { }
	}
}
