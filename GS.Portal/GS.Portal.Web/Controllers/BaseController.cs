using GS.Portal.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GS.Portal.Web.Controllers
{
    public class BaseController : Controller
    {
        public IPortalUnitOfWork UnitOfWork { get; set; }

        //protected override void OnActionExecuting(ActionExecutingContext filterContext)
        //{
        //    if (!filterContext.IsChildAction)
        //        UnitOfWork.BeginTransaction();
        //}

        //protected override void OnResultExecuted(ResultExecutedContext filterContext)
        //{
        //    if (!filterContext.IsChildAction)
        //        UnitOfWork.Commit();
        //}
    }
}