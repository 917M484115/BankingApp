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
        [TestMethod] public void IsAuthorizedTested() {
            var t = objUnderTests.GetType();
            var list = t?.GetCustomAttributes(typeof(AuthorizeAttribute), true);
            var a = list?.Cast<AuthorizeAttribute>().Single();
            if (a is null)
                isFalse(true, $"Class \"{t.Name}\" does not require authorization.");
        }
        [TestMethod] public override void IsAbstract() => Assert.IsFalse(type.IsAbstract);
        [TestMethod] public void IsSealed() => Assert.IsTrue(type.IsSealed);
        protected override Type getBaseClass() => obj.GetType().BaseType;
    }
}
