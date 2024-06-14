using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ReportAdminStaff.Controllers
{
    public class BaseController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (HttpContext.Session.GetInt32("UserID") == null)
            {
                filterContext.Result = RedirectToAction("Index", "User");
            }
            
            base.OnActionExecuting(filterContext);
        }
    }
}
