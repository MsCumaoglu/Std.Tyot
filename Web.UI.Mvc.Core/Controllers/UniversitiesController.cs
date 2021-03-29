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
        private readonly IStudingDegreeService _studingDegreeService;
                private readonly IFacultyService _facultyService;
        private readonly ICityService _cityService;
        private readonly IUniversityGalleryService _universityGalleryService;
        private readonly ICollegeService _collegeService;
        public UniversitiesController(IUniversityService universtyService, 
            ICityService cityService, 
            IFacultyService facultyService, 
            IUniversityGalleryService universityGalleryService, 
            ICollegeService collegeService,
            IStudingDegreeService studingDegreeService
            )
        {
            _universtyService = universtyService;
            _cityService = cityService;
            _facultyService = facultyService;
            _universityGalleryService = universityGalleryService;
            _collegeService = collegeService;
            _studingDegreeService = studingDegreeService;
        }
        public async Task<IActionResult> Index()
        {
            UniversityVM data = new UniversityVM();
            data.cities = await _cityService.GetAllAsync();
            data.universities = await _universtyService.GetAllAsync();

            return View(data);
        }
        public async Task<IActionResult> Single(int id)
        {
            UniversityVM data = new UniversityVM();
            data.university = await _universtyService.GetByIdAsync(id);
            data.faculties = await _facultyService.GetFacultiesByUniversityIdAsync(id);
            data.universityGallery = await _universityGalleryService.GetImagesByUniversityIdAsync(id);
            return View(data);
        }
        public async Task<IActionResult> Faculty(int id)
        {
            FacultyVM data = new FacultyVM();
            data.faculty = await _facultyService.GetByIdAsync(id);
            data.university = await _universtyService.GetByIdAsync(data.faculty.UniversityId);
            data.colleges = await _collegeService.GetCollegesByFacultyIdAsync(id);
            data.StudingDegrees = await _studingDegreeService.GetAllAsync();
            return View(data);
        }

    }
}
