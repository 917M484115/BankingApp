﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BankingApp.Pages.Common.Extensions
{

    public static class EnumHtml
    {

        public static IHtmlContent EnumEditor<TModel, TResult>(
            this IHtmlHelper<TModel> h, Expression<Func<TModel, TResult>> e)
        {

            var l = new SelectList(Enum.GetNames(typeof(TResult)));

            var s = htmlStrings(h, e, l);

            return new HtmlContentBuilder(s);
        }

        internal static List<object> htmlStrings<TModel, TResult>(IHtmlHelper<TModel> h,
            Expression<Func<TModel, TResult>> e, SelectList l)
        {
            return new List<object> {
                new HtmlString("<dt class=\"col-sm-2\">"),
                h.LabelFor(e, new {@class = "text-dark"}),
                new HtmlString("</dt>"),
                new HtmlString("<dd class=\"col-sm-10\">"),
                h.DropDownListFor(e, l, new {@class = "form-control"}),
                h.ValidationMessageFor(e, "", new {@class = "text-danger"}),
                new HtmlString("</dd>")
            };
        }

    }

}