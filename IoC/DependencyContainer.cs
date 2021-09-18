using EFCoreRepository.DataContext;
using EFCoreRepository.Repositories;
using Entities.Interfaces;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UseCases.Common.Behaviors;
using UseCases.CreateOrder;

namespace IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddNWTradersServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("cnnString")));
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddMediatR(typeof(CreateOrderInteractor));
            services.AddValidatorsFromAssembly(typeof(CreateOrderValidator).Assembly);
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
            return services;
        }
    }
}
