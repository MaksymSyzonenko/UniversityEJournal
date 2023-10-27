using Microsoft.Extensions.DependencyInjection;
using University_E_Journal_PostgreSQL.Data.Repositories.Attendances;
using University_E_Journal_PostgreSQL.Data.Repositories.Factory;
using University_E_Journal_PostgreSQL.Data.Repositories.Grade;
using University_E_Journal_PostgreSQL.Data.Repositories.Group;
using University_E_Journal_PostgreSQL.Data.Repositories.Student;
using University_E_Journal_PostgreSQL.Data.Repositories.Subject;
using University_E_Journal_PostgreSQL.Data.Repositories.Teacher;
using University_E_Journal_PostgreSQL.Data.UnitOfWork;

namespace University_E_Journal_PostgreSQL.Extensions
{
    public static class DataAccessInstaller
    {
        public static IServiceCollection AddDataAccess(this IServiceCollection services)
        {
            services
                .AddScoped<IStudentRepository, StudentRepository>()
                .AddScoped<ITeacherRepository, TeacherRepository>()
                .AddScoped<IGradeRepository, GradeRepository>()
                .AddScoped<ISubjectRepository, SubjectRepository>()
                .AddScoped<IGroupRepository, GroupRepository>()
                .AddScoped<IAttendanceRepository, AttendanceRepository>();

            services
                .AddSingleton<IRepositoryFactory, RepositoryFactory>()
                .AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}

