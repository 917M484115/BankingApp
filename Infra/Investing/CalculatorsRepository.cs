using BankingApp.Infra.Common;
using BankingApp.Domain.Investing;
using BankingApp.Data.Investing;
namespace BankingApp.Infra.Investing
{
    public sealed class CalculatorsRepository : UniqueEntitiesRepository<Calcuator, CalculatorData>,ICalcuatorsRepository
    {
        public CalculatorsRepository(ApplicationDbContext c): base(c,c.Calculator){}
        protected internal override Calcuator toDomainObject(CalculatorData d)=> new Calcuator(d);
    }
}
