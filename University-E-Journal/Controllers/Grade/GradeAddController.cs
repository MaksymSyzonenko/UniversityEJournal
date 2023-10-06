using Microsoft.AspNetCore.Mvc;
using University_E_Journal_PostgreSQL.Commands.Grade.Add;
using University_E_Journal_PostgreSQL.Data.DTO;

namespace University_E_Journal.Controllers.Grade
{
    [ApiController]
    [Route("grades")]
    [ApiExplorerSettings(GroupName = "grades")]
    public class GradeAddController : ControllerBase
    {
        private readonly IAddGradeCommand _command;
        public GradeAddController(IAddGradeCommand command)
        {
            _command = command;
        }
        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> CreateGrade([FromBody] GradeDto dto)
        {
            if (dto == null)
                return BadRequest("Invalid JSON data");

            try
            {
                await _command.ExecuteAsync(dto);
                return Ok("Grade was added successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
