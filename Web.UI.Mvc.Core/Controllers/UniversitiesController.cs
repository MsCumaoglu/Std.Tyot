using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.UI.Mvc.Core.Controllers
{
    public class UniversitiesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Single()
        {
            return View();
        }

    }
}
