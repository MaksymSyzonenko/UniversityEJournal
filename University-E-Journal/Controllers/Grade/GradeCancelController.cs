using Microsoft.AspNetCore.Mvc;
using University_E_Journal_PostgreSQL.Commands.Grade.Cancel;
using University_E_Journal_PostgreSQL.Data.DTO;

namespace University_E_Journal.Controllers.Grade
{
    [ApiController]
    [Route("grades")]
    [ApiExplorerSettings(GroupName = "grades")]
    public class GradeCancelController : ControllerBase
    {
        private readonly ICancelGradeCommand _command;
        public GradeCancelController(ICancelGradeCommand command)
        {
            _command = command;
        }
        [HttpPut]
        [Route("cancel")]
        public async Task<IActionResult> CancelGrade([FromBody] string Id)
        {
            if (string.IsNullOrEmpty(Id))
                return BadRequest("Invalid JSON data");

            try
            {
                await _command.ExecuteAsync(Guid.Parse(Id));
                return Ok("Grade was canceled successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
