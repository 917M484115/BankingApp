using BankingApp.Domain.Investing.Repositories;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Pages.Investing
{
    public sealed class CalculatorsManagerPage : CalculatorsBasePage<CalculatorsManagerPage>
    {
        public CalculatorsManagerPage(ICalculatorsRepository r) : base(r) { }
        protected internal override Uri pageUrl() => new("/Manager/Calculators", UriKind.Relative);
        protected override void createTableColumns()
        {
            createColumn(x => Item.Id);
            createColumn(x => Item.Name);
            createColumn(x => Item.APY);
        }
        public override string GetName(IHtmlHelper<CalculatorsManagerPage> h, int i) => i switch
        {
            2 => getName<double>(h, i),
            _ => base.GetName(h, i)
        };
        public override IHtmlContent GetValue(IHtmlHelper<CalculatorsManagerPage> h, int i) => i switch
        {
            2 => getValue<double>(h,i),
            _ => base.GetValue(h, i)
        };
    }
}
