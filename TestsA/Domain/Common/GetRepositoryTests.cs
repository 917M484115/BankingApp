//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using BankingApp.Domain.ATMs;
//using BankingApp.Domain.Common;
//using BankingApp.Domain.Investing;
//using BankingApp.Tests;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace Tests.Domain.Common
//{
//	[TestClass]
//	public class GetRepositoryTests : BaseTests
//	{
//		private IATMRepository ATMRepo;
//		private IATMManagerRepository brandsRepo;
//		private IInvestmentRepository catalogsRepo;
//		private MockServiceProvider provider;

//		[TestInitialize]
//		public void TestInitialize()
//		{
//			type = typeof(GetRepository);
//			ATMRepo = MockRepos.ATMRepo();
//			ATMManagerRepo = MockRepos.ATMManagerRepo();
//			InvestmentRepo = MockRepos.InvestmentRepo();
//			provider = new MockServiceProvider(ATMRepo, ATMManagerRepo, InvestmentRepo);
//			GetRepository.SetServiceProvider(null);
//		}
//		[TestMethod]
//		public void SetServiceProviderTest()
//		{
//			isNull(GetRepository.services);
//			GetRepository.SetServiceProvider(provider);
//			Assert.AreSame(provider, GetRepository.services);
//		}
//		[TestMethod]
//		public void InstanceTest()
//		{
//			GetRepository.SetServiceProvider(provider);
//			var r = GetRepository.Instance(typeof(IATMRepository));
//			Assert.AreSame(r, ATMRepo);
//		}
//		[TestMethod]
//		public void InstanceByTypeTest()
//		{
//			GetRepository.SetServiceProvider(provider);
//			var r = GetRepository.Instance<IInvestmentRepository>();
//			Assert.AreSame(r, catalogsRepo);
//		}
//	}
//}
