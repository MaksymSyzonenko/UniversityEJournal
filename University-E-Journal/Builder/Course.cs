using System.Text;
using System.Text.Json;
using University_E_Journal_PostgreSQL.Data.Entities;

namespace University_E_Journal.Builder
{
    public sealed class Course
    {
        public string CourseName { get; set; }
        public List<SubjectEntity> Subjects { get; set; }
        public decimal PricePerYear { get; set; }
        public string Description { get; set; }
        public override string ToString()
        {
            StringBuilder result = new();
            result.Append($"Course name: {CourseName}, ");
            result.Append(JsonSerializer.Serialize(Subjects) + ", ");
            result.Append($"Price per year: {PricePerYear}, ");
            result.Append($"About course: {Description}.");
            return result.ToString();
        }
    }
}
