using EFCoreRepository.DataContext;
using Entities.Interfaces;
using Entities.POCOEntities;
using Entities.Specifications;
using System.Collections.Generic;
using System.Linq;

namespace EFCoreRepository.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext Context;
        public OrderRepository(AppDbContext context)
        {
            Context = context;
        }

        public void Create(Orden orden)
        {
            Context.Add(orden);
        }

        public IEnumerable<Orden> OrderBySpecification(Specification<Orden> specification)
        {
            var ExpressionDelegate = specification.Expression.Compile();

            return Context.Ordens.Where(ExpressionDelegate);
        }
    }
}
