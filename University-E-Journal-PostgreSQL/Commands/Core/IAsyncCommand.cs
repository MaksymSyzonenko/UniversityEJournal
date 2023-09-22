using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_E_Journal_PostgreSQL.Commands.Core
{
    public interface IAsyncCommand
    {
        Task ExecuteAsync();
    }

    public interface IAsyncCommand<TResult>
    {
        Task<TResult> ExecuteAsync();
    }

    public interface IAsyncCommand<in TData, TResult>
    {
        Task<TResult> ExecuteAsync(TData data);
    }
}
