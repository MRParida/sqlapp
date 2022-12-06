using Microsoft.AspNetCore.Mvc;
using sqlapp.Models;
using sqlapp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sqlapp.Controllers
{
    public class CourseController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        // Dependency injection
        private readonly CourseService _course_service;

        public CourseController(CourseService _svc)
        {
            this._course_service = _svc;
        }

        public IActionResult Index()
        {
            IEnumerable<Course> _course_list = _course_service.GetCourse();
            return View(_course_list);
        }



    }
}
