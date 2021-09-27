namespace BankingApp.Core
{
    public interface INamedEntityData : IBaseEntity
    {
        public string Name { get; set; }
    }
}
