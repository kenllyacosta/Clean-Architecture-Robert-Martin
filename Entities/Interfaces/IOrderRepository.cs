using Entities.POCOEntities;
using Entities.Specifications;
using System.Collections.Generic;

namespace Entities.Interfaces
{
    public interface IOrderRepository
    {
        void Create(Orden orden);
        IEnumerable<Orden> OrderBySpecification(Specification<Orden> specification);
    }
}
