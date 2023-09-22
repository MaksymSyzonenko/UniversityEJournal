using University_E_Journal_PostgreSQL.Data.Entities.Abstract;

namespace University_E_Journal_PostgreSQL.Data.Entities
{
    public sealed class TeacherEntity : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public ICollection<SubjectEntity> Subjects { get; set; }
        public ICollection<GradeEntity> Grades { get; set; }
    }
}
