using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
using University_E_Journal_PostgreSQL.Commands.Student.Create;
using University_E_Journal_PostgreSQL.CQRS.Core.Query;
using University_E_Journal_PostgreSQL.CQRS.Student.Commands.Create;
using University_E_Journal_PostgreSQL.CQRS.Student.Queries.FindStudent;
using University_E_Journal_PostgreSQL.Data.DTO.Student;
using University_E_Journal_PostgreSQL.Data.Entities;
using University_E_Journal_PostgreSQL.MediatorImpl;

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
        private readonly IMediator _mediator;
        public StudentCreateController(
            ICreateStudentCommand command, 
            ICreateStudentCommandHandler commandHandler, 
            IFindStudentQueryHandler queryHandler,
            IMediator mediator)
        {
            _command = command;
            _commandHandler = commandHandler;
            _queryHandler = queryHandler;
            _mediator = mediator;
        }
        [HttpPost]
        [Route("create(Mediator Pattern)")]
        public async Task<IActionResult> CreateStudentMediator([FromBody] StudentDto dto)
        {
            if (dto == null)
                return BadRequest("Invalid JSON data");

            if (dto.Id != null && dto.Id != string.Empty)
            {
                StudentInfoDto? studentInfo = await _mediator.Send<FindStudentQuery, StudentInfoDto?>(new FindStudentQuery(Guid.Parse(dto.Id!)));
                if (studentInfo != null)
                    return Ok("Student with this Id exists.");
            }

            University_E_Journal_PostgreSQL.CQRS.Student.Commands.Create.CreateStudentCommand createStudentCommand = new(
                dto.FirstName,
                dto.LastName,
                dto.YearStudyStart,
                dto.GroupId);

            try
            {
                await _mediator.Send(createStudentCommand); 
                return Ok("Student created successfully");
            }
            catch
            {
                return StatusCode(500, $"Error!");
            }
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
                StudentEntity? entity = await _queryHandler.Handle(new FindStudentQuery(Guid.Parse(dto.Id!)));
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
