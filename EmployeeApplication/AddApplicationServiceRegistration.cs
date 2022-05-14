namespace EmployeeApplication
{
    using EmployeeApplication.Interfaces;
    using EmployeeApplication.Services;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    public static class AddApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationSerices(this IServiceCollection collection)
        {
            collection.AddScoped<IEmployeeService, EmployeeService>();
            return collection;
        }
    }
}
