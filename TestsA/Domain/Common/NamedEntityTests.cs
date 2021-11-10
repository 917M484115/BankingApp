//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using BankingApp.Aids;
//using BankingApp.Domain.Common;
//using BankingApp.Tests;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace Tests.Domain.Common
//{
//	[TestClass]
//	public class NamedEntityTests : AbstractClassTests<UniqueEntity<TestData>>
//	{
//		private TestData data;

//		private class testClass : NamedEntity<TestData>
//		{
//			public testClass(TestData d) : base(d) { }
//		}
//		protected override object createObject()
//		{
//			data = GetRandom.ObjectOf<TestData>();
//			return new testClass(data);
//		}
//		[TestMethod] public void NameTest() => isProperty(data.Name);
//		[TestMethod] public void CodeTest() => isProperty(data.Code);
//	}
//}
