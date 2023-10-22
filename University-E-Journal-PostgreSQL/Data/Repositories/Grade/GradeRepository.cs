
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using University_E_Journal_PostgreSQL.Data.Entities;

namespace University_E_Journal_PostgreSQL.Data.Repositories.Grade
{
    public sealed class GradeRepository : IGradeRepository
    {
        private readonly UniversityEJournalDbContext _context;

        public GradeRepository(UniversityEJournalDbContext context)
        {
            _context = context;
        }

        public async Task Add(GradeEntity entity)
        {
            await _context.Grades.AddAsync(entity);
        }

        public async Task<string> GetBestResults(Guid subjectId, Guid groupId)
        {
            var result = await _context.Grades.Where(g => g.SubjectId == subjectId && g.Student.GroupId == groupId)
                           .GroupBy(g => g.Value)
                           .OrderByDescending(g => g.Key)
                           .FirstOrDefaultAsync();

            if (result != null)
            {
                int maxGradeCount = result.Count();
                int maxGrade = result.Key;

                return $"Number of max grade count: {maxGradeCount}, Max grade: {maxGrade}";
            }
            else
                return "No data.";
        }
        public async Task<IEnumerable<GradeEntity>> GetGradesForStudent(Guid id)
        {
            return await _context.Grades.Where(g => g.StudentId == id).ToListAsync();
        }
    }
}

