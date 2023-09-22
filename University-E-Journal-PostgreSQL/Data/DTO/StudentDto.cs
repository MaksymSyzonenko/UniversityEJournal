
namespace University_E_Journal_PostgreSQL.Data.DTO
{
    public sealed class StudentDto
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int YearStudyStart { get; set; }
        public Guid GroupID { get; set; }
    }
}
