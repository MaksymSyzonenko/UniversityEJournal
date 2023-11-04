using University_E_Journal_PostgreSQL.Data.Entities;

namespace University_E_Journal.Builder
{
    public sealed class ComputerScienceCourseBuilder : CourseBuilder
    {
        public override void AddCourseDescription()
        {
            Course.Description = "Learning programming";
        }

        public override void AddCourseName()
        {
            Course.CourseName = "Computer Science";
        }

        public override void AddCoursePricePerYear()
        {
            Course.PricePerYear = 22000;
        }

        public override void AddSubjects()
        {
            AddSubject(new SubjectEntity { Name = "Programming" });
            AddSubject(new SubjectEntity { Name = "Design Patterns" });
            AddSubject(new SubjectEntity { Name = "UI.UX Design"});
        }
        
    }
}
