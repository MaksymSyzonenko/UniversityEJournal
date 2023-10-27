﻿
namespace University_E_Journal_PostgreSQL.Data.DTO.Student
{
    public sealed record StudentDto
    {
        public string? Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public int YearStudyStart { get; }
        public string GroupId { get; }
        public StudentDto(string id, string firstName, string lastName, int yearStudyStart, string groupId)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            YearStudyStart = yearStudyStart;
            GroupId = groupId;
        }
    }
}
