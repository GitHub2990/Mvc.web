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
            {   Id=x.Id,
                Name = $"{x.FristName}{x.LastName}",
                Age = DateTime.Now.Subtract(x.BirthDay).Days / 365
            }) ;
            var vm = new HomeIndexViewModel
            {
                Students = vms
            };
            return View(vm);
        }


        public IActionResult Detail(int Id)
        {
            var student =  _repotitery.GetStudent(Id);
            var studentVM = new StudentsViewModel
            {
                Id = student.Id,
                Name = $"{student.FristName}{student.LastName}",
                Age = DateTime.Now.Subtract(student.BirthDay).Days / 365
            };
            return View(studentVM);
        }


        [HttpGet]
        public IActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Create(StudentCreateViewModel student)
        {
            var newStudent = new Student
            {
                FristName = student.FristName,
                LastName = student.LastName,
                BirthDay = student.BirthDay,
                Gender = student.Gender
            };
           var newModel =  _repotitery.add(newStudent);



            //post 后请重定向   不然刷新页面 容易重复提交
            //return View("ShowInfo", newModel);
          
            //重定向
            return RedirectToAction(nameof(Detail),new { Id=newModel.Id });
        }

     
    }
}
