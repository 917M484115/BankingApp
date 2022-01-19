using BankingApp.Tests.Pages;
using BankingApp.Pages.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace BankingApp.Tests.Pages {
    public abstract class AuthorizedPageTests<TPage, TBaseClass> 
              : CommonPageTests<TPage, TBaseClass> 
        where TPage: PageModel, IUnifiedPage<TPage> {
       
        [TestMethod] public override void IsAbstract() => Assert.IsFalse(type.IsAbstract);
        [TestMethod] public void IsSealed() => Assert.IsTrue(type.IsSealed);
        protected override Type getBaseClass() => obj.GetType().BaseType;
    }
}
