using University_E_Journal_PostgreSQL.Data.Entities;
using University_E_Journal_PostgreSQL.Data;
using University_E_Journal_PostgreSQL.Data.DTO;

namespace University_E_Journal_PostgreSQL.Commands.Group.Create
{
    public sealed class CreateGroupCommand : ICreateGroupCommand
    {
        private readonly UniversityEJournalDbContext _context;
        public CreateGroupCommand(UniversityEJournalDbContext context)
        {
            _context = context;
        }
        public async Task ExecuteAsync(GroupDto dto)
        {
            GroupEntity group = new()
            {
                Name = dto.Name,
                Departmant = dto.Departmant
            };

            _context.Groups.Add(group);
            await _context.SaveChangesAsync();
        }
    }
}
