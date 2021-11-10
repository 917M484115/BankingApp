//using BankingApp.Aids;
//using BankingApp.Domain.Common;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Tests;

//namespace BankingApp.Tests
//{
//	[TestClass]
//	public class EntityTests : AbstractClassTests<ValueObject<TestData>>
//	{
//		private TestData data;

//		private class testClass : Entity<TestData>
//		{
//			public testClass(TestData d) : base(d) { }
//		}
//		protected override object createObject()
//		{
//			data = GetRandom.ObjectOf<TestData>();
//			return new testClass(data);
//		}
//		[TestMethod] public void ValidFromTest() => isProperty(data.From);
//		[TestMethod] public void ValidToTest() => isProperty(data.To);
//	}
//}
