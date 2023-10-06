using Microsoft.AspNetCore.Mvc;
using University_E_Journal_PostgreSQL.Commands.Student.Create;
using University_E_Journal_PostgreSQL.Data.DTO;

namespace University_E_Journal.Controllers.StudentController
{
    [ApiController]
    [Route("students")]
    [ApiExplorerSettings(GroupName = "students")]
    public sealed class StudentCreateController : ControllerBase
    {
        private readonly ICreateStudentCommand _command;
        public StudentCreateController(ICreateStudentCommand command)
        {
            _command = command;
        }
        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateStudent([FromBody] StudentDto dto)
        {
            if (dto == null)
                return BadRequest("Invalid JSON data");

            try
            {
                await _command.ExecuteAsync(dto);
                return Ok("Student created successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
