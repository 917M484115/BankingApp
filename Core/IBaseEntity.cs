namespace BankingApp.Core
{
    public interface IBaseEntity
    {
        public string Id { get; }
        public byte[] RowVersion { get; }
    }
}
