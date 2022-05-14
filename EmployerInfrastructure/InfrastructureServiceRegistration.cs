namespace EmployerInfrastructure
{
    using EmployerDomain.Interfaces;
    using EmployerInfrastructure.Repositories;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            return GetInstructureCollection(services, configuration.GetConnectionString("DbConnection"));
        }

        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, string connectionString)
        {
            return GetInstructureCollection(services, connectionString);
        }

        private static IServiceCollection GetInstructureCollection(IServiceCollection services, string connectionString)
        {
            services.AddDbContext<EmployeeDbContext>(
                options => options
                .UseSqlServer(connectionString)   
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            return services;
        }
    }
}
