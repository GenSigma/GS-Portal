using GS.Portal.Data;
using GS.Portal.Domain.Entities.Users;
using GS.Portal.Domain.HelperServices;
using GS.Potal.Business.Interface;
using System;
using System.Collections.Generic;

namespace GS.Potal.Business
{
    public class UserManager : IUserManager
    {
        public int LastEmployeeSequenceNumber()
        {
            using (var portal = new PortalUnitOfWork(new GS_PortalEntities()))
            {
                return portal.User.LastEmployeeSequenceNumber();
            }
        }

        public List<UserRole> GetRoles()
        {
            using (var portal = new PortalUnitOfWork(new GS_PortalEntities()))
            {
                return portal.User.GetRoles();
            }
        }
    }
}
