using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Filters.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Filters.Controllers
{
    [HttpsOnly]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Message",
                    "This is the Index action on the Home controller " +
                    HttpContext.Connection.RemoteIpAddress + " " +
                    HttpContext.Connection.RemotePort);
        }
        public ViewResult SecondAction() => View("Message",
            "This is the SecondAction action on the Home controller");
    }

    
}
