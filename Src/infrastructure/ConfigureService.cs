using Application.Contracts;
using Infrastructure.Persistence;
using Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class ConfigureService
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services , IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(opttion =>
        {
            opttion.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        });
        //services.AddScoped(typeof(IGenericRepositry<>),typeof(GenericRepository<>));
        services.AddScoped<IUnitOWork, UnitOWork>();
        return services;
    }
}
