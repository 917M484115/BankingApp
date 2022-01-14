﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests
{
    public class TestAssertions
    {
        protected static void notTested(string message = null) => Assert.Inconclusive(message);
        protected static void notTested(string message, params object[] parameters)
            => Assert.Inconclusive(message, parameters);
        protected static void areEqual<TExpected, TActual>(TExpected e, TActual a, string message = null)
            => Assert.AreEqual(e, a, message);
        protected static void areNotEqual<TExpected, TActual>(TExpected e, TActual a, string message = null)
            => Assert.AreNotEqual(e, a, message);
        protected static void isNull<TExpected>(TExpected e, string message = null) => Assert.IsNull(e, message);
        protected static void isNotNull<TExpected>(TExpected e, string message = null) => Assert.IsNotNull(e, message);
        protected static void isTrue(bool e, string message = null) => Assert.IsTrue(e, message);
        protected static void isFalse(bool e, string message = null) => Assert.IsFalse(e, message);
        protected static void areEqualProperties<TObject>(TObject e, TObject a)
        {
	        Assert.AreNotSame(e, a);
	        foreach (var pi in e.GetType().GetProperties())
	        {
		        var expected = pi.GetValue(e);
		        var actual = pi.GetValue(a);
		        areEqual(expected, actual);
	        }
        }
    }
}
