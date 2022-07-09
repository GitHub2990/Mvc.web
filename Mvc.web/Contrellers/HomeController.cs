using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mvc.web.Services;
using Mvc.web.Model;
using Mvc.web.ViewModels;

namespace Mvc.web.Contrellers
{
    public class HomeController : Controller
    {
        private readonly IRepotitery<Student> _repotitery;

        public HomeController(IRepotitery<Student> repotitery) 
        {
            _repotitery = repotitery;
        }

        public IActionResult Index()
        {
            var list = _repotitery.GetAll();
            var vms = list.Select(x => new StudentsViewModel
            {
                Name = $"{x.FristName}{x.LastName}",
                Age = DateTime.Now.Subtract(x.BirthDay).Days / 365
            }) ;
            var vm = new HomeIndexViewModel
            {
                Students = vms
            };
            return View(vm);
        }
    }
}
