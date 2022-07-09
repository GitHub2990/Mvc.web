using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.web.ViewModels
{
    public class HomeIndexViewModel
    {
      public  IEnumerable<StudentsViewModel> Students { get; set; }
    }
}
