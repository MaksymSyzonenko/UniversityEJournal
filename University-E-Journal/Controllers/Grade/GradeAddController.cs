using Microsoft.AspNetCore.Mvc;
using University_E_Journal_PostgreSQL.Commands.Grade.Add;
using University_E_Journal_PostgreSQL.CQRS.Grade.Commands.Add;
using University_E_Journal_PostgreSQL.Data.DTO.Grade;

namespace University_E_Journal.Controllers.Grade
{
    [ApiController]
    [Route("grades")]
    [ApiExplorerSettings(GroupName = "grades")]
    public class GradeAddController : ControllerBase
    {
        private readonly IAddGradeCommand _command;
        private readonly IAddGradeCommandHandler _commandHandler;
        public GradeAddController(IAddGradeCommand command, IAddGradeCommandHandler commandHandler)
        {
            _command = command;
            _commandHandler = commandHandler;
        }
        [HttpPost]
        [Route("add(Command Pattern)")]
        public async Task<IActionResult> AddGrade([FromBody] GradeDto dto)
        {
            if (dto == null)
                return BadRequest("Invalid JSON data");

            try
            {
                await _command.ExecuteAsync(dto);
                return Ok("Grade was added successfully");
            }
            catch
            {
                return StatusCode(500, $"Error");
            }
        }
        [HttpPost]
        [Route("add(CQRS Pattern)")]
        public async Task<IActionResult> AddGradeCQRS([FromBody] GradeDto dto)
        {
            if (dto == null)
                return BadRequest("Invalid JSON data");

            try
            {
                await _commandHandler
                    .Handle(new University_E_Journal_PostgreSQL.CQRS.Grade.Commands.Add.AddGradeCommand
                    (
                        dto.Value,
                        dto.Date,
                        dto.StudentId,
                        dto.SubjectId,
                        dto.TeacherId
                    ));
                return Ok("Grade was added successfully");
            }
            catch
            {
                return StatusCode(500, $"Error!");
            }
        }
    }
}
