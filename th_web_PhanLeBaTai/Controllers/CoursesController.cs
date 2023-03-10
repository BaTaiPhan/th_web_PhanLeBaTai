using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using th_web_PhanLeBaTai.Models;
using th_web_PhanLeBaTai.ViewModels;

namespace th_web_PhanLeBaTai.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Courses
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
                categories = _dbContext.Categories.ToList()
            };
            return View(viewModel);
            
        }
    }
}