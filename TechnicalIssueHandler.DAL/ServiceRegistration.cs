using Microsoft.Extensions.DependencyInjection;
using TechnicalIssueHandler.Core.RepositoryInterfaces;
using TechnicalIssueHandler.DAL.RepositoryImplements;

namespace TechnicalIssueHandler.DAL
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IDesignationRepository, DesignationRepository>();
            return services;
        }
    }
}