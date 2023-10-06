using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using University_E_Journal_PostgreSQL.Data;

namespace University_E_Journal_PostgreSQL.Extensions
{
    public static class UniversityEJournalDataInstaller
    {
        public static IServiceCollection AddUniversityEJournalData(this IServiceCollection services, string connectionString) 
        {
            services.AddDbContextPool<UniversityEJournalDbContext>(options =>
            {
                options.UseNpgsql(connectionString, builder => builder.MigrationsAssembly("University-E-Journal-PostgreSQL"));
            });
            return services;
        }
    }
}
