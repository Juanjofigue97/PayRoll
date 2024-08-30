using Microsoft.Extensions.DependencyInjection;
using PayRoll_Infrastructure.Data;
using PayRoll_Infrastructure.Databases;

namespace PayRoll_Infrastructure;

public static class DependencyInjection 
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddTransient<IDataAccess, SqlDataAccess>();
        services.AddTransient<IAgencyRepository, SqlAgencyRepository>();
        services.AddTransient<IEmployeeRepository, SqlEmployeeRepository>();
        services.AddTransient<IPaymentRepository, SqlPaymentRepository>();
        return services;
    }
}
