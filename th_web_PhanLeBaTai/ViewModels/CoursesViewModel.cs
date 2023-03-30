using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using th_web_PhanLeBaTai.Models;

namespace th_web_PhanLeBaTai.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}