using Microsoft.AspNetCore.Mvc;
using University_E_Journal.Builder;

namespace University_E_Journal.Controllers.Course
{
    [ApiController]
    [Route("courses")]
    [ApiExplorerSettings(GroupName = "courses")]
    public class CourseController : ControllerBase
    {
        private CourseBuilder? _builder;
        private readonly Deanery _deanery = new();
        [HttpPost]
        [Route("computerScienceCourseBuilder")]
        public ActionResult<string> BuildComputerScienceCourse()
        {
            _builder = new ComputerScienceCourseBuilder();
            Builder.Course computerScienceCourse = _deanery.CreateCourse(_builder);
            return computerScienceCourse.ToString();
        }
        [HttpPost]
        [Route("engineeringCourseBuilder")]
        public ActionResult<string> BuildEngineeringCourse()
        {
            _builder = new EngineeringCourseBuilder();
            Builder.Course engineeringCourse = _deanery.CreateCourse(_builder);
            return engineeringCourse.ToString();
        }
    }
}
