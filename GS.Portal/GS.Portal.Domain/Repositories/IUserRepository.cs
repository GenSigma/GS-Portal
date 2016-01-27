using GS.Portal.Domain.Entities;

namespace GS.Portal.Domain.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        User GetMasterUser(string id);
    }
}
