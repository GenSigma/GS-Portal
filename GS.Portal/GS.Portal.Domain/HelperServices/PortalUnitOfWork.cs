using GS.Portal.Data;
using GS.Portal.Domain.Helpers;
using GS.Portal.Domain.Repositories;
using GS.Portal.Domain.RepositoryServices;

namespace GS.Portal.Domain.HelperServices
{
    public class PortalUnitOfWork : IPortalUnitOfWork
    {
        public readonly GS_PortalEntities _portalContext;

        public PortalUnitOfWork(GS_PortalEntities context)
        {
            _portalContext = context;
            User = new UserRepository(_portalContext);
        }

        public IUserRepository User { get; private set; }

        public int Complete()
        {
            return _portalContext.SaveChanges();
        }

        public void Dispose()
        {
            _portalContext.Dispose();
        }
    }
}
