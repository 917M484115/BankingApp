//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using BankingApp.Aids;
//using BankingApp.Data.Common;
//using BankingApp.Domain.Common;
//using BankingApp.Tests;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace Tests.Domain.Common
//{
//	[TestClass]
//	public class ValueObjectTests : AbstractClassTests<BaseEntity>
//	{
//		private TestData data;
//		private class testClass : ValueObject<TestData>
//		{
//			public testClass(TestData d) : base(d) { }
//		}
//		protected override object createObject()
//			=> new testClass(data);
//		[TestInitialize]
//		public override void TestInitialize()
//		{
//			data = GetRandom.ObjectOf<TestData>();
//			base.TestInitialize();
//		}
//		[TestMethod]
//		public void DataTest()
//		{
//			Assert.AreSame(data, (obj as testClass).Data);
//			Assert.AreNotSame(data, (obj as testClass).Data);
//			areEqualProperties(data, (obj as testClass).Data);
//		}
//		[TestMethod]
//		public void IsUnspecifiedTest()
//		{
//			isFalse((obj as testClass).IsUnspecified);
//			obj = new testClass(null);
//			isTrue((obj as testClass).IsUnspecified);
//		}
//	}
//}
