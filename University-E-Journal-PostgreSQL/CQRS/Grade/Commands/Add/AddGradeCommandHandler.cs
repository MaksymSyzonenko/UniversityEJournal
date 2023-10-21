using University_E_Journal_PostgreSQL.CQRS.Core.Command;
using University_E_Journal_PostgreSQL.Data.Entities;
using University_E_Journal_PostgreSQL.Data.Repositories.Grade;
using University_E_Journal_PostgreSQL.Data.UnitOfWork;

namespace University_E_Journal_PostgreSQL.CQRS.Grade.Commands.Add
{
    public sealed class AddGradeCommandHandler : IAddGradeCommandHandler
    {
        private readonly IUnitOfWork _unitOfWork;

        public AddGradeCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        async Task ICommandHandler<AddGradeCommand>.Handle(AddGradeCommand command)
        {
            DateOnly currentDate = DateOnly.FromDateTime(DateTime.Now);

            GradeEntity entity = new GradeEntity()
            {
                Id = Guid.NewGuid(),
                Value = command.Value,
                StudentId = command.StudentId,
                SubjectId = command.SubjectId,
                TeacherId = command.TeacherId,
                Date = currentDate
            };

            await ((IGradeRepository)_unitOfWork.Repository<GradeEntity>()).Add(entity);

            await _unitOfWork.Commit();
        }
    }
}
