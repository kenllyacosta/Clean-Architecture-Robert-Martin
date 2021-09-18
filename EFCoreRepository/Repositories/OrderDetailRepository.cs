using EFCoreRepository.DataContext;
using Entities.Interfaces;
using Entities.POCOEntities;
using Entities.Specifications;
using System.Collections.Generic;
using System.Linq;

namespace EFCoreRepository.Repositories
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private readonly AppDbContext Context;
        public OrderDetailRepository(AppDbContext context) => Context = context;

        public void Create(Orden_Detail orden_Detail)
        {
            Context.Add(orden_Detail);
        }

        public IEnumerable<Orden_Detail> GetBySpecification(Specification<Orden_Detail> specification)
        {
            var ExpressionDelegate = specification.Expression.Compile();

            return Context.Orden_Details.Where(ExpressionDelegate);
        }
    }
}
