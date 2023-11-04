using Microsoft.Extensions.DependencyInjection;
using University_E_Journal_PostgreSQL.CQRS.Grade.Commands.Add;
using University_E_Journal_PostgreSQL.CQRS.Grade.Queries.GetBestResults;
using University_E_Journal_PostgreSQL.CQRS.Student.Queries.FindStudent;

namespace University_E_Journal_PostgreSQL.Extensions.CQRS
{
    public static class GradeInstaller
    {
        public static IServiceCollection AddGradeCommandsCQRS(this IServiceCollection services)
        {
            services
                .AddScoped<IAddGradeCommandHandler, AddGradeCommandHandler>();

            return services;
        }

        public static IServiceCollection AddGradeQueriesCQRS(this IServiceCollection services)
        {
            services
                .AddScoped<IGetBestResultsQueryHandler, GetBestResultsQueryHandler>();

            return services;
        }
    }
}
