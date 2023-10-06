using University_E_Journal_PostgreSQL.Data.Entities.Abstract;

namespace University_E_Journal_PostgreSQL.Data.Entities
{
    public sealed class SubjectEntity : BaseEntity
    {
        public string Name { get; set; }
        public Guid TeacherId { get; set; } 
        public TeacherEntity Teacher { get; set; }
        public ICollection<GradeEntity> Grades { get; set; }
        public ICollection<StudentEntity> Students { get; set; }
    }
}
