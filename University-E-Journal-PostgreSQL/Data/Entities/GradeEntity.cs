using University_E_Journal_PostgreSQL.Data.Entities.Abstract;

namespace University_E_Journal_PostgreSQL.Data.Entities
{
    public sealed class GradeEntity : BaseEntity
    {
        public int Value { get; set; }
        public DateOnly Date { get; set; }
        public Guid StudentId { get; set; }
        public Guid SubjectId { get; set; }
        public Guid TeacherId{ get; set; }
        public StudentEntity Student { get; set; }
        public SubjectEntity Subject { get; set; }
        public TeacherEntity Teacher { get; set; }
    }
}
