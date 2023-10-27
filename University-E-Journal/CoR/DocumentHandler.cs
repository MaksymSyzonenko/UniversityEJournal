using University_E_Journal_PostgreSQL.Data.Entities.Abstract;

namespace University_E_Journal.CoR
{
    public abstract class DocumentHandler
    {
        public DocumentHandler? Successor { get; set; }
        public abstract Document HandleRequest(Document document);
    }
}
