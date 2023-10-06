
namespace University_E_Journal_PostgreSQL.Data.DTO
{
    public sealed class GradeDto
    {
        public int Value { get; set; }
        public DateOnly Date { get; set; }
        public Guid StudentID { get; set; }
        public Guid SubjectID { get; set; }
        public Guid TeacherID { get; set; }
    }
}
