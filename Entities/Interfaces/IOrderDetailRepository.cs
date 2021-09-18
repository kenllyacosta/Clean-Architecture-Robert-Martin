using Entities.POCOEntities;
using Entities.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
    public interface IOrderDetailRepository
    {
        void Create(Orden_Detail orden_Detail);
        IEnumerable<Orden_Detail> GetBySpecification(Specification<Orden_Detail> specification);
    }
}
