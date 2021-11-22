using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace BankingApp.Pages.Common.Extensions
{
    public interface IIndexTable<TPage> :IIndexBase<TPage>
    {
        int ColumnsCount { get; }
        int RowsCount { get; }
        void SetItem(int i);
        string SortOrder { get; }
        string SearchString { get; }
        int PageIndex { get; }
        string FixedFilter { get; }
        string FixedValue { get; }
        Uri GetSortStringExpression(int i);
    }
}
