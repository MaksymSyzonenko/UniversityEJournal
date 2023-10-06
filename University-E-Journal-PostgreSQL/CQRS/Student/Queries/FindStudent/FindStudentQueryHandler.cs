using University_E_Journal_PostgreSQL.Data.Entities;
using University_E_Journal_PostgreSQL.Data.Repositories.Student;

namespace University_E_Journal_PostgreSQL.CQRS.Student.Queries.FindStudent
{
    public sealed class FindStudentQueryHandler : IFindStudentQueryHandler
    {
        private readonly IStudentRepository _repository;

        public FindStudentQueryHandler(IStudentRepository repository)
        {
            _repository = repository;
        }

        public async Task<StudentEntity?> Handle(FindStudentQuery query)
        {
            StudentEntity? entity = await _repository.FindSingle(query.Id);

            return entity != null ? new StudentEntity() : default;
        }
    }
}