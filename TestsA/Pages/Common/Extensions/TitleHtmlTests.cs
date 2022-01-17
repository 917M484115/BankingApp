using BankingApp.Pages.Common.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Pages.Common.Extensions {
    [TestClass]
    public class TitleHtmlTests : BaseTests {
        [TestInitialize]
        public void TestInitialize()
            => type = typeof(TitleHtml);


        //public static IHtmlContent Title(
        //    this IHtmlHelper h, string title) {
        //    if (h == null) throw new ArgumentNullException(nameof(h));
        //    h.ViewData["Title"] = title;
        //    var s = htmlStrings(title);
        //    return new HtmlContentBuilder(s);
        //}

        //internal static List<object> htmlStrings(string title) {
        //    return new List<object> {
        //        new HtmlString("<h1>"),
        //        new HtmlString(title),
        //        new HtmlString("</h1>")
        //    };
        //}

    }
}
