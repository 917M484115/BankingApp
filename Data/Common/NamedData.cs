using System.ComponentModel.DataAnnotations;
using BankingApp.Core;

namespace BankingApp.Data.Common
{
    public abstract class NamedData : BaseData, INamedEntityData
    {
        [StringLength(50)] public string Name { get; set; }

        //TODO Gunnaril on siin Code ka, vaadata, miks ja teha vajadusel ümber
    }
}
