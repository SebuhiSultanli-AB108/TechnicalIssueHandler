using Microsoft.Extensions.DependencyInjection;
using TechnicalIssueHandler.BL.Services.DesignationServices;
using TechnicalIssueHandler.BL.Services.EmployeeServices;

namespace TechnicalIssueHandler.BL
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddService(this IServiceCollection services)
        {
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IDesignationService, DesignationService>();
            return services;
        }
        public static IServiceCollection AppAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ServiceRegistration));
            return services;
        }
    }
}
