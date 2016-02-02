using GS.Portal.Domain.Entities;
using GS.Portal.Domain.Entities.Users;
using System.Collections.Generic;

namespace GS.Portal.Domain.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        int LastEmployeeSequenceNumber();

        List<UserRole> GetRoles();

        //User GetMasterUser(string id);
    }
}
