using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BankingApp.Pages.Common
{
    public interface IUnifiedPage<TPage> where TPage : PageModel
    {
        public string GetName(IHtmlHelper<TPage> h, int i);
        public IHtmlContent GetValue(IHtmlHelper<TPage> h, int i);
    }
}