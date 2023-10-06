using Microsoft.Extensions.DependencyInjection;
using University_E_Journal_PostgreSQL.Commands.Grade.Add;
using University_E_Journal_PostgreSQL.Commands.Grade.Cancel;
using University_E_Journal_PostgreSQL.Commands.Group.Create;
using University_E_Journal_PostgreSQL.Commands.Student.Create;
using University_E_Journal_PostgreSQL.Commands.Subject.Create;
using University_E_Journal_PostgreSQL.Commands.Subject.Update;
using University_E_Journal_PostgreSQL.Commands.Teacher.Create;

namespace University_E_Journal_PostgreSQL.Extensions
{
    public static class CommandInstaller
    {
        public static IServiceCollection AddStudentCommands(this IServiceCollection services)
        {
            services.AddScoped<ICreateStudentCommand, CreateStudentCommand>();
            return services;
        }
        public static IServiceCollection AddGroupCommands(this IServiceCollection services)
        {
            services.AddScoped<ICreateGroupCommand, CreateGroupCommand>();
            return services;
        }
        public static IServiceCollection AddTeacherCommands(this IServiceCollection services)
        {
            services.AddScoped<ICreateTeacherCommand, CreateTeacherCommand>();
            return services;
        }
        public static IServiceCollection AddGradeCommands(this IServiceCollection services)
        {
            services.AddScoped<IAddGradeCommand, AddGradeCommand>();
            services.AddScoped<ICancelGradeCommand, CancelGradeCommand>();
            return services;
        }
        public static IServiceCollection AddSubjectCommands(this IServiceCollection services)
        {
            services.AddScoped<ICreateSubjectCommand, CreateSubjectCommand>();
            services.AddScoped<IUpdateSubjectCommand, UpdateSubjectCommand>();
            return services;
        }
    }
}
