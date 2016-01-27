using GS.Portal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GS.Potal.Business.Interface
{
    public interface IUserManager
    {
        User GetMasterUser(string id);
    }
}
