using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TryIdentity.Controllers
{
    [Authorize(Roles ="admin, sales")]
    public class SecretController : Controller
    {
        
        public ContentResult Secret()
        {
            return Content("This is a secret...");
        }

        [AllowAnonymous]
        public ContentResult Overt()
        {
            return Content("This is not a secret...");
        }
        // GET: Secret
        public ActionResult Index()
        {
            return View();
        }
    }
}