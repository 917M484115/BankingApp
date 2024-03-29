﻿using BankingApp.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Data.Investing
{
    [TestClass]
    public class CryptoBasketItemDataTests : SealedClassTests<UniqueEntityData>
    {

        [TestMethod] public void CryptoBasketIDTest() => isProperty<string>();
        [TestMethod] public void CryptoIDTest() => isProperty<string>();
        [TestMethod] public void QuantityTest() => isProperty<int>(false);
    }
}
