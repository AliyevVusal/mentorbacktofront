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
    public class TrainersController : Controller
    {
        private readonly AppDbcontex _context;

        public TrainersController(AppDbcontex context)
        {
            _context = context;
        }
        public async Task<IActionResult> IndexAsync()
        {
            List<Trainer> trainer = await _context.Trainers.ToListAsync();


            return View(trainer);
        }
    }
}
