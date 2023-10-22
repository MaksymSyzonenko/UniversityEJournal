using University_E_Journal_PostgreSQL.Data.Entities;

namespace University_E_Journal_PostgreSQL.Data.Repositories.Grade
{
    public interface IGradeRepository : IRepository
    {
        Task Add(GradeEntity entity);
        Task<string> GetBestResults(Guid subjectId, Guid groupId);
        Task<IEnumerable<GradeEntity>> GetGradesForStudent(Guid id);
    }
}

