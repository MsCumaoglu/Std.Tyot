using Microsoft.AspNetCore.Mvc;
using Core.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.UI.Mvc.Core.ViewModel;

namespace Web.UI.Mvc.Core.Controllers
{
    public class UniversitiesController : Controller
    {
        private readonly IUniverstyService _universtyService;
        public UniversitiesController(IUniverstyService universtyService)
        {
            _universtyService = universtyService;
        }
        public async Task<IActionResult> Index()
        {
            UniversityVM data = new UniversityVM();
            data.universities= await _universtyService.GetAllAsync();
            return View(data);
        }
        public IActionResult Single()
        {
            return View();
        }

    }
}
