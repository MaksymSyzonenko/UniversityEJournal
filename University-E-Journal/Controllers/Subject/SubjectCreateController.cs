using Microsoft.AspNetCore.Mvc;
using University_E_Journal_PostgreSQL.Commands.Subject.Create;
using University_E_Journal_PostgreSQL.Data.DTO.Subject;

namespace University_E_Journal.Controllers.Subject
{
    [ApiController]
    [Route("subjects")]
    [ApiExplorerSettings(GroupName = "subjects")]
    public sealed class SubjectCreateController : ControllerBase
    {
        private readonly ICreateSubjectCommand _command;
        public SubjectCreateController(ICreateSubjectCommand command)
        {
            _command = command;
        }
        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateSubject([FromBody] SubjectDto dto)
        {
            if (dto == null)
                return BadRequest("Invalid JSON data");

            try
            {
                await _command.ExecuteAsync(dto);
                return Ok("Subject created successfully");
            }
            catch
            {
                return StatusCode(500, $"Error");
            }
        }
    }
}
