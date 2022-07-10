using Mvc.web.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.web.ViewModels
{
    public class StudentCreateViewModel
    {
        [Display(Name ="性")]
        [Required(ErrorMessage ="名称必填")]
        public string FristName { get; set; }
        [Display(Name = "名"), Required ,MaxLength(10)]
        public string LastName { get; set; }
        [Display(Name = "出生日期")]
        public DateTime BirthDay { get; set; }
        [Display(Name = "性别")]
        public Gender Gender { get; set; }
    }
}
