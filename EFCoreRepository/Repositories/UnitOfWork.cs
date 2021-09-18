using EFCoreRepository.DataContext;
using Entities.Interfaces;
using System.Threading.Tasks;

namespace EFCoreRepository.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly AppDbContext _unitOfWork;
        public UnitOfWork(AppDbContext context) => _unitOfWork = context;

        public Task<int> SavechangesAsync()
        {
            return _unitOfWork.SaveChangesAsync();
        }
    }
}
