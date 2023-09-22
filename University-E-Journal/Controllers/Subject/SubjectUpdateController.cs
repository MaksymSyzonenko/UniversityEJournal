using Microsoft.AspNetCore.Mvc;
using University_E_Journal_PostgreSQL.Commands.Subject.Update;
using University_E_Journal_PostgreSQL.Data.DTO;

namespace University_E_Journal.Controllers.Subject
{
    [ApiController]
    [Route("subjects")]
    [ApiExplorerSettings(GroupName = "subjects")]
    public sealed class SubjectUpdateController : ControllerBase
    {
        private readonly IUpdateSubjectCommand _command;
        public SubjectUpdateController(IUpdateSubjectCommand command)
        {
            _command = command;
        }
        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> CreateSubject([FromBody] SubjectUpdateDto data)
        {
            if (data == null)
                return BadRequest("Invalid JSON data");

            try
            {
                await _command.ExecuteAsync(data);
                return Ok("Subject updated successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
