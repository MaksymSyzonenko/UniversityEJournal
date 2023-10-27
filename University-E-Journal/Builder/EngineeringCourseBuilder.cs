using University_E_Journal_PostgreSQL.Data.Entities;

namespace University_E_Journal.Builder
{
    public sealed class EngineeringCourseBuilder : CourseBuilder
    {
        public override void AddCourseDescription()
        {
            Course.Description = "Learning Engineering";
        }

        public override void AddCourseName()
        {
            Course.CourseName = "Engineering";
        }

        public override void AddCoursePricePerYear()
        {
            Course.PricePerYear = 17000;
        }

        public override void AddSubjects()
        {
            AddSubject(new SubjectEntity { Name = "Math" });
            AddSubject(new SubjectEntity { Name = "Geometry" });
            AddSubject(new SubjectEntity { Name = "Physics" });
        }
    }
}
