using BankingApp.Infra.Common;
using BankingApp.Domain.Investing;
using BankingApp.Data.Investing;
using BankingApp.Domain.Investing.Repositories;

namespace BankingApp.Infra.Investing
{
    public sealed class CalculatorsRepository : UniqueEntitiesRepository<Calculator, CalculatorData>,ICalcuatorsRepository
    {
        public CalculatorsRepository(ApplicationDbContext c): base(c,c.Calculator){}
        protected internal override Calculator toDomainObject(CalculatorData d)=> new Calculator(d);
    }
}
