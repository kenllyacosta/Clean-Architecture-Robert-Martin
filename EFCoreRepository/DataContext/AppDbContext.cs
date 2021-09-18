using Entities.POCOEntities;
using Microsoft.EntityFrameworkCore;
using System;

namespace EFCoreRepository.DataContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<BusinessEntity> BusinessEntities { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Orden> Ordens { get; set; }
        public DbSet<Orden_Detail> Orden_Details { get; set; }
    }
}
