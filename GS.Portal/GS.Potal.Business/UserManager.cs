using GS.Potal.Business.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GS.Portal.Domain.Entities;
using GS.Portal.Domain.HelperServices;
using GS.Portal.Data;

namespace GS.Potal.Business
{
    public class UserManager : IUserManager
    {
        public User GetMasterUser(string id)
        {
            using (var portal = new PortalUnitOfWork(new GS_PortalEntities()))
            {
                var test = portal.User.Get(1);
                return portal.User.GetMasterUser(id);
            }
        }
    }
}
