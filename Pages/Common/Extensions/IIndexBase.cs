using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace BankingApp.Pages.Common.Extensions
{
    public interface IIndexBase<TPage>
    {
        string GetName(IHtmlHelper<TPage> h, int i);
        IHtmlContent GetValue(IHtmlHelper<TPage> h, int i);
        string ItemId { get; }
        Uri PageUrl { get; }
    }
}
