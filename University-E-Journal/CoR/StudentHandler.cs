using System.Reflection.Metadata.Ecma335;
using University_E_Journal_PostgreSQL.Data.Entities;
using University_E_Journal_PostgreSQL.Data.Entities.Abstract;

namespace University_E_Journal.CoR
{
    public class StudentHandler : DocumentHandler
    {
        public override Document HandleRequest(Document document)
        {
            if (document.SignerEntity is EntityType.StudentEntity && document.Title == "Scholarship")
            {
                document.IsSigned = true;
                return document;
            }
            else
                return Successor?.HandleRequest(document) ?? document;
        }
    }
}
