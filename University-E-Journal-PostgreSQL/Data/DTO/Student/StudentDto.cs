
namespace University_E_Journal_PostgreSQL.Data.DTO.Student
{
    public sealed class StudentDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int YearStudyStart { get; set; }
        public Guid GroupId { get; set; }
    }
}
