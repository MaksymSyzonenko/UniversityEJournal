
using University_E_Journal_PostgreSQL.Data.Entities.Abstract;

namespace University_E_Journal_PostgreSQL.Data.Entities
{
    public sealed class AttendanceEntity : BaseEntity
    {
        public bool Attended { get; set; }
        public DateTime? AttendDate { get; set; }
        public Guid SubjectId { get; set; }
        public Guid StudentId { get; set; }
        public SubjectEntity Subject { get; set; }
        public StudentEntity Student { get; set; }
    }
}
