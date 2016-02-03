using GS.Portal.Domain.Entities.Users;
using System.Collections.Generic;

namespace GS.Potal.Business.Interface
{
    public interface IUserManager
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
