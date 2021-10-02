using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BankingApp.Core.Extensions
{
    public static class ShowHtml
    {
        public static IHtmlContent Show<TModel, TResult>(
            this IHtmlHelper<TModel> html,
            Expression<Func<TModel, TResult>> e) => Show(html, e, e);
        public static IHtmlContent Show<TModel, TResult1, TResult2>(
            this IHtmlHelper<TModel> html,
            Expression<Func<TModel, TResult1>> label,
            Expression<Func<TModel, TResult2>> value = null)
        {
            var labelStr = html.DisplayNameFor(label);
            var valueStr = (value is null) ? getValue(html, label) : getValue(html, value);
            return html.Show(labelStr, valueStr);
        }
        public static IHtmlContent Show<TModel>(this IHtmlHelper<TModel> h, string label, string value)
        {
            if (h == null) throw new ArgumentNullException(nameof(h));
            var s = htmlStrings(h, label, value);
            return new HtmlContentBuilder(s);
        }
        internal static List<object> htmlStrings<TModel>(
            IHtmlHelper<TModel> h, string label, string value)
        {
            return new List<object> {
                new HtmlString("<dt class=\"col-sm-2\">"),
                h.Raw(label),
                new HtmlString("</dt>"),
                new HtmlString("<dd class=\"col-sm-10\">"),
                h.Raw(value),
                new HtmlString("</dd>")
            };
        }
        internal static string getValue<TModel, TResult>(IHtmlHelper<TModel> html, Expression<Func<TModel, TResult>> e)
        {
            var value = html.DisplayFor(e);
            var writer = new System.IO.StringWriter();
            value.WriteTo(writer, HtmlEncoder.Default);
            return writer.ToString();
        }
    }
}