using University_E_Journal_PostgreSQL.Data.Entities;
using University_E_Journal_PostgreSQL.Data;
using University_E_Journal_PostgreSQL.Data.DTO.Grade;

namespace University_E_Journal_PostgreSQL.Commands.Grade.Add
{
    public sealed class AddGradeCommand : IAddGradeCommand
    {
        private readonly UniversityEJournalDbContext _context;
        public AddGradeCommand(UniversityEJournalDbContext context)
        {
            _context = context;
        }
        public async Task ExecuteAsync(GradeDto dto)
        {
            GradeEntity grade = new()
            {
                Value = dto.Value,
                Date = dto.Date,
                StudentId = dto.StudentId,
                SubjectId = dto.SubjectId,
                TeacherId = dto.TeacherId,
            };

            _context.Grades.Add(grade);
            await _context.SaveChangesAsync();
        }
    }
}
