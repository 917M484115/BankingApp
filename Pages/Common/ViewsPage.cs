﻿using System;
using BankingApp.Data.Common;
using BankingApp.Domain.Common;
using BankingApp.Facade.Common;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BankingApp.Pages.Common {
    public abstract class ViewsPage<TPage, TRepository, TDomain, TView, TData> :
        ViewPage<TPage, TRepository, TDomain, TView, TData>
        where TPage : PageModel
        where TRepository : class, ICrudMethods<TDomain>, ISorting, IFiltering, IPaging
        where TDomain : IEntity<TData>
        where TData : PeriodData, new()
        where TView : PeriodView {
        protected ViewsPage(TRepository r, string title) : base(r, title) { }

        protected internal Uri createUri(int i) {
            var uri = CreateUrl.ToString();
            uri += $"&switchOfCreate={i}";

            return new Uri(uri, UriKind.Relative);
        }
    }
}
