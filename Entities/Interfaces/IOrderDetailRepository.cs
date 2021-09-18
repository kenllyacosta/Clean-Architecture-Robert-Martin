using Entities.POCOEntities;
using Entities.Specifications;
using System.Collections.Generic;

namespace Entities.Interfaces
{
    public interface IOrderDetailRepository
    {
        void Create(Orden_Detail orden_Detail);
        IEnumerable<Orden_Detail> GetBySpecification(Specification<Orden_Detail> specification);
    }
}
