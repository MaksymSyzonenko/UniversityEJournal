using University_E_Journal_PostgreSQL.Data.Entities;

namespace University_E_Journal_PostgreSQL.Data.Repositories.Student
{
    public interface IStudentRepository : IRepository
    {
        Task Create(StudentEntity entity);
        Task<StudentEntity?> FindSingle(Guid id);
        
    }
}

