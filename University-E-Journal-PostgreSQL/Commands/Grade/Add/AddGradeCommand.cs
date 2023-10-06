using University_E_Journal_PostgreSQL.Data.Entities;
using University_E_Journal_PostgreSQL.Data;
using University_E_Journal_PostgreSQL.Data.DTO;

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
                StudentID = dto.StudentID,
                SubjectID = dto.SubjectID,
                TeacherID = dto.TeacherID,
            };

            _context.Grades.Add(grade);
            await _context.SaveChangesAsync();
        }
    }
}
