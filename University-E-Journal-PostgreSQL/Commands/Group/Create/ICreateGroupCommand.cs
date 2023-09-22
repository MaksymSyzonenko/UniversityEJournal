﻿using University_E_Journal_PostgreSQL.Commands.Core;
using University_E_Journal_PostgreSQL.Data.DTO;

namespace University_E_Journal_PostgreSQL.Commands.Group.Create
{
    public interface ICreateGroupCommand : INoResponseAsyncCommand<GroupDto>
    {
    }
}
