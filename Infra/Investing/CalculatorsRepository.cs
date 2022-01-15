using BankingApp.Infra.Common;
using BankingApp.Domain.Investing;
using BankingApp.Data.Investing;
using BankingApp.Domain.Investing.Repositories;

namespace BankingApp.Infra.Investing
{
    public sealed class CalculatorsRepository : UniqueEntitiesRepository<Calculator, CalculatorData>,ICalculatorsRepository
    {
        public CalculatorsRepository(ApplicationDbContext c): base(c,c.Calculators){}
        protected internal override Calculator toDomainObject(CalculatorData d)=> new Calculator(d);
    }
}
