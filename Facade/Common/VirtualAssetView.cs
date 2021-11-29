﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Facade.Common
{
	public abstract class VirtualAssetView : NamedView
    {
        public string Ticker { get; set; }
        public double Price { get; set; }
    }
}
