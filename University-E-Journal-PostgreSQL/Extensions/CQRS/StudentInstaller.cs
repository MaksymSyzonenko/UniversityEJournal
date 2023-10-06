using Microsoft.Extensions.DependencyInjection;
using University_E_Journal_PostgreSQL.CQRS.Student.Commands.Create;
using University_E_Journal_PostgreSQL.CQRS.Student.Queries.FindStudent;

namespace University_E_Journal_PostgreSQL.Extensions.CQRS
{
    public static class StudentInstaller
    {
        public static IServiceCollection AddStudentCommands(this IServiceCollection services)
        {
            services
                .AddScoped<ICreateStudentCommandHandler, CreateStudentCommandHandler>();

            return services;
        }

        public static IServiceCollection AddStudentQueries(this IServiceCollection services)
        {
            services
                .AddScoped<IFindStudentQueryHandler, FindStudentQueryHandler>();

            return services;
        }
    }
}