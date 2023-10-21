using University_E_Journal_PostgreSQL.Data.Entities.Abstract;

namespace University_E_Journal_PostgreSQL.Data.Entities
{
    public sealed class StudentEntity : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearStudyStart { get; set; }
        public Guid GroupId { get; set; }
        public GroupEntity Group { get; set; }
        public ICollection<GradeEntity> Grades { get; set; }
        public ICollection<SubjectEntity> Subjects { get; set; }
        public ICollection<AttendanceEntity> Attendances { get; set; }
    }
}
