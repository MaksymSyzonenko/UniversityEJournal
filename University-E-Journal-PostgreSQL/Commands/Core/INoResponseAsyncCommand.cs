using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_E_Journal_PostgreSQL.Commands.Core
{
    public interface INoResponseAsyncCommand<in TData>
    {
        Task ExecuteAsync(TData data);
    }
}
