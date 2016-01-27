using GS.Portal.Data;
using GS.Portal.Domain.Entities;
using GS.Portal.Domain.Repositories;
using System.Linq;

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

        public User GetMasterUser(string id)
        {
            var user = new User();

            var contextUser = PortalContext.AspNetUsers.Where(x => x.Id == id).FirstOrDefault();

            user.Id = contextUser.Id;
            user.UserName = contextUser.UserName;
            user.Email = contextUser.Email;

            return user;
        }
    }
}
