using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_E_Journal_PostgreSQL.Data.DTO
{
    public sealed class SubjectDto
    {
        public string Name { get; set; }
        public Guid TeacherID { get; set; }
    }
}
