using GS.Portal.Domain.Entities.Users;
using System.Collections.Generic;

namespace GS.Potal.Business.Interface
{
    public interface IUserManager
    {
        int LastEmployeeSequenceNumber();

        List<UserRole> GetRoles();
    }
}
