using University_E_Journal_PostgreSQL.Data;
using University_E_Journal_PostgreSQL.Data.Entities;
using University_E_Journal_PostgreSQL.Data.DTO.Student;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

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
                Id = Guid.NewGuid(),
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                YearStudyStart = dto.YearStudyStart,
                GroupId = Guid.Parse(dto.GroupId)
            };

            _context.Students.Add(student);
            await _context.SaveChangesAsync();
        }
    }
}
