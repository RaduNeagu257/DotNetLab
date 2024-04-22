using CompanyManagement.Core.Services;
using CompanyManagement.Database.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CompanyManagement.Core.Extensions
{
    public static class ServicesExtension
    {
        public static void AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();

            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        }

    }
}
