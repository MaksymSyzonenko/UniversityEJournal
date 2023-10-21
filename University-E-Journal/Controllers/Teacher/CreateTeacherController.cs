using Microsoft.AspNetCore.Mvc;
using University_E_Journal_PostgreSQL.Commands.Teacher.Create;
using University_E_Journal_PostgreSQL.Data.DTO.Teacher;

namespace University_E_Journal.Controllers.Teacher
{
    [ApiController]
    [Route("teachers")]
    [ApiExplorerSettings(GroupName = "teachers")]
    public sealed class TeacherCreateController : ControllerBase
    {
        private readonly ICreateTeacherCommand _command;
        public TeacherCreateController(ICreateTeacherCommand command)
        {
            _command = command;
        }
        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateTeacher([FromBody] TeacherDto dto)
        {
            if (dto == null)
                return BadRequest("Invalid JSON data");

            try
            {
                await _command.ExecuteAsync(dto);
                return Ok("Teacher created successfully");
            }
            catch
            {
                return StatusCode(500, $"Error");
            }
        }
    }
}
