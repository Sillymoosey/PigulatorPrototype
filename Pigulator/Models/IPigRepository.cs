
using System.Linq;
using Pigulator.Data;

namespace Pigulator.Models
{
    public interface IPigRepository
    {
       public IQueryable<Pigs> Pigs { get; }

    }
}
