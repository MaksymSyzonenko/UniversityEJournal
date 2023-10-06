using University_E_Journal_PostgreSQL.Data.Entities;
using University_E_Journal_PostgreSQL.Data.Repositories.Grade;
using University_E_Journal_PostgreSQL.Data.Repositories.Group;
using University_E_Journal_PostgreSQL.Data.Repositories.Student;
using University_E_Journal_PostgreSQL.Data.Repositories.Subject;
using University_E_Journal_PostgreSQL.Data.Repositories.Teacher;
using University_E_Journal_PostgreSQL.Exceptions;

namespace University_E_Journal_PostgreSQL.Data.Repositories.Factory
{
    public sealed class RepositoryFactory : IRepositoryFactory
    {
        public IRepository Instantiate<TEntity>(UniversityEJournalDbContext context) where TEntity : class
        {
            return typeof(TEntity).Name switch
            {
                nameof(StudentEntity) => new StudentRepository(context),
                nameof(TeacherEntity) => new TeacherRepository(context),
                nameof(SubjectEntity) => new SubjectRepository(context),
                nameof(GradeEntity) => new GradeRepository(context),
                nameof(GroupEntity) => new GroupRepository(context),
                _ => throw new UnsupportedRepositoryTypeException(typeof(TEntity).Name)
            };
        }
    }
}

