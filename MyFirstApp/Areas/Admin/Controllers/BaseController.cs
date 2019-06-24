using MyFirstApp.Areas.Admin.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyFirstApp.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        public string userName { get; set; }

        public string userId { get; set; }

        public UserRepository userData = new UserRepository();

        public ContentRepository contentData = new ContentRepository();
        
        // GET: Admin/Base
        public ActionResult Index()
        {
            return View();
        }

        protected override IAsyncResult BeginExecute(RequestContext requestContext, AsyncCallback callback, object state)
        {
            userName = requestContext.HttpContext.Session["username"]?.ToString();

            userId = requestContext.HttpContext.Session["userid"]?.ToString();

            return base.BeginExecute(requestContext, callback, state);
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string[] NO_CHECK_PATH = {
                "/",
                "/Admin/Auth/Login",
                @"/Home/*",
            };

            if (NO_CHECK_PATH.Contains(filterContext.HttpContext.Request.Path)) { return; }

            if (Session["userid"] == null)
            {
                // セッション値を初期化
                filterContext.HttpContext.Session.RemoveAll();

                filterContext.Result = new RedirectResult("~/Admin/Auth/Login");
                return;
            }

            base.OnActionExecuting(filterContext);
        }
    }
}