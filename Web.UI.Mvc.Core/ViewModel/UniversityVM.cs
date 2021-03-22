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
            universities = new List<University>();
        }
        public IEnumerable<University>  universities{ get; set; }
    }
}
