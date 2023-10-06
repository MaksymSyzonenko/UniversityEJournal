using University_E_Journal_PostgreSQL.Data.Entities.Abstract;

namespace University_E_Journal_PostgreSQL.Data.Entities
{
    public sealed class GroupEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Departmant { get; set; }
        public ICollection<StudentEntity> Students { get; set; }
    }
}
