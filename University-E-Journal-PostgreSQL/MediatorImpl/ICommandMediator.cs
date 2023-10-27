using University_E_Journal_PostgreSQL.CQRS.Core.Command;

namespace University_E_Journal_PostgreSQL.MediatorImpl
{
    public interface ICommandMediator
    {
        public Task Send<TCommand>(TCommand command) where TCommand : ICommand;
    }
}

