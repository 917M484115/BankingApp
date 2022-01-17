using BankingApp.Facade.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Tests.Facade.Misc
{
    [TestClass]
    public class CustomerViewTests : SealedClassTests<PersonView>
    {
        [TestMethod] public void AgeTest() => isDisplayProperty<int>("Age",false);
        [TestMethod] public void CountryTest() => isDisplayProperty<string>("Country");
    }
}
