//using BankingApp.Aids;
//using BankingApp.Data.Loan;
//using BankingApp.Domain.Common;
//using BankingApp.Domain.Loans;
//using BankingApp.Tests;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace Tests.Domain.Common
//{
//	[TestClass]
//	public class GetFromTests : SealedClassTests<object>
//	{
//		protected override object createObject() => new GetFrom<ICarLoanRepository, CarLoan>();

//		private string id;
//		private ICarLoanRepository carLoanRepo;
//		private CarLoanData carLoanData;

//		[TestMethod]
//		public void ByIdTest()
//		{
//			var o = new GetFrom<ICarLoanRepository, CarLoan>().ById(id);
//			areEqualProperties(carLoanData, o.Data);
//		}
//		[TestMethod]
//		public void ListByTest()
//		{
//			var l = new GetFrom<ICarLoanRepository, CarLoan>().ListBy(nameof(carLoanData.Code), carLoanData.Code);
//			areEqual(1, l.Count);
//			areEqualProperties(carLoanData, l[0].Data);
//		}
//		[TestMethod]
//		public void ListBySearchStringTest()
//		{
//			var l = new GetFrom<ICarLoanRepository, CarLoan>().ListBy(null, null, null);
//			areEqual(carLoanRepo.Get().GetAwaiter().GetResult().Count, l.Count);
//		}
//	}
//}
