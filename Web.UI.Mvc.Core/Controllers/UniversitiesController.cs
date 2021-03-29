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
        private readonly IUniversityService _universtyService;
        private readonly IFacultyService _facultyService;
        private readonly ICityService _cityService;
        public UniversitiesController(IUniversityService universtyService, ICityService cityService,IFacultyService facultyService)
        {
            _universtyService = universtyService;
            _cityService = cityService;
            _facultyService = facultyService;
        }
        public async Task<IActionResult> Index()
        {
            UniversityVM data = new UniversityVM();
            data.cities = await _cityService.GetAllAsync();
            data.universities= await _universtyService.GetAllAsync();

            return View(data);
        }
        public async Task<IActionResult> Single(int id)
        {
            UniversityVM data = new UniversityVM();
            data.university = await _universtyService.GetByIdAsync(id);
            data.faculties = await _facultyService.GetFacultiesByUniversityIdAsync(id);
            return View(data);
        }

    }
}
