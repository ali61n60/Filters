using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Filters.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            if (!Request.IsHttps)
            {
                return new StatusCodeResult(StatusCodes.Status403Forbidden);
            }
            else
            {

                return View("Message",
                    "This is the Index action on the Home controller " +
                    HttpContext.Connection.RemoteIpAddress + " " +
                    HttpContext.Connection.RemotePort);
            }
        }
    }
}
