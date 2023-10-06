using Microsoft.AspNetCore.Mvc;
using University_E_Journal.RestModels.Grade;
using University_E_Journal_PostgreSQL.CQRS.Grade.Queries.GetBestResults;
using University_E_Journal_PostgreSQL.Data.DTO.Grade;

namespace University_E_Journal.Controllers.Grade
{
    [ApiController]
    [Route("grades")]
    [ApiExplorerSettings(GroupName = "grades")]
    public class GradeGetBestResultsController : ControllerBase
    {
        private readonly IGetBestResultsQueryHandler _queryHandler;
        public GradeGetBestResultsController(IGetBestResultsQueryHandler queryHandler)
        {
            _queryHandler = queryHandler;
        }
        [HttpPost]
        [Route("get best results")]
        public async Task<ActionResult<string>> GetBestResults([FromBody] GradeDataRequest request)
        {
            if (request == null)
                return BadRequest("Invalid JSON data");

            try
            {
                string result = await _queryHandler.Handle(new GetBestResultsQuery(request.SubjectId, request.GroupId));
                return result;
            }
            catch
            {
                return StatusCode(500, $"Error");
            }
        }
    }
}
