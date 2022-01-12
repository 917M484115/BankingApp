using BankingApp.Data.Investing;
using BankingApp.Domain.Investing;
using BankingApp.Domain.Investing.Repositories;
using BankingApp.Facade.Investing;
using BankingApp.Pages.Common;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BankingApp.Pages.Investing
{
    public abstract class CalculatorsBasePage<TPage> :
        ViewPage<TPage, ICalculatorsRepository, Calculator, CalculatorView, CalculatorData>
        where TPage : PageModel
    {
        protected CalculatorsBasePage(ICalculatorsRepository r) : base(r, "Calculators") { }
        protected internal override Calculator toObject(CalculatorView v) => new CalculatorViewFactory().Create(v);
        protected internal override CalculatorView toView(Calculator o) => new CalculatorViewFactory().Create(o);
        protected override void createTableColumns() { }
    }
}
