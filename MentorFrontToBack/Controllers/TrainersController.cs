﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MentorFrontToBack.Controllers
{
    public class TrainersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
