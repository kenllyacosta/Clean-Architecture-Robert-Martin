using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EFCoreRepository.DataContext
{
    internal class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var OptionBuilder = new DbContextOptionsBuilder<AppDbContext>();
            OptionBuilder.UseSqlServer("Data Source = .;Initial Catalog=databaseNWTradersDb;Integrated Security = True");

            return new AppDbContext(OptionBuilder.Options);
        }
    }
}
