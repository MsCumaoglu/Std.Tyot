using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.UI.Mvc.Core.ViewModel
{
    public class UniversityVM
    {

        public UniversityVM()
        {
            university = new University();
            universities = new List<University>();
            cities = new List<City>();
            faculties = new List<Faculty>();
        }
        public University university { get; set; }
        public IEnumerable<University>  universities{ get; set; }
        public IEnumerable<City>  cities{ get; set; }
        public IEnumerable<Faculty> faculties { get; set; }
    }
}
