using University_E_Journal_PostgreSQL.Data.Entities.Abstract;

namespace University_E_Journal.CoR
{
    public enum EntityType
    {
        StudentEntity,
        TeacherEntity,
        DeanEntity
    }
    public sealed class Document
    {
        public string Title { get; }
        public string Content { get; }
        public EntityType SignerEntity { get; }
        public bool IsSigned { get; set; } = false;
        public Document(string title, string content, EntityType signerEntity)
        {
            Title = title;
            Content = content;
            SignerEntity = signerEntity;
        }
    }
}
