using University_E_Journal_PostgreSQL.Data.Repositories.Grade;

namespace University_E_Journal_PostgreSQL.CQRS.Grade.Queries.GetBestResults
{
    public sealed class GetBestResultsQueryHandler : IGetBestResultsQueryHandler
    {
        private readonly IGradeRepository _repository;

        public GetBestResultsQueryHandler(IGradeRepository repository)
        {
            _repository = repository;
        }

        public async Task<string> Handle(GetBestResultsQuery query)
        {
            string result = await _repository.GetBestResults(query.SubjectId, query.GroupId);

            return result;
        }
    }
}
