using University_E_Journal_PostgreSQL.Data;
using University_E_Journal_PostgreSQL.Data.Entities;
using University_E_Journal_PostgreSQL.Data.DTO;

namespace University_E_Journal_PostgreSQL.Commands.Student.Create
{
    public sealed class CreateStudentCommand : ICreateStudentCommand
    {
        private readonly UniversityEJournalDbContext _context;
        public CreateStudentCommand(UniversityEJournalDbContext context)
        {
            _context = context;
        }
        public async Task ExecuteAsync(StudentDto dto)
        {
            StudentEntity student = new()
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                YearStudyStart = dto.YearStudyStart,
                GroupID = dto.GroupID
            };

            _context.Students.Add(student);
            await _context.SaveChangesAsync();
        }
    }
}
