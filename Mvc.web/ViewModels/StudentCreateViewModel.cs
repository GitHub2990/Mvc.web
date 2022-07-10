using Mvc.web.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.web.ViewModels
{
    public class StudentCreateViewModel
    {
        public string FristName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public Gender Gender { get; set; }
    }
}
