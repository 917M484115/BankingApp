using BankingApp.Pages.Common;
using BankingApp.Domain.Investing;
using BankingApp.Facade.Investing;
using BankingApp.Data.Investing;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using BankingApp.Infra;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using BankingApp.Domain.Investing.Repositories;
using BankingApp.Domain.Loans;
using BankingApp.Facade.Loan;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BankingApp.Pages.Investing
{
    public abstract class CryptoBasePage<TPage> :
        ViewPage<TPage, ICryptoRepository, Crypto, CryptoView, CryptoData>
        where TPage : PageModel
    {
        protected CryptoBasePage(ICryptoRepository r) : base(r, "Crypto")
        {
        }
        protected internal override Uri pageUrl() => new Uri("/Investing/Crypto", UriKind.Relative);
        protected internal override Crypto toObject(CryptoView v) => new CryptoViewFactory().Create(v);
        protected internal override CryptoView toView(Crypto o) => new CryptoViewFactory().Create(o);

        protected override void createTableColumns()
        {
            createColumn(x => Item.Id);
            createColumn(x => Item.Name);
            createColumn(x => Item.Ticker);
            createColumn(x => Item.Blockchain);
            createColumn(x => Item.Price);

        }
        public override string GetName(IHtmlHelper<TPage> h, int i) => i switch
        {
            4 => getName<double>(h, i),
            _ => base.GetName(h, i)
        };

        public override IHtmlContent GetValue(IHtmlHelper<TPage> h, int i) => i switch
        {
            4 => getValue<double>(h, i),
            _ => base.GetValue(h, i)
        };
        public virtual async Task<IActionResult> OnGetSelectAsync(string id, string sortOrder, string searchString,
        int pageIndex, string fixedFilter, string fixedValue)
        {
            Crypto c = await db.Get(id);
            var page = "/Investing/Calculator";
            return Redirect(page);
        }
    }
}
