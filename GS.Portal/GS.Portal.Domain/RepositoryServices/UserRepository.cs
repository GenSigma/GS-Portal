using GS.Portal.Data;
using GS.Portal.Domain.Entities;
using GS.Portal.Domain.Repositories;
using System.Linq;
using System;
using GS.Portal.Domain.Entities.Users;
using System.Collections.Generic;

namespace GS.Portal.Domain.RepositoryServices
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(GS_PortalEntities context)
            :base(context)
        {
                
        }

        public GS_PortalEntities PortalContext
        {
            get { return _context as GS_PortalEntities; }
        }

        public List<UserRole> GetRoles()
        {
            var userRoles = new List<UserRole>();

            userRoles = PortalContext.AspNetRoles.Select(x => new UserRole()
            {
                Id = x.Id,
                Name = x.Name
            }).ToList<UserRole>();

            return userRoles;
        }

        public int LastEmployeeSequenceNumber()
        {
            var user = new User();

            return PortalContext.AspNetUsers.Max(x => x.EmpSeqNo);
        }
    }
}
