using Microsoft.Extensions.DependencyInjection;
using University_E_Journal_PostgreSQL.Commands.Group.Create;
using University_E_Journal_PostgreSQL.Commands.Student.Create;

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
    }
}
