using Microsoft.Extensions.DependencyInjection;

namespace University_E_Journal_PostgreSQL.Extensions.CQRS
{
    public static class SqrsInstaller
    {
        public static IServiceCollection AddSQRS(this IServiceCollection services)
        {
            services
                .AddStudentCommands()
                .AddStudentQueries();

            services
                .AddGradeCommands() 
                .AddGradeQueries();

            return services;
        }
    }
}

