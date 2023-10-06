using Microsoft.AspNetCore.Mvc;
using University_E_Journal_PostgreSQL.Commands.Student.Create;
using University_E_Journal_PostgreSQL.CQRS.Student.Commands.Create;
using University_E_Journal_PostgreSQL.CQRS.Student.Queries.FindStudent;
using University_E_Journal_PostgreSQL.Data.DTO.Student;
using University_E_Journal_PostgreSQL.Data.Entities;

namespace University_E_Journal.Controllers.StudentController
{
    [ApiController]
    [Route("students")]
    [ApiExplorerSettings(GroupName = "students")]
    public sealed class StudentCreateController : ControllerBase
    {
        private readonly ICreateStudentCommand _command;
        private readonly ICreateStudentCommandHandler _commandHandler;
        private readonly IFindStudentQueryHandler _queryHandler;
        public StudentCreateController(ICreateStudentCommand command, ICreateStudentCommandHandler commandHandler, IFindStudentQueryHandler queryHandler)
        {
            _command = command;
            _commandHandler = commandHandler;
            _queryHandler = queryHandler;
        }
        [HttpPost]
        [Route("create(Command Pattern)")]
        public async Task<IActionResult> CreateStudent([FromBody] StudentDto dto)
        {
            if (dto == null)
                return BadRequest("Invalid JSON data");

            try
            {
                await _command.ExecuteAsync(dto);
                return Ok("Student created successfully");
            }
            catch
            {
                return StatusCode(500, $"Error!");
            }
        }
        [HttpPost]
        [Route("create(CQRS Pattern)")]
        public async Task<IActionResult> CreateStudentCQRS([FromBody] StudentDto dto)
        {
            if (dto == null)
                return BadRequest("Invalid JSON data");

            try
            {
                StudentEntity? entity = await _queryHandler.Handle(new FindStudentQuery(dto.Id));
                if (entity == null)
                {
                    await _commandHandler
                    .Handle(new University_E_Journal_PostgreSQL.CQRS.Student.Commands.Create.CreateStudentCommand
                    (
                        dto.FirstName,
                        dto.LastName,
                        dto.YearStudyStart,
                        dto.GroupId
                    ));
                    return Ok("Student created successfully");
                }
                else
                    return StatusCode(500, $"This student exists!");
            }
            catch
            {
                return StatusCode(500, $"Error!");
            }
        }
    }
}
