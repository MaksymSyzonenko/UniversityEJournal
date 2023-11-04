using University_E_Journal_PostgreSQL.Data.Entities;

namespace University_E_Journal.Builder
{
    public abstract class CourseBuilder
    {
        public Course Course { get; set; }
        public abstract void AddCourseName();
        public abstract void AddSubjects();
        public abstract void AddCoursePricePerYear();
        public abstract void AddCourseDescription();
        protected void AddSubject(SubjectEntity subject)
        {
            Course.Subjects.Add(subject);
        }
    }
}
