using University_E_Journal_PostgreSQL.CQRS.Core.Query;
using University_E_Journal_PostgreSQL.Data.DTO.Student;
using University_E_Journal_PostgreSQL.Data.Entities;
using University_E_Journal_PostgreSQL.Data.Repositories.Student;

namespace University_E_Journal_PostgreSQL.CQRS.Student.Queries.FindStudent
{
    public sealed class FindStudentQueryHandler : IQueryHandler<FindStudentQuery, StudentInfoDto?>
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

        async Task<StudentInfoDto?> IQueryHandler<FindStudentQuery, StudentInfoDto?>.Handle(FindStudentQuery query)
        {
            StudentEntity? entity = await _repository.FindSingle(query.Id);

            return entity != null ? new StudentInfoDto(entity.FirstName, entity.LastName, entity.YearStudyStart, entity.GroupId.ToString()) : null;
        }
    }
}