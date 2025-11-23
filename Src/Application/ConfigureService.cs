using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Application.Common.BehavioursPipe;

namespace Application;

public static class ConfigureService
{
    public static void AddApplicationServices(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(Assembly.GetExecutingAssembly());
        //pipeLiner
        services.AddTransient(typeof(IPipelineBehavior<,>),typeof(PerformanceBehaviour<,>));
        services.AddTransient(typeof(IPipelineBehavior<,>),typeof(CachedQueryBehaviour<,>));
    }
}
