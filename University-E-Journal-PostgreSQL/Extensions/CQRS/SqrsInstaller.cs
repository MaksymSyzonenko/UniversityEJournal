using Microsoft.Extensions.DependencyInjection;
using University_E_Journal_PostgreSQL.MediatorImpl;

namespace University_E_Journal_PostgreSQL.Extensions.CQRS
{
    public static class SqrsInstaller
    {
        public static IServiceCollection AddSQRS(this IServiceCollection services)
        {
            services
                .AddScoped<IMediator, Mediator>();

            services
                .AddStudentCommandsCQRS()
                .AddStudentQueriesCQRS();

            services
                .AddGradeCommandsCQRS() 
                .AddGradeQueriesCQRS();

            return services;
        }
    }
}

