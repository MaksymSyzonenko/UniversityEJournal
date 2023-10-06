using Microsoft.AspNetCore.Mvc;
using University_E_Journal_PostgreSQL.Commands.Group.Create;
using University_E_Journal_PostgreSQL.Data.DTO.Group;

namespace University_E_Journal.Controllers.Group
{
    [ApiController]
    [Route("groups")]
    [ApiExplorerSettings(GroupName = "groups")]
    public class GroupCreateController : ControllerBase
    {
        private readonly ICreateGroupCommand _command;
        public GroupCreateController(ICreateGroupCommand command)
        {
            _command = command;
        }
        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateGroup([FromBody] GroupDto dto)
        {
            if (dto == null)
                return BadRequest("Invalid JSON data");

            try
            {
                await _command.ExecuteAsync(dto);
                return Ok("Group created successfully");
            }
            catch
            {
                return StatusCode(500, $"Erorr");
            }
        }
    }
}
