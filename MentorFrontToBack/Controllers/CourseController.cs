using MentorFrontToBack.DAL;
using MentorFrontToBack.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MentorFrontToBack.Controllers
{
    public class CourseController : Controller
    {
        private readonly AppDbcontex _context;

        public CourseController(AppDbcontex context)
        {
            _context = context;
        }
        public async Task<IActionResult> IndexAsync()
        {
            List<Course> course =await _context.Courses.ToListAsync();

            return View(course);
        }
    }
}
