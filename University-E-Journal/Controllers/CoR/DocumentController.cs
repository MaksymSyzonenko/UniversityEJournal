using Microsoft.AspNetCore.Mvc;
using University_E_Journal.CoR;

namespace University_E_Journal.Controllers.CoR
{
    [ApiController]
    [Route("documents")]
    [ApiExplorerSettings(GroupName = "documents")]
    public class CourseController : ControllerBase
    {
        [HttpPost]
        [Route("signDocument")]
        public ActionResult<string> SignDocument([FromBody] Document document)
        {
            DocumentHandler student = new StudentHandler();
            DocumentHandler teacher = new TeacherHandler();
            DocumentHandler dean = new DeanHandler();
            student.Successor = teacher;
            teacher.Successor = dean;
            var response = student.HandleRequest(document);
            if (response.IsSigned)
                return $"Document was signed by {response.SignerEntity}";
            return $"Sign Erorr! ({response.IsSigned})";
        }
    }
}
