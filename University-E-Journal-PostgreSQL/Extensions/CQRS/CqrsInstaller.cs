using Microsoft.Extensions.DependencyInjection;
using University_E_Journal_PostgreSQL.MediatorImpl;

namespace University_E_Journal_PostgreSQL.Extensions.CQRS
{
    public static class CqrsInstaller
    {
        public static IServiceCollection AddCQRS(this IServiceCollection services)
        {
            

            services
                .AddStudentCommandsCQRS()
                .AddStudentQueriesCQRS();

            services
                .AddGradeCommandsCQRS() 
                .AddGradeQueriesCQRS();

            services
                .AddScoped<IMediator, Mediator>();

            return services;
        }
    }
}

