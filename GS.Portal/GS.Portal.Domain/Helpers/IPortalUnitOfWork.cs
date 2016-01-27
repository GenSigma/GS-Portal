using GS.Portal.Domain.Repositories;
using System;

namespace GS.Portal.Domain.Helpers
{
    public interface IPortalUnitOfWork : IDisposable
    {
        IUserRepository User { get; }
        int Complete();

        //void BeginTransaction();
        //void Commit();
    }
}
