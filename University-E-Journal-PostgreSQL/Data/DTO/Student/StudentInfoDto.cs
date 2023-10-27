using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_E_Journal_PostgreSQL.Data.DTO.Student
{
    public sealed record StudentInfoDto
    {
        public string? Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public int YearStudyStart { get; }
        public string GroupId { get; }
        public StudentInfoDto(string firstName, string lastName, int yearStudyStart, string groupdId)
        {
            FirstName = firstName;
            LastName = lastName;
            YearStudyStart = yearStudyStart;
            GroupId = groupdId;
        }
    }
}
