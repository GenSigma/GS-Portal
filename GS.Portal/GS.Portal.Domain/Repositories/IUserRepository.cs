using GS.Portal.Domain.Entities;
using GS.Portal.Domain.Entities.Users;
using System.Collections.Generic;

namespace GS.Portal.Domain.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        int LastEmployeeSequenceNumber();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        List<UserRole> GetRoles();
    }
}
