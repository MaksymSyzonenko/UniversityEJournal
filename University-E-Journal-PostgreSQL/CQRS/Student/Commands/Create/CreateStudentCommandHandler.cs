using University_E_Journal_PostgreSQL.CQRS.Core.Command;
using University_E_Journal_PostgreSQL.Data.Entities;
using University_E_Journal_PostgreSQL.Data.Repositories.Student;
using University_E_Journal_PostgreSQL.Data.UnitOfWork;

namespace University_E_Journal_PostgreSQL.CQRS.Student.Commands.Create
{
    public sealed class CreateStudentCommandHandler : ICreateStudentCommandHandler
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateStudentCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        async Task ICommandHandler<CreateStudentCommand>.Handle(CreateStudentCommand command)
        {
            StudentEntity entity = new StudentEntity()
            {
                Id = Guid.NewGuid(),
                FirstName = command.FirstName,
                LastName = command.LastName,
                YearStudyStart = command.YearStudyStart,
                GroupId = command.GroupId,
            };

            await ((IStudentRepository)_unitOfWork.Repository<StudentEntity>()).Create(entity);

            await _unitOfWork.Commit();
        }
    }
}