using BankingApp.Pages.Common.Aids;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using BankingApp.Pages.Common.Extensions;
using BankingApp.Pages.Investing;
namespace BankingApp.Pages.Common.CalcExtensions
{
    public static class CalculatorHTMLExtension
    {
        public static IHtmlContent ShowCalc<TPage>(this IHtmlHelper<TPage> h)
        {
            var s = HtmlStrings<TPage>();
            return new HtmlContentBuilder(s);
        }
        internal static List<object> HtmlStrings<TPage>()
        {
            string link = @"""C:\Users\Professional\source\repos\BankingApp4\Pages\Common\CalcExtensions\CalcCSS.css""";
            string rel = @"""stylesheet""";
            string type = @"""text/css""";
            var l = new List<object> {
                new HtmlString("<link href="+link+" rel="+rel+" type="+ type+">"),
            };
            return l;
        }
    }
}
