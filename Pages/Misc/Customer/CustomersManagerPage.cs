using BankingApp.Domain.Misc;
using BankingApp.Domain.Misc.Repositories;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Pages.Misc
{
    public sealed class CustomersManagerPage :CustomersBasePage<CustomersManagerPage>
    {
        public CustomersManagerPage(ICustomersRepository r) : base(r) { }
        protected internal override Uri pageUrl() => new("/Manager/Customers", UriKind.Relative);
        protected override void createTableColumns()
        {
            createColumn(x => Item.Id);
            createColumn(x => Item.Name);
            createColumn(x => Item.Age);
            createColumn(x => Item.Country);
        }
        public override string GetName(IHtmlHelper<CustomersManagerPage> h, int i) => i switch
        {
            2 => getName<int>(h,i),
            _ => base.GetName(h, i)
        };
        public override IHtmlContent GetValue(IHtmlHelper<CustomersManagerPage> h, int i) => i switch
        {
            2 => getValue<int>(h, i),
            _ => base.GetValue(h, i)
        };
    }
}
