using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.UI.Mvc.Core.ViewModel
{
    public class FacultyVM
    {
        public FacultyVM()
        {
            faculty = new Faculty();
            university = new University();
            cities = new City();
            colleges = new List<College>();
            StudingDegrees = new List<StudingDegree>();
        }
        public Faculty faculty { get; set; }
        public University university { get; set; }
        public City cities { get; set; }
        public IEnumerable<College> colleges { get; set; }
        public IEnumerable<StudingDegree> StudingDegrees { get; set; }
    }
}
