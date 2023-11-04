namespace University_E_Journal.Builder
{
    public class Deanery
    {
        public Course CreateCourse(CourseBuilder courseBuilder)
        {
            courseBuilder.AddCourseName();
            courseBuilder.AddCourseDescription();
            courseBuilder.AddCoursePricePerYear();
            courseBuilder.AddSubjects();
            return courseBuilder.Course;
        }
    }
}
