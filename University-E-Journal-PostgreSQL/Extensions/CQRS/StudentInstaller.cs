using Microsoft.Extensions.DependencyInjection;
using University_E_Journal_PostgreSQL.CQRS.Core.Query;
using University_E_Journal_PostgreSQL.CQRS.Student.Commands.Create;
using University_E_Journal_PostgreSQL.CQRS.Student.Queries.FindStudent;
using University_E_Journal_PostgreSQL.Data.DTO.Student;

namespace University_E_Journal_PostgreSQL.Extensions.CQRS
{
    public static class StudentInstaller
    {
        public static IServiceCollection AddStudentCommandsCQRS(this IServiceCollection services)
        {
            services
                .AddScoped<ICreateStudentCommandHandler, CreateStudentCommandHandler>();

            return services;
        }

        public static IServiceCollection AddStudentQueriesCQRS(this IServiceCollection services)
        {
            //services
            //    .AddScoped<IFindStudentQueryHandler, FindStudentQueryHandler>();

            services
                .AddScoped<IQueryHandler<FindStudentQuery, StudentInfoDto?>, FindStudentQueryHandler>();

            return services;
        }
    }
}