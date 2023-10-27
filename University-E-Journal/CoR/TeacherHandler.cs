﻿using University_E_Journal_PostgreSQL.Data.Entities.Abstract;
using University_E_Journal_PostgreSQL.Data.Entities;

namespace University_E_Journal.CoR
{
    public class TeacherHandler : DocumentHandler
    {
        public override Document HandleRequest(Document document)
        {
            if (document.SignerEntity is EntityType.TeacherEntity && document.Title == "Salary")
            {
                document.IsSigned = true;
                return document;
            }
            else
                return Successor?.HandleRequest(document) ?? document;
        }
    }
}