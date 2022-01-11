namespace BankingApp.Data.Common 
    {
    public abstract class NamedEntityData :UniqueEntityData, IUniqueNamedData 
        {
        public string Code { get; set; }
        public string Name { get; set; }
        //public string BlockChain { get; set; }
    }

}
