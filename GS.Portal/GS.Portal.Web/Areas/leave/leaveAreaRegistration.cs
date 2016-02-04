using System.Web.Mvc;

namespace GS.Portal.Web.Areas.leave
{
    public class leaveAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "leave";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "leave_default",
                "leave/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}