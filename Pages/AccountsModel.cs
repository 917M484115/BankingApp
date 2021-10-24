using System.Collections.Generic;
using System.Threading.Tasks;
using BankingApp.Infra;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace BankingApp.Pages
{
    public class AccountsModel: PageModel
    {
        //private readonly ApplicationDbContext _context;
        //public SelectList selectList;
        //public AccountsModel(ApplicationDbContext c)
        //{
        //    _context = c;
        //    selectList = new SelectList(SelectList(), "Value", "Text");
        //}
        ////TODO change accountsmodel to viewmodel
        //[BindProperty] public AccountsModel accountsModel { get; set; }
        //public List<SelectListItem> SelectList()
        //{
        //    var selectList = new List<SelectListItem>();
        //    foreach (var item in _context.Account)
        //        selectList.Add(new SelectListItem { Text = "Select Account", Value = item.AccountNickName });
        //    return selectList;
        //}
        //public async Task<IActionResult> OnGetCalculateAsync()
        //{
        //    return Page();
        //}
    }
}
